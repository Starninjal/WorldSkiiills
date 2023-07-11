using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulado0333
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            String nome = "João";

            if (nome.Equals("Joao"))
            {
                MessageBox.Show(nome);
            }
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculos frm = new frmCadastroVeiculos();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAcesso frm = new FrmAcesso();
            frm.Show();
        }
    }
}
