using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public class Conducao
    {
        public String cor { get; set; }

        public String modelo { get; set; }

        public void mostrar(Conducao conducao) {
            MessageBox.Show("Que lancha bonita que cor " + cor + " é essa meu filho! E que modelo bonito esse " + modelo);
        }   


    }
}
