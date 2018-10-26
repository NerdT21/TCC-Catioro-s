using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Estoque;
using Catiotro_s.classes.Classes.Vendas.ProdutoVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Vendas
{
    public class VendaBusiness
    {
        public int Salvar(VendaDTO dto, List<ProdutoDTO> item)
        {
            VendaDatabase db = new VendaDatabase();
            int IdCompra = db.Salvar(dto);

            ProdutoVendasBusiness buss = new ProdutoVendasBusiness();
            foreach (ProdutoDTO i in item)
            {
                ProdutoVendasDTO itemDto = new ProdutoVendasDTO();
                itemDto.VendaId = IdCompra;
                itemDto.ProdutoId = i.Id;

                buss.Salvar(itemDto);

                EstoqueBusiness EstoqueBuss = new EstoqueBusiness();
                EstoqueBuss.Remover(1, i.Id);
            }

            return IdCompra;
        }

        public List<ProdutoVendasView> Listar()
        {
            VendaDatabase db = new VendaDatabase();
            return db.Listar();
        }

        public List<ProdutoVendasView> Consultar(string data)
        {
            VendaDatabase db = new VendaDatabase();
            return db.Consultar(data);
        }
    }
}
