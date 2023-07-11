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
    public partial class frmEncarar : Form
    {

        private ListMoeda list = new ListMoeda();

        private List<Conversao> conversoes = new List<Conversao>();
        public frmEncarar()
        {
            InitializeComponent();
            conversoes = ListMoeda.List();
            for (int i = 0; i < conversoes.Count; i++)
            {
                comboBox1.Items.Add(conversoes[i].toString());
            }
            
        }
    }
}
