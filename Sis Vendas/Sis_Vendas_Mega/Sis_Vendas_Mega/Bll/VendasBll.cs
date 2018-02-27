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
    class VendasBll
    {
        public void SalvarPedido(Venda venda)
        {
            try
            {
                VendaDao vendaDao = new VendaDao();
                vendaDao.SalvarVenda(venda);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
