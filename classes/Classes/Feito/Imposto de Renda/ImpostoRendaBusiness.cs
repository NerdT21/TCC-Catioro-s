using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class ImpostoRendaBusiness
    {
       
        public void Alterar(ImpostoRendaDTO impostorenda)
        {
            ImpostoRendaDatabase DB = new ImpostoRendaDatabase();
            DB.Alterar(impostorenda);
        }
             
        public List<ImpostoRendaDTO> Listar()
        {
            ImpostoRendaDatabase DB = new ImpostoRendaDatabase();
            List<ImpostoRendaDTO> impostorenda = DB.Listar();
            return impostorenda;
        }

        public List<ImpostoRendaDTO> Consultar(string consult)
        {
            ImpostoRendaDatabase db = new ImpostoRendaDatabase();
            return db.Consultar(consult);
        }

    }
}
