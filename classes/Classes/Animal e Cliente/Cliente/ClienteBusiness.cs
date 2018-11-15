using Catiotro_s.classes.Classes.AddConsultar.Cliente;
using Catiotro_s.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
    public class ClienteBusiness
    {
        public int Salvar(ClienteDTO cliente)
        {
            //=-=-=-=-----=-=-=--=-=-=-NOME-==--=-=-=-=-=-=-=-=-=-=-=-=
            string nome = cliente.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 100)
            {
                throw new ValidacaoException("O nome do cliente não pode passar de 100 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do cliente é obrigatório.");
            }

            //-----------------------EMAIL--------------------------
            string email = cliente.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            if (qtdEmail > 100)
            {
                throw new ValidacaoException("Este Email é muito grande.\nO limite é 100 caracteres. ");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("Email é obrigatório.");
            }

            Validacoes.ValidarEmail ValidarEmail = new Validacoes.ValidarEmail();
            bool e = ValidarEmail.VerificarEmail(email);

            if (e == false)
            {
                throw new ValidacaoException("Email inválido.");
            }

            //-------------------------RG----------------------------
            string rg = cliente.Rg;

            if (rg == "  ,   ,   -")
            {
                throw new ValidacaoException("RG é obrigatório.");
            }

            //------------------------CPF-------------------------
            string cpf = cliente.Cpf;

            if (cpf == "   ,   ,   -")
            {
                throw new ValidacaoException("CPF é obrigatório.");
            }

            //-------------------CIDADE----------------------------
            string cidade = cliente.Cidade;
            cidade = cidade.Trim();
            int qtdCidade = cidade.Count();

            if (qtdCidade > 50)
            {
                throw new ValidacaoException("Cidade não pode passar de 50 caracteres.");
            }
            else if (qtdCidade == 0)
            {
                throw new ValidacaoException("Cidade é obrigatória.");
            }

            //------------------RUA---------------------------------
            string rua = cliente.Rua;
            rua = rua.Trim();
            int qtdRua = rua.Count();

            if (qtdRua > 150)
            {
                throw new ValidacaoException("Rua não pode passar de 150 caracteres");
            }
            else if (qtdRua == 0)
            {
                throw new ValidacaoException("Rua é obrigatório.");
            }

            //--------------------TELEFONE---------------------------
            string telefone = cliente.Telefone;

            Validacoes.ValidarTelefone validarTell = new Validacoes.ValidarTelefone();
            bool t = validarTell.VerificarTelefone(telefone);

            if (t == false)
            {
                throw new ValidacaoException("Telefone incorreto.");
            }

            //--------------------NASCIMENTO--------------------------

            if (cliente.DataNascimento == "  /  /")
            {
                throw new ValidacaoException("Nascimento é obrigatório.");
            }

            Validacoes.ValidarData data = new Validacoes.ValidarData();
            bool validData = data.validaData(cliente.DataNascimento);

            if (validData == false)
            {
                throw new ValidacaoException("Nascimento inválido.");
            }

            if (validData == true)
            {
                DateTime agora = DateTime.Now;
                int ano = agora.Year;

                DateTime nasc = Convert.ToDateTime(cliente.DataNascimento);
                int anoNasc = nasc.Year;

                string agoraTexto = Convert.ToString(agora);
                string nascTexto = Convert.ToString(nasc);

                int ResAnos = ano - anoNasc;

                if (ResAnos > 150)
                {
                    throw new ValidacaoException("A data informada é inválida.");
                }

                if (anoNasc > ano)
                {
                    throw new ValidacaoException("A data informada é inválida.");
                }

                if (agoraTexto == nascTexto)
                {
                    throw new ValidacaoException("A data informada é inválida.");
                }
            }

            // ============================ NUMERO =============================

            string numero = cliente.Numero;
            numero = numero.Trim();
            int qtdNumero = numero.Count();

            if (qtdNumero > 6)
            {
                throw new ValidacaoException("O número informado é muito grande.");
            }

            ClienteDataBase DB = new ClienteDataBase();
            int id = DB.Salvar(cliente);
            return id;
        }

        public void Alterar(ClienteDTO cliente)
        {
            //=-=-=-=-----=-=-=--=-=-=-NOME-==--=-=-=-=-=-=-=-=-=-=-=-=
            string nome = cliente.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 100)
            {
                throw new ValidacaoException("O nome do cliente não pode passar de 100 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do cliente é obrigatório.");
            }

            //-----------------------EMAIL--------------------------
            string email = cliente.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            if (qtdEmail > 100)
            {
                throw new ValidacaoException("Este Email é muito grande.\nO limite é 100 caracteres. ");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("Email é obrigatório.");
            }

            Validacoes.ValidarEmail ValidarEmail = new Validacoes.ValidarEmail();
            bool e = ValidarEmail.VerificarEmail(email);

            if (e == false)
            {
                throw new ValidacaoException("Email inválido.");
            }

            //-------------------------RG----------------------------
            string rg = cliente.Rg;

            if (rg == "  ,   ,   -")
            {
                throw new ValidacaoException("RG é obrigatório.");
            }

            //------------------------CPF-------------------------
            string cpf = cliente.Cpf;

            if (cpf == "   ,   ,   -")
            {
                throw new ValidacaoException("CPF é obrigatório.");
            }

            //-------------------CIDADE----------------------------
            string cidade = cliente.Cidade;
            cidade = cidade.Trim();
            int qtdCidade = cidade.Count();

            if (qtdCidade > 50)
            {
                throw new ValidacaoException("Cidade não pode passar de 50 caracteres.");
            }
            else if (qtdCidade == 0)
            {
                throw new ValidacaoException("Cidade é obrigatória.");
            }

            //------------------RUA---------------------------------
            string rua = cliente.Rua;
            rua = rua.Trim();
            int qtdRua = rua.Count();

            if (qtdRua > 150)
            {
                throw new ValidacaoException("Rua não pode passar de 150 caracteres");
            }
            else if (qtdRua == 0)
            {
                throw new ValidacaoException("Rua é obrigatório.");
            }

            //--------------------TELEFONE---------------------------
            string telefone = cliente.Telefone;

            Validacoes.ValidarTelefone validarTell = new Validacoes.ValidarTelefone();
            bool t = validarTell.VerificarTelefone(telefone);

            if (t == false)
            {
                throw new ValidacaoException("Telefone incorreto.");
            }

            //--------------------NASCIMENTO--------------------------

            if (cliente.DataNascimento == "  /  /")
            {
                throw new ValidacaoException("Nascimento é obrigatório.");
            }

            Validacoes.ValidarData data = new Validacoes.ValidarData();
            bool validData = data.validaData(cliente.DataNascimento);

            if (validData == false)
            {
                throw new ValidacaoException("Nascimento inválido.");
            }

            if (validData == true)
            {
                DateTime agora = DateTime.Now;
                int ano = agora.Year;

                DateTime nasc = Convert.ToDateTime(cliente.DataNascimento);
                int anoNasc = nasc.Year;

                string agoraTexto = Convert.ToString(agora);
                string nascTexto = Convert.ToString(nasc);

                int ResAnos = ano - anoNasc;

                if (ResAnos > 150)
                {
                    throw new ValidacaoException("A data informada é inválida.");
                }

                if (anoNasc > ano)
                {
                    throw new ValidacaoException("A data informada é inválida.");
                }

                if (agoraTexto == nascTexto)
                {
                    throw new ValidacaoException("A data informada é inválida.");
                }
            }

            // ============================ NUMERO =============================

            string numero = cliente.Numero;
            numero = numero.Trim();
            int qtdNumero = numero.Count();

            if (qtdNumero > 6)
            {
                throw new ValidacaoException("O número informado é muito grande.");
            }


            ClienteDataBase DB = new ClienteDataBase();
            DB.Alterar(cliente);
        }

        public void Remover(int idcliente)
        {
            ClienteDataBase DB = new ClienteDataBase();
            DB.Remover(idcliente);
        }

        public List<ClienteView> Listar()
        {
            ClienteDataBase DB = new ClienteDataBase();
            return DB.Listar();
        }

        public List<ClienteDTO> ListarPraCombo()
        {
            ClienteDataBase DB = new ClienteDataBase();
            return DB.ListarPraCombo();
        }

        public List<ClienteView> Consultar(string nome, string cpf)
        {
            ClienteDataBase DB = new ClienteDataBase();
            return DB.Consultar(nome, cpf);
        }
    }
}
