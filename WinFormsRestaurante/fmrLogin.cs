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
                fmrMenu fmrMenu = new fmrMenu();
                fmrMenu.Show();
            }

            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos");
                txBoxUserLogin.Text = "";
                txBoxUserPassword.Text = "";
            }
        }
    }
}
