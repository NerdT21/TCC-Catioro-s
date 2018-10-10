using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PedidoItemBusiness
    {

        public int Salvar(PedidoItemDTO dto)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(PedidoItemDTO dto)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            db.Remover(id);
        }


        public List<PedidoItemDTO> Listar()
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            List<PedidoItemDTO> list = db.Listar();
            return list;
        }

        public List<PedidoItemDTO> Consultar(string consult)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            return db.Consultar(consult);
        }


    }
}
