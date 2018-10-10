using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
  public  class ServicoDTO
    {
        public int Id { get; set; }

        public int IdAnimal { get; set; }

        public string Servico { get; set; }

        public decimal Valor { get; set; }

        public string Duracao { get; set; }
    }
}
