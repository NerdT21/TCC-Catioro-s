using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PedidoDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public decimal Valor { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string FormaPag { get; set; }
        public string Satus { get; set; }
    }
}
