using Catiotro_s.classes.Classes.Compras.Item;
using Catiotro_s.classes.Classes.Estoque;
using Catiotro_s.classes.Classes.Servico;
using Catiotro_s.classes.Classes.Servico.ServicoItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Servicos
{
    public class ServicoBusiness
    {
        public int Salvar(ServicoDTO dto, List<ItemDTO> item)
        {
            ServicoDatabase db = new ServicoDatabase();
            int pk = db.Salvar(dto);

            ServicoItemBusiness buss = new ServicoItemBusiness();
            foreach (ItemDTO i in item)
            {
                ServicoItemDTO itens = new ServicoItemDTO();
                itens.ItemId = i.Id;
                itens.ServicoId = pk;

                buss.Salvar(itens);

                EstoqueBusiness estoqueBuss = new EstoqueBusiness();
                estoqueBuss.Remover(1, i.Id);
            }
            return pk;
        }

        public List<ServicoView> Listar()
        {
            ServicoDatabase db = new ServicoDatabase();
            return db.Listar();
        }

        public List<ServicoView> Consultar(string nome, string data)
        {
            ServicoDatabase db = new ServicoDatabase();
            return db.Consultar(nome, data);
        }
    }
}
