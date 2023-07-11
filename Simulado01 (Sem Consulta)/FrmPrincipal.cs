using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado01__Sem_Consulta_
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void heheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void heheToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroMoeda frm = new frmRegistroMoeda();
            frm.Show();
        }

        private void conversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void converterCâmbioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConverter frm = new frmConverter();
            frm.Show();
        }
    }

}
    
