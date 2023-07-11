using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Conducao con = new Lancha();

            con.cor = "Rosa";

            con.modelo = "Rockfeller";

            Conducao con2 = new Moto();

            con2.cor = "azul";

            con2.modelo = "Kawasaki";

                con.mostrar(con2);
        }

        
    }
}
