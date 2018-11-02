using Catiotro_s.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Gastos_Adicionais
{
    public class GastosBusiness
    {
        public int Salvar(GastosDTO dto)
        {
            //---------------------NOME
            string nome = dto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do gasto não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do gasto é obrigatório.");
            }

            //------------VALOR
            decimal valor = dto.Valor;
            
            if (valor == 0)
            {
                throw new ValidacaoException("O valor não pode ser zero.");
            }

            //--------------DESCRICAO
            string desc = dto.Descricao;
            desc = desc.Trim();
            int qtdDesc = desc.Count();

            if (qtdDesc > 500)
            {
                throw new ValidacaoException("A descrição não pode passsar de 500 caracteres.");
            }
            else if (qtdDesc == 0)
            {
                throw new ValidacaoException("A descrição é obrigatória.")
            }


            GastosDatabase db = new GastosDatabase();
            return db.Salvar(dto);
        }

        public List<GastosDTO> Listar()
        {
            GastosDatabase db = new GastosDatabase();
            return db.Listar();
        }

        public List<GastosDTO> Consultar(string data)
        {
            GastosDatabase db = new GastosDatabase();
            return db.Consultar(data);
        }

        public void Remover(int pk)
        {
            GastosDatabase db = new GastosDatabase();
            db.Remover(pk);
        }
    }
}
