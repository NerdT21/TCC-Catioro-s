using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class DeptoBusiness
    {
        public int Salvar(DeptoDTO depto)
        {
            DeptoDataBase DB = new DeptoDataBase ();
            int id = DB.Salvar(depto);
            return id;
        }
        public void Alterar(DeptoDTO depto)
        {
            DeptoDataBase DB = new DeptoDataBase();
            DB.Alterar(depto);
        }
        public void Remover(int iddepto)
        {
            DeptoDataBase DB = new DeptoDataBase();
            DB.Remover(iddepto);
        }
        public List<DeptoDTO> Listar()
        {
            DeptoDataBase DB = new DeptoDataBase();
            List<DeptoDTO> depto = DB.Listar();
            return depto;
        }
    }
}
