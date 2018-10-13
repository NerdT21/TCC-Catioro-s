using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras
{
    public class ComprasDTO
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int Qtd { get; set; }

        public string Data{ get; set; }

        public string FormaPagto { get; set; }

        public decimal Preco { get; set; }
    }
}
