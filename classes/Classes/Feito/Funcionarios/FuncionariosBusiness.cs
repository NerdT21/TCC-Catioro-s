using Catiotro_s.classes.Classes.Feito.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class FuncionarioBusiness
    {
        public int Salvar(FuncionarioDTO funcionario)
        {
            FuncionariosDataBase DB = new FuncionariosDataBase();
            int id = DB.Salvar(funcionario);
            return id;
        }
        public void Alterar(FuncionarioDTO funcionario)
        {
            FuncionariosDataBase DB = new FuncionariosDataBase();
            DB.Alterar(funcionario);
        }
        public void Remover(int idfuncionario)
        {
            FuncionariosDataBase DB = new FuncionariosDataBase();
            DB.Remover(idfuncionario);
        }
        public List<FuncionarioView> Listar()
        {
            FuncionariosDataBase DB = new FuncionariosDataBase();
            List<FuncionarioView> funcionario = DB.Listar();
            return funcionario;
        }

        public List<FuncionarioView> Consultar(string nome, string cpf)
        {
            FuncionariosDataBase db = new FuncionariosDataBase();
            return db.Consultar(nome, cpf);
        }
    }
}
