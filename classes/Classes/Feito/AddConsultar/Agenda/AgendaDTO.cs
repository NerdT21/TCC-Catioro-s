using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
    public class AgendaDTO
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int IdServ { get; set; }
        public string Saida { get; set; }
        public int IdAnimal { get; set; }
        public string Status { get; set; }

    } 
}
