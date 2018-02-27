using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sis_Vendas_Mega.Model;
using Sis_Vendas_Mega.Dao;
using System.Data;

namespace Sis_Vendas_Mega.Bll
{
    class ClienteBll
    {
        ClienteDao clienteDao = null;

        // Método para cadastrar clientes
        public void Cadastrar(Cliente cliente)
        {
            try
            {
                clienteDao = new ClienteDao();
                clienteDao.Cadastrar(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para listar clientes
        public DataTable ListarClientes()
        {
            try
            {
                clienteDao = new ClienteDao();

                DataTable Dt = new DataTable();

                Dt = clienteDao.ListarClientes();

                return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para editar cliente
        public void EditarCliente(Cliente cliente)
        {
            try
            {
                clienteDao = new ClienteDao();
                clienteDao.EditarCliente(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para pesquisar os cliente na medida que for digitando o nome  
        public DataTable PesquisarClientes(Cliente cliente)
        {
            try
            {
                ClienteDao dao = new ClienteDao();
                DataTable dt = new DataTable();

                dt = dao.PesquisaClientes(cliente);
                return dt;
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
    }
}
