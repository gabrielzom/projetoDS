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

        public void FormularioAberto(Form formularioAtual)
        {
            Boolean aberto = false;
            foreach (Form formularioAberto in Application.OpenForms)
            {
                if (formularioAberto.Name == formularioAtual.Name)
                {
                    aberto = true;
                    break;
                }
            }

            if (!aberto)
            {
                formularioAtual.MdiParent = this;
                formularioAtual.Show();
            }
        }

        private void toolStripCadCliente_Click(object sender, EventArgs e)
        {
            FmrCliente fmrCliente = new FmrCliente();
            FormularioAberto(fmrCliente);
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
                FormularioAberto(fmrUsuario);
            }
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            DialogResult sair =  MessageBox.Show("Deseja mesmo Sair da Aplicação ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
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