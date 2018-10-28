using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.FluxoDeCaixa
{
    public class FluxoBusiness
    {
        public List<FluxoDTO> Listar()
        {
            FluxoDatabase db = new FluxoDatabase();
            return db.Listar();
        }
    }
}
