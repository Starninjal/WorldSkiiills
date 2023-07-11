using System;
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
    public partial class frmConverter : Form
    {

        private List<String> moedas;

        private List<Double> baseConversao;
        public frmConverter(List<String> moedas, List<double> baseConversao)
        {

            InitializeComponent();
            
            
            
            

        }

        public frmConverter()
        {
            InitializeComponent();
        }

        public void Converter_Cambio_Load(object sender, EventArgs e)
        {
            

        }

        
    }
}
