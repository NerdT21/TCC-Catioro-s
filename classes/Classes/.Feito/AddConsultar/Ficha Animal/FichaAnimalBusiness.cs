using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
  public class FichaAnimalBusiness
    {
        public int Salvar(FichaAnimalDTO ficha)
        {
            FichaAnimalDatabase DB = new FichaAnimalDatabase();
            int id = DB.Salvar(ficha);
            return id;
        }
        public void Alterar(FichaAnimalDTO ficha)
        {
            FichaAnimalDatabase DB = new FichaAnimalDatabase();
            DB.Alterar(ficha);
        }
        public void Remover(int idficha)
        {
            FichaAnimalDatabase DB = new FichaAnimalDatabase();
            DB.Remover(idficha);
        }
        public List<FichaAnimalDTO> Listar()
        {
            FichaAnimalDatabase DB = new FichaAnimalDatabase();
            List<FichaAnimalDTO> ficha = DB.Listar();
            return ficha;
        }
    }
}
