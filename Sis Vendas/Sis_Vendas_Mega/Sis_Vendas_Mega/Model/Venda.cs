using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Vendas_Mega.Model
{
    class Venda
    {
        public int Id_Venda { get; set; }
        public DateTime Data_Venda { get; set; }
        public int Produto { get; set; }
        public int Cliente { get; set; }
        public int Vendedor { get; set; }
        public int Quantidade_Prod { get; set; }
        public Decimal Valor_Produto { get; set; }
        public Decimal Valor_Total { get; set; }
        public Decimal Desconto { get; set; }
        public string Situacao_Pedido { get; set; }
        public string Forma_Pag { get; set; }
    }
}
