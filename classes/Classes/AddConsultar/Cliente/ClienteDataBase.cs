using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
     public class ClienteDataBase
    {
        public int Salvar (ClienteDTO cliente)
        {

            string script = @"INSERT INTO tb_cliente
                                         ( id_estado,
                                           nm_nome,
                                           ds_cpf,
                                           ds_cidade,
                                           ds_cep,
                                           ds_email,
                                           ds_telefone,
                                           dt_nasc,
                                           dt_dataCadastro,
                                           ds_rg,
                                           ds_bairro,
                                           ds_rua,
                                           nr_casa)                                           
                                   VALUES( @id_estado,
                                           @nm_nome,
                                           @ds_cpf,
                                           @ds_endereco,
                                           @ds_cidade,
                                           @ds_cep,
                                           @ds_email,
                                           @ds_telefone,
                                           @dt_nasc,
                                           @dt_dataCadastro,
                                           @ds_rg,
                                           @ds_bairro,
                                           @ds_rua,
                                           @nr_casa)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", cliente.id));
            parms.Add(new MySqlParameter("id_estado", cliente.IdEstado));
            parms.Add(new MySqlParameter("nm_nome", cliente.Nome));
            parms.Add(new MySqlParameter("ds_cep", cliente.Cpf));
            parms.Add(new MySqlParameter("ds_cidade", cliente.Cidade));
            parms.Add(new MySqlParameter("ds_cep", cliente.Cep));
            parms.Add(new MySqlParameter("ds_email", cliente.Email));
            parms.Add(new MySqlParameter("ds_telefone", cliente.Telefone));
            parms.Add(new MySqlParameter("dt_nasc", cliente.DataNascimento));
            parms.Add(new MySqlParameter("dt_dataCadastro", cliente.DataCadastro));
            parms.Add(new MySqlParameter("ds_rg", cliente.Rg));
            parms.Add(new MySqlParameter("ds_bairro", cliente.Bairro));
            parms.Add(new MySqlParameter("ds_rua", cliente.Rua));
            parms.Add(new MySqlParameter("nr_casa", cliente.NumeroCasa));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar (ClienteDTO cliente)
        {

            string script = @"UPDATE tb_cliente SET id_estado = @id_estado,
                                                    nm_nome = @nm_nome,
                                                    int_cpf = @int_cpf,
                                                    nm_local = @nm_local,
                                                    ds_cidade  = @ds_cidade,
                                                    ds_cep = @ds_cep,
                                                    ds_email = @ds_email,
                                                    ds_telefone = @ds_telefone,
                                                    dt_nasc = @dt_nasc,
                                                    dt_dataCadastro = @dt_dataCadastro,
                                                    ds_rg = @ds_rg,
                                                    ds_bairro = @ds_bairro,
                                                    ds_rua = @ds_rua,
                                                    nr_casa
                                              WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", cliente.id));
            parms.Add(new MySqlParameter("id_estado", cliente.IdEstado));
            parms.Add(new MySqlParameter("nm_nome", cliente.Nome));
            parms.Add(new MySqlParameter("ds_cep", cliente.Cpf));
            parms.Add(new MySqlParameter("ds_cidade", cliente.Cidade));
            parms.Add(new MySqlParameter("ds_cep", cliente.Cep));
            parms.Add(new MySqlParameter("ds_email", cliente.Email));
            parms.Add(new MySqlParameter("ds_telefone", cliente.Telefone));
            parms.Add(new MySqlParameter("dt_nasc", cliente.DataNascimento));
            parms.Add(new MySqlParameter("dt_dataCadastro", cliente.DataCadastro));
            parms.Add(new MySqlParameter("ds_rg", cliente.Rg));
            parms.Add(new MySqlParameter("ds_bairro", cliente.Bairro));
            parms.Add(new MySqlParameter("ds_rua", cliente.Rua));
            parms.Add(new MySqlParameter("nr_casa", cliente.NumeroCasa));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover (int IdCliente)
        {

            string script = @"DELETE FROM tb_cliente WHERE id_pessoa = @id_pessoa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pessoa", IdCliente));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }





    }
}
