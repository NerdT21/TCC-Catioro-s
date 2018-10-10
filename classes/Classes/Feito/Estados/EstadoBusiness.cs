using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class EstadoBusiness
    {
        public List<EstadoDTO> Listar()
        {
            EstadoDatabase db = new EstadoDatabase();
            return db.Listar();
        }   
    }
}
