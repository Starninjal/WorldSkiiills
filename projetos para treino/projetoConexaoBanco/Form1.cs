using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoConexaoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private produto model = new produto();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.cod_produto = Convert.ToInt32(textBox1.Text);
            model.nome = Convert.ToString(textBox2.Text);
            model.fk_tipo = 1;
            using (masterEntities db = new masterEntities())
            {
                db.produto.Add(model);
                db.SaveChanges();
            }
        }
    }
}
