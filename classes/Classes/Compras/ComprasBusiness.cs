using Catiotro_s.classes.Classes.Compras.Item;
using Catiotro_s.classes.Classes.Compras.ItemCompras;
using Catiotro_s.classes.Classes.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras
{
    public class ComprasBusiness
    {
        public int Salvar(ComprasDTO dto, List<ItemDTO> item)
        {
            ComprasDatabase db = new ComprasDatabase();
            int IdCompra = db.Salvar(dto);

            ItemComprasBusiness buss = new ItemComprasBusiness();
            foreach (ItemDTO i in item)
            {
                ItemComprasDTO itemDto = new ItemComprasDTO();
                itemDto.CompraId = IdCompra;
                itemDto.ItemId = i.Id;

                buss.Salvar(itemDto);

                EstoqueBusiness estoqueBuss = new EstoqueBusiness();
                estoqueBuss.Adicionar(1, i.Id);
            }

            return IdCompra;
        }

        public List<ItemComprasView> Listar()
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.Listar();
        }

        public List<ItemComprasView> Consultar(string data)
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.Consultar(data);
        }

        public List<ItemComprasView> ConsultarPorId(int id)
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.ConsultarPorId(id);
        }
    }
}

