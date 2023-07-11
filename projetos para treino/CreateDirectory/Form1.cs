using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
       

                StreamWriter arquivo = new StreamWriter(@"C:\Config\ArquivoConfig.txt", false, Encoding.UTF8);

            StreamWriter writer = new StreamWriter(@"C:\papsta\Arquivos.txt", false, Encoding.UTF8);

            writer.WriteLine("hehe");

            writer.Dispose();


                arquivo.WriteLine("minha primeira linha");

            arquivo.Dispose();  



                MessageBox.Show(textBox1.Text);
            }
            
        }
    }

