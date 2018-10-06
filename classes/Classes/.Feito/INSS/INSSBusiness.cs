using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class INSSBusiness
    {
        public int Salvar(INSSDTO impostorenda)
        {
            INSSDatabase DB = new INSSDatabase();
            int id = DB.Salvar(impostorenda);
            return id;
        }
        public void Alterar(INSSDTO impostorenda)
        {
            INSSDatabase DB = new INSSDatabase();
            DB.Alterar(impostorenda);
        }
        public void Remover(int idimpostorenda)
        {
            INSSDatabase DB = new INSSDatabase();
            DB.Remover(idimpostorenda);
        }
        public List<INSSDTO> Listar()
        {
            INSSDatabase DB = new INSSDatabase();
            List<INSSDTO> impostorenda = DB.Listar();
            return impostorenda;
        }
    }
}
