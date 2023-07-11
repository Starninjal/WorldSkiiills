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
using System.Windows.Forms.VisualStyles;

namespace Simulado01__Sem_Consulta_
{
    public partial class frmRegistroMoeda : Form
    {
        private List<Conversao> conversoes = new List<Conversao>();

        int valor = 0;

        private int idTexto = 0;

        private Boolean update;
        private Conversao conversao;
        private StreamWriter writer;

        private ListMoeda list = new ListMoeda();
        public frmRegistroMoeda()
        {
            InitializeComponent();
        }

        private void Ultimo_Click(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = conversoes[conversoes.Count - 1].toString();
                textBox2.Text = conversoes[conversoes.Count - 1].valorMoeda.ToString();

                if (textBox1.Text.Equals(conversoes[conversoes.Count - 1].toString()))
                {
                    throw new Exception("Último valor já estabelecido!");
                    
                }
            } catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

            
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String nomeMoeda = textBox1.Text;
                Double valorMoeda = Double.Parse(textBox2.Text);
                MessageBox.Show(valorMoeda.ToString("F"));
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja salvar?", "Confirmar Inserir", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conversao = new Conversao(nomeMoeda, valorMoeda);
                    alterar();

                    /*
                    if(update == true)
                    {
                        MessageBox.Show("Os valores já existem, deseja alterar?");
                    } 

                    */



                    if (conversao.nomeMoeda.Length > 30)
                    {
                        throw new Exception("O nome da moeda não pode ultrapassar os 30 caracteres. Tente novamente!");
                    }

                    if (conversao.nomeMoeda.Length < 0)
                    {
                        throw new Exception("O nome da moeda não pode estar vazio.");
                    }

                    if (conversao.valorMoeda < 0)
                    {
                        throw new Exception("O valor da moeda não pode ser nulo!");
                    }

                    writer = new StreamWriter(@"C:\papsta\BackupDeInsercoesConversoes.txt", true, Encoding.Default);


                    if (idTexto == 0)
                    {
                        writer.Write("Relatório de Inserções de Conversões \n");
                        writer.Write("");
                        idTexto++;
                    }
                    String textoArquivo = "";
                    textoArquivo += "Nome Moeda: " + conversao.nomeMoeda + " | Base de Conversão: " + Convert.ToDouble(conversao.valorMoeda);
                    writer.WriteLine(textoArquivo);
                    writer.Dispose();

                    conversoes = ListMoeda.add(conversao);
                } else
                {
                    MessageBox.Show("Você cancelou a ação!");
                } 
            } catch(Exception e2)
            {
                MessageBox.Show("Ocorreu um erro. Motivo: " + e2.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmEncarar frm = new frmEncarar();
            frm.Show();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < conversoes.Count; i++)
            {
                var item = conversoes.First();

                MessageBox.Show(item.toString());

                if (item.toString().Equals(conversoes[i].nomeMoeda)) {
                    textBox1.Text = conversoes[i].nomeMoeda;
                    textBox2.Text = conversoes[i].valorMoeda.ToString("C");
                    break;
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < conversoes.Count; i++)
                {
                    var firstItem = conversoes.First();
                    if (textBox1.Text.Equals(firstItem.toString()))
                    {
                        throw new Exception("Último valor já estabelecido!");
                    }
                    else
                    {
                        if (textBox1.Text.Equals(conversoes[i].nomeMoeda))
                        {
                            textBox1.Text = conversoes[i - 1].toString();
                            textBox2.Text = conversoes[i - 1].valorMoeda.ToString("C");
                            break;
                        }
                    }

                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < conversoes.Count; i++)
                {
                    var lastItem = conversoes.Last();

                    if (lastItem.toString().Equals(conversoes[i].nomeMoeda))
                    {
                        throw new Exception("Último índice já estabelecido!");
                    }
                    else 
                    {
                        if((conversoes[i].nomeMoeda.Equals(textBox1.Text)))
                        {
                            

                            textBox1.Text = conversoes[i + 1].toString();
                            textBox2.Text = conversoes[i + 1].valorMoeda.ToString("C");
                            break;
                        }
                       
                    }
                }
            } catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
        }

        public void alterar()
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                if (textBox1.Text.Equals(conversoes[i].nomeMoeda))
                {
                    update = true;
                    
                    
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
