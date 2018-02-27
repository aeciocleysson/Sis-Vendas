using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibaryConnection
{
    public class Utilitario
    {
        protected MySqlCommand comando;
        public static DataSet Executar(string cmd)
        {
                

                MySqlConnection conexao = new MySqlConnection("SERVER=localhost; PORT=3306; DATABASE=vendas_mega; UID=root; PWD=3103");
                conexao.Open();

                DataSet Ds = new DataSet();

                MySqlDataAdapter Da = new MySqlDataAdapter(cmd, conexao);

                Da.Fill(Ds);
                conexao.Close();

                return Ds;
        }
        
    }
}
