using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class VacinaBusiness
    {

        public int Salvar(VacinaDTO dto)
        {
            VacinaDatabase DB = new VacinaDatabase();
            int id = DB.Salvar(dto);
            return id;
        }

        public void Altera(VacinaDTO dto)
        {
            VacinaDatabase DB = new VacinaDatabase();
            DB.Alterar(dto);
        }

        public void Remover(int Id)
        {
            VacinaDatabase DB = new VacinaDatabase();
            DB.Remover(Id);
        }

        public List<VacinaDTO> Listar()
        {
            VacinaDatabase DB = new VacinaDatabase();
            List<VacinaDTO> list = DB.Listar();
            return list;
        }

        public List<VacinaDTO> Consultar(string consult)
        {
            VacinaDatabase DB = new VacinaDatabase();
            return DB.Consultar(consult);
        }      
    }
}
