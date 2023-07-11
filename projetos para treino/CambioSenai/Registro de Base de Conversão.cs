using System;
using System.Collections;
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
    public partial class frmRegistro : Form
    {
        private Conversao conversao;


        private List<String> moedas;

        private List<double> baseConversao;

        private ArrayList values = new ArrayList();

        private List<Conversao> conversoes = new List<Conversao>();







        public frmRegistro()
        {
            InitializeComponent();
            
            this.moedas = new List<String>();
            this.baseConversao = new List<double>();
        }

        private void Registro_de_Base_de_Conversão_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String moeda = txtMoeda.Text;

                

                double baseConvert = Convert.ToDouble(txtBaseConversao.Text);
                moedas.Add(moeda);
                baseConversao.Add(baseConvert);
                
                
                    conversao = new Conversao(moeda, baseConvert);
                
                conversoes.Add(conversao);

                

                for (int i = 0; i < conversoes.Count; i++)
                {
                    String legal = conversoes[i].Moeda;
                    MessageBox.Show(legal);
                }

                values.Add(baseConvert);
                values.Add(moeda.ToString());
               
                MessageBox.Show("Inserido com sucesso!");
                
            } catch {
                throw new Exception("Impossível registrar moeda!");
                }
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtMoeda.Text = "";
            txtBaseConversao.Text = null;
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            txtMoeda.Text = moedas[0].ToString();

            txtBaseConversao.Text = baseConversao[0].ToString();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            txtMoeda.Text = moedas[moedas.Count - 1].ToString();

            txtBaseConversao.Text = baseConversao[baseConversao.Count - 1].ToString();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < moedas.Count; i++)
            {
                if (moedas[i].Equals(txtMoeda.Text ) && baseConversao[i] == Convert.ToDouble(txtBaseConversao.Text)) {
                    
                    if (moedas[i].Equals(txtMoeda.Text))
                    {
                        txtMoeda.Text = moedas[i + 1].ToString();
                        txtBaseConversao.Text = baseConversao[i + 1].ToString();
                        i++;
                        
                    }
                    
                   
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnUltimo_Click(sender, e);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < moedas.Count; i++)
            {
                if (moedas[i].Equals(txtMoeda.Text))
                {

                    if (moedas[i].Equals(txtMoeda.Text))
                    {
                        txtMoeda.Text = moedas[i - 1].ToString();
                        txtBaseConversao.Text = baseConversao[i - 1].ToString();
                        i--;

                    }


                }
            }
        }

        public List<String> getMoedas()
        {
            
            return moedas;
        }

        public List<Double> getBase()
        {
            return baseConversao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < conversoes.Count;i++)
            {
                MessageBox.Show(conversoes[i].Moeda);
            } 
        }
    }
}
