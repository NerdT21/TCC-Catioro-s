using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class INSSBusiness
   { 
      public List<INSSDTO> Listar()
      {
          INSSDatabase DB = new INSSDatabase();
          List<INSSDTO> impostorenda = DB.Listar();
          return impostorenda;
      }

        public List<INSSDTO> Consultar(string consult)
        {
            INSSDatabase db = new INSSDatabase();
            return db.Consultar(consult);
        }
    }
}
