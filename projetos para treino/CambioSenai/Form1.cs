using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioSenai
{
    public partial class Form1 : Form
    {
        private frmRegistro frm;

        
        public Form1()
        {
            InitializeComponent();
            this.frm =new frmRegistro();
            
        }

        private void conversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void converterValorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baseDeConversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Show();
        }

        private void converterValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConverter frm = new frmConverter(listarComboMoeda(), listarComboBase());

            frm.Show();
        }

        private List<String> listarComboMoeda()
        {
            return frm.getMoedas();
        }

        private List<Double> listarComboBase()
        {
            return frm.getBase();
        }
    }
}
