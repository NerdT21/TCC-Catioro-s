using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
    public class FuncionariosDataBase
    {

        public int Salvar(FuncionarioDTO funcio)
        {

            string script = @"INSERT INTO tb_funcionario (int_salario,
                                                              id_log,
                                                              id_depto,
                                                              id_estado,
                                                              nm_nome,
                                                              ds_email,
                                                              ds_cpf,
                                                              ds_rg,
                                                              ds_cep,
                                                              ds_cidade,
                                                              ds_celular,
                                                              ds_telefone,
                                                              ds_especialidade,
                                                              img_funci)
                                                       VALUE (@int_salario,
                                                              @id_log,
                                                              @id_depto,
                                                              @id_estado,
                                                              @nm_nome,
                                                              @ds_email,
                                                              @ds_cpf,
                                                              @ds_rg,
                                                              @ds_cep,
                                                              @ds_cidade,
                                                              @ds_celular,
                                                              @ds_telefone,
                                                              @ds_especialidade,
                                                              @img_funci)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("int_salario", funcio.Idsalario));
            parms.Add(new MySqlParameter("id_log", funcio.Idlog));
            parms.Add(new MySqlParameter("id_depto", funcio.IdDepto));
            parms.Add(new MySqlParameter("id_estado", funcio.Idestado));
            parms.Add(new MySqlParameter("nm_nome", funcio.Nome));
            parms.Add(new MySqlParameter("ds_email", funcio.Email));
            parms.Add(new MySqlParameter("ds_cpf", funcio.Cpf));
            parms.Add(new MySqlParameter("ds_rg", funcio.Rg));
            parms.Add(new MySqlParameter("ds_cep", funcio.Cep));
            parms.Add(new MySqlParameter("ds_cidade", funcio.Cidade));
            parms.Add(new MySqlParameter("ds_celular", funcio.Celular));
            parms.Add(new MySqlParameter("ds_telefone", funcio.Telefone));
            parms.Add(new MySqlParameter("ds_especialidade", funcio.Especialidade));
            parms.Add(new MySqlParameter("img_funci", funcio.Imagem));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(FuncionarioDTO funcio)
        {

            string script = @"UPDATE tb_funcionario SET WHERE ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", funcio.Id));
            parms.Add(new MySqlParameter("int_salario", funcio.Idsalario));
            parms.Add(new MySqlParameter("id_log", funcio.Idlog));
            parms.Add(new MySqlParameter("id_depto", funcio.IdDepto));
            parms.Add(new MySqlParameter("id_estado", funcio.Idestado));
            parms.Add(new MySqlParameter("nm_nome", funcio.Nome));
            parms.Add(new MySqlParameter("ds_email", funcio.Email));
            parms.Add(new MySqlParameter("ds_cpf", funcio.Cpf));
            parms.Add(new MySqlParameter("ds_rg", funcio.Rg));
            parms.Add(new MySqlParameter("ds_cep", funcio.Cep));
            parms.Add(new MySqlParameter("ds_cidade", funcio.Cidade));
            parms.Add(new MySqlParameter("ds_celular", funcio.Celular));
            parms.Add(new MySqlParameter("ds_telefone", funcio.Telefone));
            parms.Add(new MySqlParameter("ds_especialidade", funcio.Especialidade));
            parms.Add(new MySqlParameter("img_funci", funcio.Imagem));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario ";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<FuncionarioDTO> Listar()
        {

            string script = @"SELECT * FROM tb_funcionario ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO add = new FuncionarioDTO();
                add.Id = reader.GetInt32("id_funcionario");
                add.Idsalario = reader.GetInt32("int_salario");
                add.Idlog = reader.GetInt32("id_log");
                add.IdDepto = reader.GetInt32("id_depto");
                add.Idestado = reader.GetInt32("id_estado");
                add.Nome = reader.GetString("nm_nome");
                add.Email = reader.GetString("ds_email");
                add.Cpf = reader.GetString("ds_cpf");
                add.Rg = reader.GetString("ds_rg");
                add.Cep = reader.GetString("ds_cep");
                add.Cidade = reader.GetString("ds_cidade");
                add.Celular = reader.GetString("ds_celular");
                add.Telefone = reader.GetString("ds_telefone");
                add.Especialidade = reader.GetString("ds_especialidade");
                add.Imagem = reader.GetByte("img_funci");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<FuncionarioDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_funcionario WHERE id_funcionario LIKE @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO add = new FuncionarioDTO();
                add.Id = reader.GetInt32("id_funcionario");
                add.Idsalario = reader.GetInt32("int_salario");
                add.Idlog = reader.GetInt32("id_log");
                add.IdDepto = reader.GetInt32("id_depto");
                add.Idestado = reader.GetInt32("id_estado");
                add.Nome = reader.GetString("nm_nome");
                add.Email = reader.GetString("ds_email");
                add.Cpf = reader.GetString("ds_cpf");
                add.Rg = reader.GetString("ds_rg");
                add.Cep = reader.GetString("ds_cep");
                add.Cidade = reader.GetString("ds_cidade");
                add.Celular = reader.GetString("ds_celular");
                add.Telefone = reader.GetString("ds_telefone");
                add.Especialidade = reader.GetString("ds_especialidade");
                add.Imagem = reader.GetByte("img_funci");




                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

    }
}