using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03__Com_consulta_
{
    public class retornarDados
    {
        private static SqlConnection conn;

        private static int qtdCarro;

        private static int qtdMoto;
        public static void setCarro()
        {
            qtdCarro++;
        }

        public static int getQtdCarro()
        {
            return qtdCarro;
        }

        public static void setMoto()
        {
            qtdMoto++;
        }
        public static int getQtdMoto()
        {
            return qtdMoto;
        }
    

        public static List<Veiculo> Veiculos = new List<Veiculo>();
        public static void addVeiculo(List<Veiculo> veiculos)
        {
            Veiculos = veiculos;
        }

        public static List<Veiculo> getVeiculos()
        {
            conexao();
            listarDados();
            return Veiculos;
        }

        public static List<Veiculo> listarDados()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT placa, veiculo, condutor, tipo from veiculos", conn);
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    Veiculos.Add(extrairDo(reader));
                }
            }
            conn.Close();
            return Veiculos;



        }

        public static Veiculo extrairDo(SqlDataReader reader)
        {
            String placa = reader.GetString(0);
            String veiculo = reader.GetString(1);
            String condutor = reader.GetString(2);
            String tipo = reader.GetString(3);
            return new Veiculo(placa, veiculo, condutor, tipo);
        }

        public static void conexao()
        {
          conn = new SqlConnection(@"Data Source=KERNELOS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }
    }
}
