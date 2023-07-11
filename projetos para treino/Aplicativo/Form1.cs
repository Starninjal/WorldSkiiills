using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo
{
    
    public partial class Form1 : Form
    {
        private List<Conversao> conversoes = new List<Conversao>();
        private Conversao conversao;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String moeda = txtMoeda.Text;

            Double baseConvert = Convert.ToDouble(txtBase.Text);

            conversao = new Conversao(baseConvert, moeda);

            conversoes.Add(conversao);
            MessageBox.Show("Adicionado com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String lista = "";
            for (int i = 0; i < conversoes.Count; i++)
            {
                lista += conversoes[i].toString();
                comboBox1.Items.Add(conversoes[i].toString());
            }
            MessageBox.Show(lista);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            for (int i = 0; i < conversoes.Count; i++)
            {
                if (conversoes[i].toString().Equals(comboBox1.Text))
                {
                    conversoes.Remove(conversoes[i]);
                }
            }
        }
    }
}
