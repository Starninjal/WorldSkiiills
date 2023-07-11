using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemProduto frmListagemProduto = new frmListagemProduto();
            frmListagemProduto.ShowDialog();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemTipo frmListagem = new frmListagemTipo();
            frmListagem.ShowDialog();
        }
    }
}
