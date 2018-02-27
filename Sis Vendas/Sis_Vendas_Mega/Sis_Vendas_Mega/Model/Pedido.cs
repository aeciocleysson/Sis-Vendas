using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Vendas_Mega.Model
{
    public class Pedido
    {
        public int Id_Pedido { get; set; }
        public DateTime Data_Pedido { get; set; }
        public int MyProperty { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Vendedor { get; set; }
        public int Situacao_Pedido { get; set; }
        public int Forma_Pag { get; set; }
        public Decimal Total_Venda { get; set; }
    }
}
