using System;
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
    public partial class mostrarNome : Form
    {

        private List<Pessoa> pessoas;
        public mostrarNome(List<Pessoa> pessoas)
        {
            InitializeComponent();
            this.pessoas = pessoas;

            for (int i = 0; i < pessoas.Count; i++)
            {
                comboBox1.Items.Add(pessoas[i].toString());
            }
           
        }
    }
}
