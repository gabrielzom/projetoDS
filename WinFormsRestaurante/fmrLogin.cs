using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsRestaurante.Properties;

namespace WinFormsRestaurante
{
    public partial class FmrLogin : Form
    {  
        public FmrLogin()
        {
            InitializeComponent();
        }
        public void LimparCampos()
        {
            txBoxUserLogin.Text = "";
            txBoxUserPassword.Text = "";
            txBoxUserLogin.Focus();
        }
        public DataTable Login(Usuario usuario)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection sqlConnection = new SqlConnection();
            
            sqlConnection.ConnectionString = Settings.Default.connectionString;

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspUsuariosAutenticar";
            sqlCommand.Parameters.AddWithValue("@usuario", usuario.Login);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return dataTable;
        }
        SqlDataReader VerificarTipoUsuario(Usuario usuario)
        {
            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlConnection.ConnectionString = Settings.Default.connectionString;

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspUsuariosAutenticar";
            sqlCommand.Parameters.AddWithValue("@usuario", usuario.Login);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlDataReader = sqlCommand.ExecuteReader();

            return sqlDataReader;
        }

        private void btnConfirmLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = txBoxUserLogin.Text;
            usuario.Senha = txBoxUserPassword.Text;

            DataTable dataTable = Login(usuario);
            SqlDataReader sqlDataReader = VerificarTipoUsuario(usuario);
            sqlDataReader.Read();

            if (dataTable.Rows.Count == 1)
            {
                this.Visible = false;
                LimparCampos();
                Int32 supervisor = sqlDataReader.GetInt32(3);

                if (supervisor == 1)
                {
                    usuario.Tipo = "Supervisor";
                }

                else
                {
                    usuario.Tipo = "Operador";
                }

                FmrMenu fmrMenu = new FmrMenu(usuario.Login, usuario.Tipo);
                fmrMenu.Show();
            }

            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos");
                LimparCampos();
            }
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja mesmo sair da aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
