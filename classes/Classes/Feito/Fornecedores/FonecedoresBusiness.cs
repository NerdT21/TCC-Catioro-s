using Catiotro_s.classes.Classes.Feito.Fornecedores;
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
        public FornecedoresDTO Listar()
        {
            FornecedoresDataBase DB = new FornecedoresDataBase();
            return DB.Listar();
        }

        public List<FornecedorView> Consultar(string nome, string cidade)
        {
            FornecedoresDataBase db = new FornecedoresDataBase();
            return db.Consultar(nome, cidade);
        }

        public List<FornecedorView> ListarPraGrid()
        {
            FornecedoresDataBase db = new FornecedoresDataBase();
            return db.ListarPraGrid();
        }

        public List<FornecedoresDTO> ListarPraCombo()
        {
            FornecedoresDataBase db = new FornecedoresDataBase();
            return db.ListarPraCombo();
        }
    }
}
