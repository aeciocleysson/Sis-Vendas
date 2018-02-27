using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Vendas_Mega.Model
{
    public class Estoque
    {
        public int Id_Produto { get; set; }
        public string Descricao_Produto { get; set; }
        public Decimal Valor_Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_Cad { get; set; }
        public int Quant_Mini { get; set; }
        public int Quant_Maxi { get; set; }
    }
}
