using Catiotro_s.CustomException;
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
            string nome = depto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O campo 'Nome do Departamento' não pode possuir mais de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O campo 'Nome do Departamento' não pode estar vazio.");
            }

            string desc = depto.Descricao;
            desc = desc.Trim();
            int qtdDesc = desc.Count();

            if (qtdDesc > 300)
            {
                throw new ValidacaoException("O campo 'Descrição do Departamento' não pode possuir mais de 300 caracteres.");
            }
            else if (qtdDesc == 0)
            {
                throw new ValidacaoException("O campo 'Descrição do Departamento' não pode estar vazio.");
            }


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

        public List<DeptoDTO> Consultar(string depto)
        {
            DeptoDataBase database = new DeptoDataBase();
            return database.Consultar(depto);
        }

    }
}
