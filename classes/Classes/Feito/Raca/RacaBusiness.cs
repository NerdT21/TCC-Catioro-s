using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class RacaBusiness
    {


        public int Salvar(RacaDTO dto)
        {
            RacaDatabase db = new RacaDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(RacaDTO dto)
        {
            RacaDatabase db = new RacaDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            RacaDatabase db = new RacaDatabase();
            db.Remover(id);
        }


        public List<RacaDTO> Listar()
        {
            RacaDatabase db = new RacaDatabase();
            List<RacaDTO> list = db.Listar();
            return list;
        }

        //public List<RacaDTO> Consultar(string consult)
        //{
        //    RacaDatabase db = new RacaDatabase();
        //    return db.Consultar(consult);
             
        //}



    }
}
