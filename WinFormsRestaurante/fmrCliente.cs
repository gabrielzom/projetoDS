using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRestaurante.Properties;


namespace WinFormsRestaurante
{
    public partial class fmrCliente : Form
    {
        public fmrCliente()
        {
            InitializeComponent();
        }
        public Int32 LinhaAtual(Int32 linhaAtual)
        {
            linhaAtual = dataGridViewCliente.CurrentRow.Index;
            return linhaAtual;
        }

        public void Alterar(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspClientesAlterar";
            sqlCommand.Parameters.AddWithValue("@ClienteNome", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("@ClienteNascimento", cliente.Nascimento);
            sqlCommand.Parameters.AddWithValue("@ClienteId", cliente.Id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable Pesquisar(String pesquisa)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspClientesPesquisar";
            sqlCommand.Parameters.AddWithValue("@pesquisa", pesquisa);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return dataTable;
        }

        public DataTable Carregar()
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspClientesCarregar";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return dataTable;
        }
        public void Incluir(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspClientesIncluir";
            sqlCommand.Parameters.AddWithValue("clienteNome", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("clienteNascimento", cliente.Nascimento);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Excluir(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlConnection.ConnectionString = Settings.Default.connectionString;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspClientesExcluir";
            sqlCommand.Parameters.AddWithValue("clienteId", cliente.Id);
           
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void txBoxPesquisarCliente_Click(object sender, EventArgs e)
        {
            txBoxPesquisarCliente.Text = "";
            txBoxPesquisarCliente.ForeColor = Color.Black;
            txBoxPesquisarCliente.Font = new Font("Segoe UI; 9,75pt; style=Bold", txBoxPesquisarCliente.Font.Size);
        }

        private void fmrCliente_Click(object sender, EventArgs e)
        {

            txBoxPesquisarCliente.Text = "Buscar...";
            txBoxPesquisarCliente.ForeColor = Color.Silver;
            txBoxPesquisarCliente.Font = new Font("Segoe UI; 9,75pt; style=Bold", txBoxPesquisarCliente.Font.Size);
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (btnAlterarCliente.Text == "Alterar")
            {
                btnAlterarCliente.Text = "Salvar";
                txBoxNomeCliente.Enabled = true;
                maskTxBoxNascimentoCliente.Enabled = true;
                btnIncluirCliente.Enabled = false;
                btnExcluirCliente.Enabled = false;
            }

            else
            {
                DialogResult alterar = MessageBox.Show("Deseja mesmo atualizar o Registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (alterar == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = txBoxNomeCliente.Text;
                    cliente.Nascimento = Convert.ToDateTime(maskTxBoxNascimentoCliente.Text);
                    cliente.Id = (Int32)dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[0].Value;

                    this.Alterar(cliente);

                    MessageBox.Show("Cadastro atualizado com sucesso !");

                    btnAlterarCliente.Text = "Alterar";

                    txBoxNomeCliente.Enabled = false;
                    maskTxBoxNascimentoCliente.Enabled = false;

                    btnIncluirCliente.Enabled = true;
                    btnExcluirCliente.Enabled = true;

                    txBoxPesquisarCliente.Text = " ";
                    txBoxPesquisarCliente.Text = "";
                    txBoxPesquisarCliente.Focus();
                }

                else
                {
                    txBoxNomeCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[1].Value.ToString();
                    maskTxBoxNascimentoCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[2].Value.ToString();
                    btnAlterarCliente.Text = "Alterar";
                    txBoxNomeCliente.Enabled = false;
                    maskTxBoxNascimentoCliente.Enabled = false;
                    btnIncluirCliente.Enabled = true;
                    btnExcluirCliente.Enabled = true;
                }
            }
        }

        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrWhiteSpace(txBoxNomeCliente.Text) || (maskTxBoxNascimentoCliente.Text == "  /  /")))
            {
                MessageBox.Show("Não é possível deixar o campo NOME ou NASCIMENTO em branco.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (btnIncluirCliente.Text == "Incluir")
            {
                btnIncluirCliente.Text = "Salvar";
                txBoxNomeCliente.Enabled = true;
                maskTxBoxNascimentoCliente.Enabled = true;
                txBoxNomeCliente.Text = "";
                maskTxBoxNascimentoCliente.Text = "";
                txBoxNomeCliente.Focus();

                btnAlterarCliente.Enabled = false;
                btnExcluirCliente.Enabled = false;
            }

            else if (btnIncluirCliente.Text == "Salvar")
            {
                DialogResult incluir = MessageBox.Show("Deseja mesmo incluir o Registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (incluir == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = txBoxNomeCliente.Text;
                    cliente.Nascimento = Convert.ToDateTime(maskTxBoxNascimentoCliente.Text);

                    this.Incluir(cliente);

                    MessageBox.Show("Cliente cadastrado com sucesso !");
                    txBoxNomeCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[1].Value.ToString();
                    maskTxBoxNascimentoCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[2].Value.ToString();

                    btnIncluirCliente.Text = "Incluir";
                    txBoxNomeCliente.Enabled = false;
                    maskTxBoxNascimentoCliente.Enabled = false;
                    txBoxPesquisarCliente.Text = "";
                    txBoxPesquisarCliente.Focus();

                    btnAlterarCliente.Enabled = true;
                    btnExcluirCliente.Enabled = true;
                }

                else
                {
                    txBoxNomeCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[1].Value.ToString();
                    maskTxBoxNascimentoCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[2].Value.ToString();
                    btnIncluirCliente.Text = "Incluir";
                    txBoxNomeCliente.Enabled = false;
                    maskTxBoxNascimentoCliente.Enabled = false;

                    btnAlterarCliente.Enabled = true;
                    btnExcluirCliente.Enabled = true;
                   
                }
            }
        }

        private void fmrCliente_Load(object sender, EventArgs e)
        {
            DataTable dataTable = this.Carregar();
            dataGridViewCliente.DataSource = dataTable;
            txBoxNomeCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[1].Value.ToString();
            maskTxBoxNascimentoCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[2].Value.ToString();
        }

        private void txBoxPesquisarCliente_TextChanged(object sender, EventArgs e)

        {
            DataTable dataTable = this.Pesquisar(txBoxPesquisarCliente.Text);
            dataGridViewCliente.DataSource = dataTable;
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txBoxNomeCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[1].Value.ToString();
            maskTxBoxNascimentoCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[2].Value.ToString();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Deseja realmente excluir o Registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (excluir == DialogResult.Yes)
            {
                Cliente cliente = new Cliente();
                cliente.Id = (Int32) dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[0].Value;
                this.Excluir(cliente);
                MessageBox.Show("Cadastro excluído com sucesso !");
                txBoxPesquisarCliente.Text = " ";
                txBoxPesquisarCliente.Text = "";
                txBoxPesquisarCliente.Focus();

            }
        }

        private void maskTxBoxNascimentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsInputChar(e.KeyChar))
            {
                maskTxBoxNascimentoCliente.Text = "";
            }
        }
    }
}