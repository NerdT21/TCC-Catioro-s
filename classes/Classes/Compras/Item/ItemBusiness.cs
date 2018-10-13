using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras.Item
{
    public class ItemBusiness
    {
        public int Salvar(ItemDTO dto)
        {
            ItemDatabase db = new ItemDatabase();
            return db.Salvar(dto);
        }

        public List<ItemDTO> Listar()
        {
            ItemDatabase db = new ItemDatabase();
            return db.Listar();
        }

        public List<ItemDTO> Consultar(string nome)
        {
            ItemDatabase db = new ItemDatabase();
            return db.Consultar(nome);
        }

        public ItemDTO ConsultarProTxt(string nome, int fornecedor)
        {
            ItemDatabase db = new ItemDatabase();
            return db.ConsultarProTxt(nome, fornecedor);
        }

    }
}
