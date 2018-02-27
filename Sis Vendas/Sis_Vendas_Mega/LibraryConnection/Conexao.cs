using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibaryConnection
{
    public class Conexao
    {
        public MySqlConnection Con;
        public MySqlCommand Cmd;
        public MySqlDataReader Dr;

        // Método para abrir a conexão
        public void AbrirConexao()
        {
            try
            {
                Con = new MySqlConnection("SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103");
                Con.Open();
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }

        // Método para fechar a conexão
        public void FecharConexao()
        {
            try
            {
                Con = new MySqlConnection("SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103");
                Con.Close();
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
    }
}

