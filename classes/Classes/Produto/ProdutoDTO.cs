using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
  public  class ProdutoDTO
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Peso { get; set; }
        public string DataValidade { get; set; }
        public string Lote { get; set; }
    }
}
