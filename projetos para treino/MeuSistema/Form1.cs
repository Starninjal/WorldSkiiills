using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema
{
    public partial class frmProduto : Form
    {

        int valor1;

        int valor2;

        


        public frmProduto()
        {
         
            InitializeComponent();
        }

        private void txtRes_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtParcela1.Text);
            valor2 = Convert.ToInt32(txtParcela2.Text);
            txtRes.Text = Convert.ToString(valor1 + valor2);
        }
    }
}
