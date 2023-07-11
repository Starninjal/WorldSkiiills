using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cliente
    {
        private int Id { get; set; }
        
        public String Nome { get; set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
