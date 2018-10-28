using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Gastos_Adicionais
{
    public class GastosDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public string Descricao { get; set; }

        public string Data { get; set; }
    }
}
