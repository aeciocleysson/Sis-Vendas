using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Vendas_Mega.Model
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Nome_Cliente { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Tipo_Pessoa { get; set; }
    }
}
