using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Estoque
{
    public class EstoqueBusiness
    {
        public int Salvar(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Salvar(dto);
        }

        public List<EstoqueDTO> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Listar();
        }

        public EstoqueDTO ListarCompraVenda()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ListarCompraVenda();
        }
        public List<EstoqueView> Consultar(string nome)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Consultar(nome);
        }
        public void Adicionar(int qtd, int idProduto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Adicionar(qtd, idProduto);
        }

        public void Remover(int qtd, int idProduto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Remover(qtd, idProduto);
        }
    }
}
