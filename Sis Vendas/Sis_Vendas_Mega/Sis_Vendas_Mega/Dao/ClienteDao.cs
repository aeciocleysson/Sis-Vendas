using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sis_Vendas_Mega.Model;
using MySql.Data.MySqlClient;
using System.Data;
using LibaryConnection;
using System.Windows.Forms;

namespace Sis_Vendas_Mega.Dao
{
    class ClienteDao : Conexao
    {
      public void Cadastrar(Cliente cliente)
        {
            try
            {
                AbrirConexao();
                                
                Cmd = new MySqlCommand("INSERT INTO cliente (id_cliente, nome, endereco, telefone, celular,tipo_pessoa) '"+
                    "+ VALUES (@id, @nome, @endereco, @tel, @cel, @tipo_pessoa)", Con);

                Cmd.Parameters.AddWithValue("@id", cliente.Id_Cliente);
                Cmd.Parameters.AddWithValue("@nome", cliente.Nome_Cliente);
                Cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                Cmd.Parameters.AddWithValue("@tel", cliente.Telefone);
                Cmd.Parameters.AddWithValue("@cel", cliente.Celular);
                Cmd.Parameters.AddWithValue("@tipo_pessoa", cliente.Tipo_Pessoa);
                
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

        // Método para listar clientes
        public DataTable ListarClientes()
        {
            try
            {
                AbrirConexao();


                Cmd = new MySqlCommand("select * from cliente join pessoa on cliente.tipo_pessoa = pessoa.id_pessoa", Con);
                Cmd = new MySqlCommand("SELECT c.id_cliente, c.nome, c.endereco, c.telefone, c.celular, p.tipo_pessoa FROM cliente c JOIN  pessoa p ON p.id_pessoa = c.tipo_pessoa ORDER BY nome", Con);

                DataTable Dt = new DataTable();

                MySqlDataAdapter Da = new MySqlDataAdapter();

                Da.SelectCommand = Cmd;

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

        public void EditarCliente(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("UPDATE cliente SET nome = @nome, endereco = @endereco, telefone = @telefone, celular = @celular WHERE id_cliente = @id", Con);

                Cmd.Parameters.AddWithValue("@id", cliente.Id_Cliente);
                Cmd.Parameters.AddWithValue("@nome", cliente.Nome_Cliente);
                Cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                Cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                Cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                
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

        // Método que pesquisa o cliente pelo nome digitado
        public DataTable PesquisaClientes(Cliente cliente)
        {
            AbrirConexao();

            try
            {
                DataTable dt = new DataTable();

                Cmd = new MySqlCommand("SELECT c.id_cliente, c.nome_cliente, " +
                    "+ c.endereco, c.telefone, " +
                    "+ c.celular, " +
                    "+ p.tipo_pessoa FROM cliente c JOIN pessoa p ON p.id_pessoa = c.tipo_pessoa WHERE nome_cliente LIKE @cliente ORDER BY nome_cliente", Con);

                Cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = "%" + cliente + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
                Da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
