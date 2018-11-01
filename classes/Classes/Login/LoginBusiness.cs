using Catiotro_s.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Login
{
    public class LoginBusiness
    {

        public int Salvar(LoginDTO dto)
        {
            LoginDataBase db = new LoginDataBase();

            //=========================USUARIO=========================

            string usuario = dto.NmUsuario;
            usuario = usuario.Trim();
            int qtdUsuario = usuario.Count();

            if (qtdUsuario > 50)
            {
                throw new ValidacaoException("O nome de usuário não pode passar de 20 caracteres.");
            }
            else if (qtdUsuario == 0)
            {
                throw new ValidacaoException("O nome de usuário é obrigatório.");
            }

            //=========================SENHA=========================

            string senha = dto.Senha;
            senha = senha.Trim();
            int qtdSenha = senha.Count();

            if (qtdSenha > 20)
            {
                throw new ValidacaoException("A senha não pode passar de 20 caracteres.");
            }
            else if (qtdSenha == 0)
            {
                throw new ValidacaoException("A senha é obrigatória.");
            }

            //=========================EMAIL=========================

            Validacoes.ValidarEmail validarEmail = new Validacoes.ValidarEmail();
            string email = dto.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            if (qtdEmail > 150)
            {
                throw new ValidacaoException("O email não pode passar de 150 caracteres.");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("O Email é obrigatório.");
            }

            bool validEmail = validarEmail.VerificarEmail(email);

            if (validEmail == false)
            {
                throw new ValidacaoException("Email inválido.");
            }

            //=========================NOME FUNCIONÁRIO=========================

            string funcio = dto.Nome;
            funcio = funcio.Trim();
            int qtdFuncio = funcio.Count();

            if (qtdFuncio > 50)
            {
                throw new ValidacaoException("O Nome do Funcionário não pode passar de 50 caracteres.");
            }
            else if (qtdFuncio == 0)
            {
                throw new ValidacaoException("O Nome do Funcionário não pode estar em branco.");
            }

            //=========================PeloMenosUmaPermissao=========================

            if (dto.PermicaoADM == false && dto.PermicaoAtendente == false &&
                dto.PermicaoCompras == false && dto.PermicaoFinanceiro == false &&
                dto.PermicaoFornecedor == false && dto.PermicaoFuncionarios == false && 
                dto.PermicaoProdutos == false && dto.PermicaoServicos == false &&
                dto.PermicaoVendedor == false)
            {
                throw new ValidacaoException("No mínimo uma permissão o usuário deve possuir.");
            }

            return db.Salvar(dto);
        }

        public LoginDTO Logar(string nome, string senha)
        {
            LoginDataBase db = new LoginDataBase();
            return db.Logar(nome, senha);
        }


    }
}
