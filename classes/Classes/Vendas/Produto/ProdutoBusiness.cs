using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Vendas.Produto
{
    public class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Salvar(dto);
        }

        public List<ProdutoDTO> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Listar();
        }

        public List<ProdutoDTO> Consultar(string nome)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Consultar(nome);
        }

    }
}
