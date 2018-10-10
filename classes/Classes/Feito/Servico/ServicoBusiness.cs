using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class ServicoBusiness
    {
        public int Salvar(ServicoDTO dto)
        {
            ServicoDatabase db = new ServicoDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(ServicoDTO dto)
        {
            ServicoDatabase db = new ServicoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            ServicoDatabase db = new ServicoDatabase();
            db.Remover(id);
        }


        public List<ServicoDTO> Listar()
        {
            ServicoDatabase db = new ServicoDatabase();
            List<ServicoDTO> list = db.Listar();
            return list;
        }

        public List<ServicoDTO> Consultar(string consult)
        {
           ServicoDatabase db = new ServicoDatabase();
            return db.Consultar(consult);
        }



    }
}
