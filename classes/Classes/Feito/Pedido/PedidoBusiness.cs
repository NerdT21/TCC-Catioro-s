using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PedidoBusiness
    {
        public int Salvar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Remover(id);
        }


        public List<PedidoDTO> Listar()
        {
            PedidoDatabase db = new PedidoDatabase();
            List<PedidoDTO> list = db.Listar();
            return list;
        }

        public List<PedidoDTO> Consultar(string consult)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Consultar(consult);
        }
    }
}
