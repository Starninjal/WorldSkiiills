using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.UtcNow.ToString("hh:mm:ss"); //atualizando
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

            int d = 0;
            int m = 0;
            int a = 0;

            DateTime date = new DateTime();

            lblData.Text = date.ToString(); 
         }

        private void lblAtual_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.Now
                .ToString("hh:mm:ss");
        }
    }
}
