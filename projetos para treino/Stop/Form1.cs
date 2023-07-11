using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if(chckboxUsuario.Checked)
            {
                lblSetUsuario.Text = textBox1.Text;
            } else {
                lblSetUsuario.Text = null;
            }
        }
    }
}
