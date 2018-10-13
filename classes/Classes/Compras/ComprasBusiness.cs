using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras
{
    public class ComprasBusiness
    {
        public int Salvar(ComprasDTO dto)
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.Salvar(dto);
        }

        public List<ComprasDTO> Listar()
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.Listar();
        }

        public List<ComprasDTO> Consultar(string data)
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.Consultar(data);
        }
    }
}

