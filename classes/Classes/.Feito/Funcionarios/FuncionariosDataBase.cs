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

            string script = @"INSERT INTO tb_funcionario (ds_salario,
                                                              id_depto,
                                                              id_estado,
                                                              nm_nome,
                                                              ds_email,
                                                              ds_cpf,
                                                              ds_rg,
                                                              ds_cep,
                                                              ds_cidade,
                                                              ds_telefone,
                                                              img_funcionario)
                                                       VALUES (@int_salario,
                                                              @id_depto,
                                                              @id_estado,
                                                              @nm_nome,
                                                              @ds_email,
                                                              @ds_cpf,
                                                              @ds_rg,
                                                              @ds_cep,
                                                              @ds_cidade,
                                                              @ds_telefone,
                                                              @img_funcionario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_salario", funcio.Salario));
            
            parms.Add(new MySqlParameter("id_depto", funcio.IdDepto));
            parms.Add(new MySqlParameter("id_estado", funcio.IdEstado));
            parms.Add(new MySqlParameter("nm_nome", funcio.Nome));
            parms.Add(new MySqlParameter("ds_email", funcio.Email));
            parms.Add(new MySqlParameter("ds_cpf", funcio.Cpf));
            parms.Add(new MySqlParameter("ds_rg", funcio.Rg));
            parms.Add(new MySqlParameter("ds_cep", funcio.Cep));
            parms.Add(new MySqlParameter("ds_cidade", funcio.Cidade));
            parms.Add(new MySqlParameter("ds_telefone", funcio.Telefone));
            parms.Add(new MySqlParameter("img_funcionario", funcio.Imagem));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(FuncionarioDTO funcio)
        {

            string script = @"UPDATE tb_funcionario SET nm_nome = @nm_nome,
                                                        ds_salario = @ds_salario,
                                                        id_depto = @id_depto,
                                                        id_estado = @id_estado,
                                                        nm_nome = @nm_nome,
                                                        ds_email = @ds_email,
                                                        ds_cpf = @ds_cpf,
                                                        ds_rg = @ds_rg,
                                                        ds_cep = @ds_cep,
                                                        ds_cidade = @ds_cidade,
                                                        ds_telefone = @ds_telefone,
                                                        img_funcionario = @img_funcionario
                                                            
                                                        WHERE id_funcionario = @id_funcionario ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", funcio.Id));
            parms.Add(new MySqlParameter("ds_salario", funcio.Salario));
            parms.Add(new MySqlParameter("id_depto", funcio.IdDepto));
            parms.Add(new MySqlParameter("id_estado", funcio.IdEstado));
            parms.Add(new MySqlParameter("nm_nome", funcio.Nome));
            parms.Add(new MySqlParameter("ds_email", funcio.Email));
            parms.Add(new MySqlParameter("ds_cpf", funcio.Cpf));
            parms.Add(new MySqlParameter("ds_rg", funcio.Rg));
            parms.Add(new MySqlParameter("ds_cep", funcio.Cep));
            parms.Add(new MySqlParameter("ds_cidade", funcio.Cidade));
            parms.Add(new MySqlParameter("ds_telefone", funcio.Telefone));
            parms.Add(new MySqlParameter("img_funcionario", funcio.Imagem));

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
                add.Salario = reader.GetInt32("ds_salario");
                add.IdDepto = reader.GetInt32("id_depto");
                add.IdEstado = reader.GetInt32("id_estado");
                add.Nome = reader.GetString("nm_nome");
                add.Email = reader.GetString("ds_email");
                add.Cpf = reader.GetString("ds_cpf");
                add.Rg = reader.GetString("ds_rg");
                add.Cep = reader.GetString("ds_cep");
                add.Cidade = reader.GetString("ds_cidade");
                add.Telefone = reader.GetString("ds_telefone");
                add.Imagem = reader.GetString("img_funcionario");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<FuncionarioDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_funcionario WHERE nm_nome LIKE @nm_nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO add = new FuncionarioDTO();
                add.Id = reader.GetInt32("id_funcionario");
                add.Salario = reader.GetInt32("int_salario");
                add.IdDepto = reader.GetInt32("id_depto");
                add.IdEstado = reader.GetInt32("id_estado");
                add.Nome = reader.GetString("nm_nome");
                add.Email = reader.GetString("ds_email");
                add.Cpf = reader.GetString("ds_cpf");
                add.Rg = reader.GetString("ds_rg");
                add.Cep = reader.GetString("ds_cep");
                add.Cidade = reader.GetString("ds_cidade");
                add.Telefone = reader.GetString("ds_telefone");
                add.Imagem = reader.GetString("img_funcionario");




                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

    }
}