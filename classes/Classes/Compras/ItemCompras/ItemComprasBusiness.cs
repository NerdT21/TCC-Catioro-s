using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras.ItemCompras
{
    public class ItemComprasBusiness
    {
        public int Salvar(ItemComprasDTO dto)
        {
            ItemComprasDatabase db = new ItemComprasDatabase();
            return db.Salvar(dto);
        }
    }
}
