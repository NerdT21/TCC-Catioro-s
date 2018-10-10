using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class SFamilhaBusiness
    {

        public List<SFamilhaDTO> Listar()
        {
            SFamilhaDatabase DB = new SFamilhaDatabase();
            List<SFamilhaDTO> lista = DB.Listar();
            return lista;
        }

        public List<SFamilhaDTO> Consultar(string consult)
        {
            SFamilhaDatabase DB = new SFamilhaDatabase();
            return DB.Consultar(consult);
        }

}
}
