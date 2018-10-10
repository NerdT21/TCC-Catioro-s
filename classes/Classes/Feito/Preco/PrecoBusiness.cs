using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PrecoBusiness
    {
        public int Salvar(PrecoDTO dto)
        {
            PrecoDatabase db = new PrecoDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(PrecoDTO dto)
        {
            PrecoDatabase db = new PrecoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            PrecoDatabase db = new PrecoDatabase();
            db.Remover(id);
        }


        public List<PrecoDTO> Listar()
        {
            PrecoDatabase db = new PrecoDatabase();
            List<PrecoDTO> list = db.Listar();
            return list;
        }

        public List<PrecoDTO> Consultar(string consult)
        {
            PrecoDatabase db = new PrecoDatabase();
            return db.Consultar(consult);
        }

    }
}
