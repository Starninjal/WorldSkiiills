using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace manipulação_de_arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo = new StreamWriter(@"C:\papsta\Arquivo.txt", false, Encoding.UTF8);

            ArrayList pessoas = new ArrayList();

            pessoas.Add("João");
            pessoas.Add("Paulo");
            pessoas.Add("Rodrigues");
            pessoas.Add("Saulo");
            pessoas.Add("Roberto");
            String items = "";
            for (int i = 0; i < pessoas.Count; i++)
            {
                items = pessoas[i] + "\n";
                listBox1.Items.Add(items);
                MessageBox.Show(items);
            }    

            arquivo.WriteLine("Minha primeira linha de texto");

            arquivo.WriteLine(items);

            arquivo.Dispose();
        }
    }
}
