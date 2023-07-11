using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado03
{
    public partial class frmCadastroVeiculo : Form
    {
        private Veiculo veiculo;

        private Util util;
        public frmCadastroVeiculo()
        {
            util = new Util();
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
     

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
