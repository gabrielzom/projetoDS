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
    public partial class FmrMenu : Form
    {
        
        public FmrMenu(String usuarioAtual, String tipoAtual)
        {
            InitializeComponent();
            lblUsuarioAtual.Text = usuarioAtual;
            lblTipoAtual.Text = tipoAtual;
        }

        private void toolStripCadCliente_Click(object sender, EventArgs e)
        {
            FmrCliente fmrCliente = new FmrCliente();
            fmrCliente.MdiParent = this;
            fmrCliente.Show();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            DialogResult sair =  MessageBox.Show("Deseja mesmo Sair da Aplicação ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripCadUsuario_Click(object sender, EventArgs e)
        {
            if (lblTipoAtual.Text == "Operador")
            {
                MessageBox.Show("Apenas SUPERVISORES podem realizar cadastro de usuários.");
            }
            
            else
            {
                FmrUsuario fmrUsuario = new FmrUsuario();
                fmrUsuario.MdiParent = this;
                fmrUsuario.Show();
            }
        }

        private void toolStripLogoff_Click(object sender, EventArgs e)
        {
            FmrLogin fmrLogin = new FmrLogin();
            
            DialogResult sair = MessageBox.Show("Deseja mesmo fazer Logoff ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
                fmrLogin.Visible = true;
            }
        }
    }
}