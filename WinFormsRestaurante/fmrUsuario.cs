using System;
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

        public void LimparCampos()
        {
            txBoxSenha.Text = "";
            txBoxConfSenha.Text = "";
            txBoxUsuario.Text = "";
            txBoxUsuario.Focus();
        }

        public void LimparSenhas()
        {
            txBoxSenha.Text = "";
            txBoxConfSenha.Text = "";
            txBoxSenha.Focus();
        }

        public void LimparUsuario()
        {
            txBoxUsuario.Text = "";
            txBoxUsuario.Focus();
            this.Carregar();
        }

        public DataTable Carregar()
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT ID,USUARIO,SUPERVISOR FROM USUARIOS";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            dataGridViewUsuario.DataSource = dataTable;

            return dataTable;
        }

        public DataTable AtualizarDados()
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT ID,USUARIO,SUPERVISOR FROM USUARIOS";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            dataGridViewUsuario.DataSource = dataTable;
            return dataTable;
        }
        public void Excluir(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspUsuariosExcluir";
            sqlCommand.Parameters.AddWithValue("@usuarioId", usuario.Id);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
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
            usuario.Login = txBoxUsuario.Text;
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT ID,USUARIO,SUPERVISOR FROM USUARIOS WHERE USUARIO = '"+ usuario.Login +"' ";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dataGridViewUsuario.DataSource = dataTable;
            usuario.Senha = txBoxSenha.Text;



                
            if ((String.IsNullOrWhiteSpace(txBoxUsuario.Text)) || (String.IsNullOrWhiteSpace(txBoxSenha.Text)) || (String.IsNullOrWhiteSpace(txBoxConfSenha.Text)))
            {
                MessageBox.Show("Para Cadastrar, TODOS CAMPOS devem ser preenchidos. Tente novamente.");
                LimparCampos();
            }

            else if (dataGridViewUsuario.Rows.Count == 2)
            {
                MessageBox.Show("Este nome de usuário já está em uso, tente outro.");
                LimparUsuario();
            }

            else if (txBoxSenha.Text != txBoxConfSenha.Text)
            {
                MessageBox.Show("As senhas devem conferir. Tente novamente.");
                LimparSenhas();    
            }

            else
            {
                if (rdBtnSimUsuario.Checked)
                {
                    usuario.Supervisor = 1;
                }

                else
                {
                    usuario.Supervisor = 0;
                }

                usuario.Login = txBoxUsuario.Text;
                usuario.Senha = txBoxSenha.Text;

                DialogResult cadastro = MessageBox.Show("Confirma a inclusão do usuário " + txBoxUsuario.Text + " ?","Alerta",MessageBoxButtons.YesNo);
                if (cadastro == DialogResult.Yes)
                {
                    CadUsuario(usuario);
                    MessageBox.Show("Usuario cadastrado com sucesso !");
                    LimparCampos();
                    AtualizarDados();
                }

                else
                {
                    LimparCampos();
                }
            }
        }

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Deseja realmente excluir o usuario selecionado ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (excluir == DialogResult.Yes)
            {
                Usuario usuario = new Usuario();
                usuario.Id = (Int32)dataGridViewUsuario.CurrentRow.Cells[0].Value;
                Excluir(usuario);
                MessageBox.Show("Usuario excluído com sucesso !");
                LimparCampos();
                AtualizarDados();
            }
        }

        private void fmrUsuario_Load(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}