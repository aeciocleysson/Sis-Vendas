using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sis_Vendas_Mega.Model;
using MySql.Data.MySqlClient;
using System.Data;
using LibaryConnection;

namespace Sis_Vendas_Mega.Dao
{
     class EstoqueDao : Conexao
    {

        // Método para cadastrar produtos
        public void Cadastrar(Estoque produto)
        {
            try
            {
                AbrirConexao();

              
                Cmd = new MySqlCommand("INSERT INTO estoque (id_produto, descricao_produto, quantidade, valor_produto, data_cad, quant_mini, quant_maxi) VALUES (@id, @descricao, @quantidade, @valor, @data_cad, @minimo, @maximo)", Con);

                Cmd.Parameters.AddWithValue("@id", produto.Id_Produto);
                Cmd.Parameters.AddWithValue("@descricao", produto.Descricao_Produto);
                Cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                Cmd.Parameters.AddWithValue("@valor", produto.Valor_Produto);
                Cmd.Parameters.AddWithValue("@data_cad", produto.Data_Cad);
                Cmd.Parameters.AddWithValue("@minimo", produto.Quant_Mini);
                Cmd.Parameters.AddWithValue("@maximo", produto.Quant_Maxi);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método para listar os produtos no grid
        public DataTable ListarProdutos()
        {
            try
            {
                AbrirConexao();

               Cmd = new MySqlCommand("SELECT * FROM estoque ORDER BY descricao", Con);

                DataTable Dt = new DataTable();

                MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
 
                Da.Fill(Dt);

               return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
            
        }

        // Me´todo para atualizar os dados do produto
        public void EditarProduto(Estoque produto)
        {
            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("UPDATE estoque SET descricao = @descricao, quantidade = @quantidade, valor_unitario = @valor, data_cad = @data, quant_min = @minimo, quant_max = @maxima WHERE id_produto = @id", Con);

                Cmd.Parameters.AddWithValue("@id", produto.Id_Produto);
                Cmd.Parameters.AddWithValue("@descricao", produto.Descricao_Produto);
                Cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                Cmd.Parameters.AddWithValue("@valor", produto.Valor_Produto);
                Cmd.Parameters.AddWithValue("@data", produto.Data_Cad);
                Cmd.Parameters.AddWithValue("@minimo", produto.Quant_Mini);
                Cmd.Parameters.AddWithValue("@maxima", produto.Quant_Maxi);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método para excluir produto em estoque
        public void ExcluirProduto(Estoque produto)
        {
            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("DELETE FROM estoque WHERE id_produto = @id", Con);

                Cmd.Parameters.AddWithValue("@id", produto.Id_Produto);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void PesquisarEstoque(string produto)
        {
            try
            {
                AbrirConexao();
                                
                Cmd = new MySqlCommand("SELECT * FROM estoque WHERE descricao LIKE '%" + produto + "%' ORDER BY descricao", Con);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                DataTable Dt = new DataTable();

                Da.Fill(Dt);

               
             
                    
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
    }
}
