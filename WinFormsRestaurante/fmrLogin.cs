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
    public partial class fmrLogin : Form
    {  
        public fmrLogin()
        {
            InitializeComponent();
        }

        public DataTable Login(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

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

        private void btnConfirmLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = txBoxUserLogin.Text;
            usuario.Senha = txBoxUserPassword.Text;

            DataTable dataTable = this.Login(usuario);
            dataGridViewLogin.DataSource = dataTable;

            if (dataGridViewLogin.Rows.Count == 2)
            { 
                Int32 supervisor = (Int32) dataGridViewLogin.Rows[0].Cells[3].Value;
                
                this.Visible = false;
                txBoxUserLogin.Text = "";
                txBoxUserPassword.Text = "";
                txBoxUserLogin.Focus();

                if (supervisor == 1)
                {
                    usuario.Tipo = "Supervisor";
                }

                else
                {
                    usuario.Tipo = "Operador";
                }

                fmrMenu fmrMenu = new fmrMenu(usuario.Login, usuario.Tipo);
                fmrMenu.Show();
            }

            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos");
                txBoxUserLogin.Text = "";
                txBoxUserPassword.Text = "";
                txBoxUserLogin.Focus();
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
