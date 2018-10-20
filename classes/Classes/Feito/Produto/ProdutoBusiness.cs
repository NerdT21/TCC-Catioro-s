using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase ();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Remover(id);
        }

        public List<ProdutoDTO> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            List<ProdutoDTO> list = db.Listar();
            return list;
        }

        public List<ProdutoDTO> Consultar(string nome, string marca)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Consultar(nome, marca);
        }
    }
}
