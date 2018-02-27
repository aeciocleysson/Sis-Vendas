using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Vendas_Mega.Model
{
    public class ItensPedido
    {
        public int Id { get; set; }
        public int Id_Pedido_Itens { get; set; }
        public Estoque Produto { get; set; }
        public int Quant_Prod { get; set; }
        public Decimal Valor_Unitario { get; set; }
        public Decimal Desconto { get; set; }
        public Decimal Valor_Total { get; set; }
    }
}
