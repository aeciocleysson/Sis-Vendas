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
    public class VendaDao : Conexao
    {
        // Método para finalizar a venda
        // esse método faz um select pelo codigo da venda e muda o status da venda para RECEBIDO apos a confirmação de recebimento
        public void FinalizarVenda(Pedido pedido)
        {

            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("UPDATE pedido SET valor_total_pedido = @valorTotal, situacao = 2 WHERE id_pedido = @idPedido", Con);

                Cmd.Parameters.AddWithValue("idPedido", pedido.Id_Pedido);
                Cmd.Parameters.AddWithValue("@valorTotal", pedido.Total_Venda);

                Cmd.ExecuteNonQuery();

                //MessageBox.Show("Venda realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        // esse método faz o select na tabela Pedido, e pega o id da última venda e mostra na tela qual sera o id da proxima venda  

        public void GerarCodigo(Pedido codigo)
        {

            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("SELECT max(id_pedido) FROM pedido", Con);

                if (Cmd.ExecuteScalar() == DBNull.Value)
                {
                    codigo.Id_Pedido = 1;
                }
                else
                {
                    Int32 ra = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
                    codigo.Id_Pedido = ra;
                }


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

    }

}