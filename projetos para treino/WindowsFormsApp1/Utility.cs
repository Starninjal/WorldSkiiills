using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Utility
    {
        public void setarMascara(MaskedTextBox mask)
        {
            mask.Mask = "000.000.000-00";
        }

        public void setarToString(Object obj)
        {
            String nome = obj.GetType().ToString();
            MessageBox.Show(nome);
        }
    }
}
