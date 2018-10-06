using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PedidoItemDTO
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int Quantidade { get; set; }

        public string Tipo { get; set; }
    }
}
