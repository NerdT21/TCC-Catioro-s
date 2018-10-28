using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Gastos_Adicionais
{
    public class GastosBusiness
    {
        public int Salvar(GastosDTO dto)
        {
            GastosDatabase db = new GastosDatabase();
            return db.Salvar(dto);
        }

        public List<GastosDTO> Listar()
        {
            GastosDatabase db = new GastosDatabase();
            return db.Listar();
        }

        public List<GastosDTO> Consultar(string data)
        {
            GastosDatabase db = new GastosDatabase();
            return db.Consultar(data);
        }

        public void Remover(int pk)
        {
            GastosDatabase db = new GastosDatabase();
            db.Remover(pk);
        }
    }
}
