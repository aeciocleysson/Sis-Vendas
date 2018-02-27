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
    class EstoqueBll
    {
        // Método para cadastrar Produto
        public void Cadastrar(Estoque produto)
        {
            try
            {
                EstoqueDao estoqueDao = new EstoqueDao();
                estoqueDao.Cadastrar(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para listar o estoque
        public DataTable ListarProdutos()
        {
            try
            {
                EstoqueDao estoqueDao = new EstoqueDao();
                DataTable Dt = new DataTable();

                Dt = estoqueDao.ListarProdutos();

                return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para editar o produto
        public void EditarProduto(Estoque produto)
        {
            try
            {
                EstoqueDao estoqueDao = new EstoqueDao();

                estoqueDao.EditarProduto(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para excluir produto
        public void ExcluirProduto(Estoque produto)
        {
            try
            {
                EstoqueDao estoqueDao = new EstoqueDao();
                estoqueDao.ExcluirProduto(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
