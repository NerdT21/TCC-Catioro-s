using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class ImpostoRendaDTO
    {
        public int Id { get; set; }
        public decimal Base { get; set; }
        public decimal Aliquota { get; set; }
        public decimal Deducao { get; set; }
    }
}
