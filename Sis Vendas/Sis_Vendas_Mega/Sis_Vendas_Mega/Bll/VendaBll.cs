using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sis_Vendas_Mega.Dao;
using Sis_Vendas_Mega.Model;

namespace Sis_Vendas_Mega.Bll
{
    public class VendaBll
    {
        public void FinalizarVendas(Pedido pedido)
        {
            try
            {
                
                VendaDao dao = new VendaDao();

                dao.FinalizarVenda(pedido);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
    }
}
