using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
    public class AgendaBusiness
    {
        public int Salvar(AgendaDTO agenda)
        {
            AgendaDataBase DB = new AgendaDataBase();
            int id = DB.Salvar(agenda);
            return id;
        }
        public void Alterar(AgendaDTO agenda)
        {
            AgendaDataBase DB = new AgendaDataBase();
            DB.Alterar(agenda);
        }
        public void Remover(int idagenda)
        {
            AgendaDataBase DB = new AgendaDataBase();
            DB.Remover(idagenda);
        }
        public List<AgendaDTO> Listar()
        {
            AgendaDataBase DB = new AgendaDataBase();
            List<AgendaDTO> agenda = DB.Listar();
            return agenda;
        }
    }
}
