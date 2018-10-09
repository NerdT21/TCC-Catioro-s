using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class FPagamentoBusiness
    {
        public int Salvar(FPamentoDTO folhapag)
        {
            FPagamentoDataBase DB = new FPagamentoDataBase();
            int id = DB.Salvar(folhapag);
            return id;
        }
        public void Alterar(FPamentoDTO folhapag)
        {
            FPagamentoDataBase DB = new FPagamentoDataBase();
            DB.Alterar(folhapag);
        }
        public void Remover(int idfolhapag)
        {
            FPagamentoDataBase DB = new FPagamentoDataBase();
            DB.Remover(idfolhapag);
        }
        public List<FPamentoDTO> Listar()
        {
            FPagamentoDataBase DB = new FPagamentoDataBase();
            List<FPamentoDTO> folhapag = DB.Listar();
            return folhapag;
        }
    }
}
