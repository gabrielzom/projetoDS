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
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void toolStripCadCliente_Click(object sender, EventArgs e)
        {
            fmrCliente fmrCliente = new fmrCliente();
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
    }
}
