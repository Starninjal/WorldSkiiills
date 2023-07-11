using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado01__Sem_Consulta_
{
    public partial class frmConverter : Form
    {

        private ListMoeda list;

        private List<Conversao> conversoes = new List<Conversao>();

        private int idTexto = 0;
        private StreamWriter writer;
        public frmConverter()
        {
            InitializeComponent();
            carregarCombo();
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valorConversao = Convert.ToDouble(txtValorConversao.Text);

            double valorBase = Convert.ToDouble(txtValorBase.Text);

            double valorConvertido = valorBase * valorConversao;

            txtValorConvertido.Text = valorConvertido.ToString("C");

            txtValorConversao.Text = valorConversao.ToString("C");

            listar();



           
        }
        
        public void carregarCombo()
        {
            cbMoeda.Items.Clear();
            conversoes = ListMoeda.List();
            for (int i = 0; i < conversoes.Count; i++)
            {
                cbMoeda.Items.Add(conversoes[i].toString());
            }
        }

        private void cbMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                if (cbMoeda.SelectedItem.Equals(conversoes[i].toString()))
                {
                    txtValorBase.Text = conversoes[i].valorMoeda.ToString();
                }
            }
        }

        public void listar()
        {
            for (int i = 0; i < conversoes.Count; i++)
            {

                if (cbMoeda.Text.Equals(conversoes[i].toString()))
                {
                    writer = new StreamWriter(@"C:\papsta\BackupConversoes.txt", true, Encoding.Default);


                    if (idTexto == 0)
                    {
                        writer.Write("Relatório de Conversões \n");
                        writer.Write("");
                        idTexto++;
                    }
                    String textoArquivo = "";
                    textoArquivo += "Moeda: " + conversoes[i].toString() + " | " + "Base de Conversao: " + conversoes[i].valorMoeda + " | Calculo | " + " Valor de conversão: " + txtValorConversao.Text + " = " + txtValorConvertido.Text;
                    writer.WriteLine(textoArquivo);
                    writer.Dispose();
                }
            }
        }

        private void cbMoeda_Click(object sender, EventArgs e)
        {
            carregarCombo();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistroMoeda frm = new frmRegistroMoeda();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtValorBase.Text = "";
            txtValorConversao.Text = "";
            txtValorConvertido.Text = "";
        }
    }
}
