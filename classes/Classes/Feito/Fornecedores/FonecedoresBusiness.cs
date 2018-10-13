using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class FornecedoresBusiness
    {
        public int Salvar(FornecedoresDTO forncedor)
        {
            FornecedoresDataBase DB = new FornecedoresDataBase();
            int id = DB.Salvar(forncedor);
            return id;
        }
        public void Alterar(FornecedoresDTO forncedor)
        {
            FornecedoresDataBase DB = new FornecedoresDataBase();
            DB.Alterar(forncedor);
        }
        public void Remover(int idforncedor)
        {
            FornecedoresDataBase DB = new FornecedoresDataBase();
            DB.Remover(idforncedor);
        }
        public List<FornecedoresDTO> Listar()
        {
            FornecedoresDataBase DB = new FornecedoresDataBase();
            List<FornecedoresDTO> forncedor = DB.Listar();
            return forncedor;
        }

        public List<FornecedoresDTO> Consultar(string nome, string cidade)
        {
            FornecedoresDataBase db = new FornecedoresDataBase();
            return db.Consultar(nome, cidade);
        }
    }
}
