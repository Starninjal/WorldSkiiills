using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrincipal
{
    public partial class Form1 : Form
    {
        double nota1, nota2, nota3, nota4, media;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int valor;

     

       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*
                        valor = int.Parse(txtNota1.Text);

                        if(valor == 10)
                        {
                            lblResultado.Text = "é 10";
                            lblResultado.ForeColor = Color.Red;

                        } else if(valor > 20)
                        {
                            valor += 1;
                            lblResultado.Text = Convert.ToString(valor);

                            lblResultado.ForeColor = Color.Blue; 
                        } else
                        {
                            lblResultado.Text = "Escreve um número porra!";
                            lblResultado.ForeColor = Color.Green;
                        }


            */

            /*
            for (int i= 0; i< 50; i++)
            {
                listBox1
                    .Items.Add(i.ToString());
            }
            int times = 0;
            while(times <= 100)
            {
                listBox1.Items.Add(times++);            

            }

            */

            List<string> listaNome = new List<string>()
            {
                "Léo", "José", "Alex", "Maria", "João", "marcia"
            };
            /*
            foreach(string item in listaNome)
            {
                listBox1.Items.Add(item);
            }
            */

            for (int i = 0; i < listaNome.Count; i++)
            {
                // listaNome.Add(listBox1.Items[i].ToString()); 
                listBox1.Items.Add(i);
            }

        }
    }
}
