﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRestaurante.Properties;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsRestaurante
{
    public partial class fmrUsuario : Form
    {
        public fmrUsuario()
        {
            InitializeComponent();
        }

        public void CadUsuario(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
          
            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspUsuariosCadastrar";
            sqlCommand.Parameters.AddWithValue("@usuario", usuario.Login);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@supervisor", usuario.Supervisor);
         
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO = '"+ usuario.Login +"' ";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dataGridViewUsuario.DataSource = dataTable;

            usuario.Login = txBoxUsuario.Text;
            usuario.Senha = txBoxSenha.Text;
                
            if ((String.IsNullOrWhiteSpace(txBoxUsuario.Text)) || (String.IsNullOrWhiteSpace(txBoxSenha.Text)) || (String.IsNullOrWhiteSpace(txBoxConfSenha.Text)))
            {
                MessageBox.Show("Para Cadastrar, TODOS CAMPOS devem ser preenchidos. Tente novamente.");
                txBoxUsuario.Focus();
            }

            else if (dataGridViewUsuario.Rows.Count == 2)
            {
                MessageBox.Show("Este nome de usuário já está em uso, tente outro.");
                txBoxUsuario.Text = "";
                txBoxUsuario.Focus();
            }

            else if (txBoxSenha.Text != txBoxConfSenha.Text)
            {
                MessageBox.Show("As senhas devem conferir. Tente novamente.");
                txBoxSenha.Text = ""; 
                txBoxConfSenha.Text = "";
                txBoxSenha.Focus();

                
            }

            else if(rdBtnSimUsuario.Checked)
            {
                usuario.Supervisor = 1;
            }

            else if (rdBtnNaoUsuario.Checked)
            {
                usuario.Supervisor = 0;
            }

            else
            {
                usuario.Login = txBoxUsuario.Text;
                usuario.Senha = txBoxSenha.Text;

                DialogResult cadastro = MessageBox.Show("Confirma a inclusão do usuário " + txBoxUsuario.Text + " ?","Alerta",MessageBoxButtons.YesNo);
                if (cadastro == DialogResult.Yes)
                {
                    this.CadUsuario(usuario);
                    MessageBox.Show("Usuario cadastrado com sucesso !");
                }

                else
                {
                    txBoxSenha.Text = "";
                    txBoxConfSenha.Text = "";
                    txBoxUsuario.Text = "";
                    txBoxUsuario.Focus();
                }
            }
        }

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txBoxSenha.Text = "";
            txBoxConfSenha.Text = "";
            txBoxUsuario.Text = "";
            txBoxUsuario.Focus();
        }
    }
}