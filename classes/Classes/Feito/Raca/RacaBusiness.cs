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
            RacaDatabase DB = new RacaDatabase();
            int id = DB.Salvar(dto);
            return id;
        }

        public void Altera(RacaDTO dto)
        {
            RacaDatabase DB = new RacaDatabase();
            DB.Alterar(dto);
        }

        public void Remover(int Id)
        {
            RacaDatabase DB = new RacaDatabase();
            DB.Remover(Id);
        }


        public List<RacaDTO> Listar()
        {
            RacaDatabase DB = new RacaDatabase();
            List<RacaDTO> list = DB.Listar();
            return list;
        }

        public List<RacaDTO> Consultar(string consult)
        {
            RacaDatabase DB = new RacaDatabase();
            return DB.Consultar(consult);
        }



    }
}
