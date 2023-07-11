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

namespace buscarArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkay2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\papsta\Arquivo.txt");

            while(reader.EndOfStream == false)
            {
                listBox1.Items.Add(reader.ReadLine());  
            }
            {

            }
            reader.Dispose();
        }
    }
}
