﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioSenai
{
    public  class Conversao
    {

        private int id;

        private String moeda;

        private double valorConvertido;

        private double baseConversao;
        public Conversao(String moeda, double baseConversao) {
            this.Moeda = moeda;
            this.BaseConversao = baseConversao;
        }  

        public Conversao(double valorConvertido)
        {
            this.ValorConvertido = valorConvertido;
        }

        public Conversao()
        {

        }

        public Conversao(String moeda, double baseConversao, double valorConvertido)
        {
            this.Moeda = moeda;
            this.BaseConversao = baseConversao;
            this.ValorConvertido = valorConvertido;
        }


        

        public Double ValorConvertido { get; set; }

        public Double BaseConversao { get; set;}

        public String Moeda { get; set; }

        public String toString()
        {
            return Moeda;
        }



        
    }
}
