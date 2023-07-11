using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
          

            int[] valores;

            valores = new int[5];

            valores[0] = 10;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;
            for (int i = 0; i< valores.Length; i++)
            {
                listBox1.Items.Add(valores[i]);
            }
            
        }
    }
}
