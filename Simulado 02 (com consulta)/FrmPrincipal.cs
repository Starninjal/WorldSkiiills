using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado_02__com_consulta_
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeTipoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagemProduto frm = new FrmListagemProduto();
            frm.Show();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagemTipoProduto frm = new FrmListagemTipoProduto();
            frm.Show();
        }
    }
}
