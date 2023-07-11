using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado01__Sem_Consulta_
{
    public partial class Principal : Form
    {

        private Conversao conversao;
        public Principal()
        {
            InitializeComponent();
            inicializar();
        }

        public void inicializar()
        {
            List<Conversao> conversoes = new List<Conversao>();

            ListMoeda list;

            conversoes = ListMoeda.List();

    

            foreach (var conversao in conversoes.Where(x => x.nomeMoeda == "Dólar"))
            {
                conversao.nomeMoeda = "Euro";
            }

            for (int i = 0; i < conversoes.Count; i++)
            {
                MessageBox.Show(conversoes[i].toString());
            }

         
            ListMoeda.update(conversoes);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConverter frmConverter = new frmConverter();
            frmConverter.Show();
        }
    }
}
