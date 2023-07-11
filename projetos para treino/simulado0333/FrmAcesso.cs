using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulado0333
{
    public partial class FrmAcesso : Form
    {

        veiculos model = new veiculos();

        private List<veiculos> veiculosList = new List<veiculos>();

        private List<String> valores = new List<String>();

        private String valor;
        public FrmAcesso()
        {
            InitializeComponent();
            setarValores();
            setarGrid();
            validardado();

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

       

        public void setarGrid()
        {
            using (masterEntities db = new masterEntities())
            {
                veiculosList = db.veiculos.ToList<veiculos>();
                dataGridView1.DataSource = veiculosList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (masterEntities db = new masterEntities())
            {
                for (int i = 0; i < veiculosList.Count; i++)
                {
                    Boolean isEquals = textBox1.Equals(veiculosList[i]);
                    valor += "Variável: " + veiculosList[i].placa + " |  " + textBox1.Text + "\n" + " | " + isEquals + "\n";


                    char[] merda = textBox1.Text.ToCharArray();
                    MessageBox.Show(merda.ToString());
                    MessageBox.Show(textBox1.GetType().ToString() + " | " + veiculosList[i].placa.GetType().ToString());
                       

                    if (textBox1.Equals("João"))
                    {
                        textBox2.Text = veiculosList[i].veiculo;

                        textBox3.Text = veiculosList[i].condutor;
                    }

                    
                }

                MessageBox.Show(valor);
            }

            
        }

        public void setarValores()
        {
            using (masterEntities db = new masterEntities())
            {
                veiculosList = db.veiculos.ToList<veiculos>();

            }
        }

        public void validardado()
        {
            int numero = 15;

            if(numero == 15)
            {
                MessageBox.Show("hehe!");

            }


        }
    } }
