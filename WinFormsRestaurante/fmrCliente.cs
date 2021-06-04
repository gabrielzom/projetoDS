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
    public partial class FmrCliente : Form
    {
        public FmrCliente()
        {
            InitializeComponent();
        }

        //##################### INÍCIO DOS MÉTODOS CONDICIONAIS ########################//
        public Int32 LinhaAtual(Int32 linhaAtual)
        {
            linhaAtual = dataGridViewCliente.CurrentRow.Index;
            return linhaAtual;
        }

        public void BtnAlterarOriginal()
        {
            btnAlterarCliente.Text = "Alterar";
            txBoxNomeCliente.Enabled = false;
            maskTxBoxNascimentoCliente.Enabled = false;
            btnIncluirCliente.Enabled = true;
            btnExcluirCliente.Enabled = true;
        }

        public void BtnIncluirOriginal()
        {
            btnIncluirCliente.Text = "Incluir";
            txBoxNomeCliente.Enabled = false;
            maskTxBoxNascimentoCliente.Enabled = false;
            txBoxPesquisarCliente.Focus();
            btnAlterarCliente.Enabled = true;
            btnExcluirCliente.Enabled = true;
        }

        public void BtnAlterarSalvar()
        {
            btnAlterarCliente.Text = "Salvar";
            txBoxNomeCliente.Enabled = true;
            maskTxBoxNascimentoCliente.Enabled = true;
            btnIncluirCliente.Enabled = false;
            btnExcluirCliente.Enabled = false;
        }

        public void BtnIncluirSalvar()
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

        public void AtualizarClientes()
        {
            txBoxPesquisarCliente.Text = " ";
            txBoxPesquisarCliente.Text = "";
            txBoxPesquisarCliente.Focus();
        }

        public void DadosNosCampos()
        {
            txBoxNomeCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[1].Value.ToString();
            maskTxBoxNascimentoCliente.Text = dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[2].Value.ToString();
        }
        //##################### FIM DOS MÉTODOS CONDICIONAIS ########################//




        //##################### INÍCIO DOS MÉTODOS SQL SERVER ########################//
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
        //##################### FIM DOS MÉTODOS SQL SERVER ########################//





        //##################### INÍCIO DAS ESTRUTURAS CONDICIONAIS ########################//
        private void fmrCliente_Load(object sender, EventArgs e)
        {
            DataTable dataTable = Carregar();
            dataGridViewCliente.DataSource = dataTable;
            DadosNosCampos();
        }

        private void txBoxPesquisarCliente_TextChanged(object sender, EventArgs e)

        {
            DataTable dataTable = this.Pesquisar(txBoxPesquisarCliente.Text);
            dataGridViewCliente.DataSource = dataTable;
        }

        private void txBoxPesquisarCliente_Click(object sender, EventArgs e)
        {
            if (txBoxPesquisarCliente.Text == "Buscar...")
            {
                txBoxPesquisarCliente.Text = "";
                txBoxPesquisarCliente.ForeColor = Color.Black;
                txBoxPesquisarCliente.Font = new Font("Segoe UI; 9,75pt; style=Bold", txBoxPesquisarCliente.Font.Size);
                
            }
        }
        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DadosNosCampos();
        }

        private void maskTxBoxNascimentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsInputChar(e.KeyChar))
            {
                maskTxBoxNascimentoCliente.Text = "";
            }
        }

        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if ((String.IsNullOrWhiteSpace(txBoxNomeCliente.Text) || (maskTxBoxNascimentoCliente.Text == "  /  /")))
                {
                    MessageBox.Show("Não é possível deixar o campo NOME ou NASCIMENTO em branco.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (btnIncluirCliente.Text == "Incluir")
                {
                    BtnIncluirSalvar();
                }

                else if (btnIncluirCliente.Text == "Salvar")
                {
                    DialogResult incluir = MessageBox.Show("Deseja mesmo incluir o Registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (incluir == DialogResult.Yes)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Nome = txBoxNomeCliente.Text;
                        cliente.Nascimento = Convert.ToDateTime(maskTxBoxNascimentoCliente.Text);
                        Incluir(cliente);

                        MessageBox.Show("Cliente cadastrado com sucesso !");
                        DadosNosCampos();
                        BtnIncluirOriginal();
                        AtualizarClientes();
                    }

                    else
                    {
                        DadosNosCampos();
                        BtnIncluirOriginal();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar as instruções. Detalhes: " + ex.Message);
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterarCliente.Text == "Alterar")
                {
                    BtnAlterarSalvar();
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
                        Alterar(cliente);

                        MessageBox.Show("Cadastro atualizado com sucesso !");
                        BtnAlterarOriginal();
                        AtualizarClientes();
                    }

                    else
                    {
                        DadosNosCampos();
                        BtnAlterarOriginal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar as instruções. Detalhes: " + ex.Message);
            }
        }


        private void btnExcluirCliente_Click(object sender, EventArgs e)
        { 
            try
            {
                DialogResult excluir = MessageBox.Show("Deseja realmente excluir o Registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (excluir == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (Int32)dataGridViewCliente.Rows[LinhaAtual(dataGridViewCliente.CurrentRow.Index)].Cells[0].Value;
                    Excluir(cliente);

                    MessageBox.Show("Cadastro excluído com sucesso !");
                    AtualizarClientes();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar as instruções. Detalhes: " + ex.Message);
            }
        }  //##################### FIM DAS ESTRUTURAS CONDICIONAIS ########################//
    } 
}
        
