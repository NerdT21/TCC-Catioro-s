using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class UsuarioDatabase
    {



        public int Salvar(UsuarioDTO user)
        {

            string script = @"INSERT INTO tb_login(id_usuario,
                                                  nm_funcionario,
	                                              nm_usuario,
	                                              ds_senha,
                                                  ds_email,
	                                              pr_permissaoADM,
	                                              pr_permissaoCadastro,
	                                              pr_permissaoConsulta)  
                                                  VALUE (@nm_funcionario,
	                                              @nm_usuario,
	                                              @ds_senha,
                                                  @ds_email,
	                                              @pr_permissaoADM,
	                                              @pr_permissaoCadastro,
	                                              @pr_permissaoConsulta)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcionario",user.Nome));
            parms.Add(new MySqlParameter("nm_usiario", user.Login));
            parms.Add(new MySqlParameter("ds_senha", user.Senha));
            parms.Add(new MySqlParameter("ds_email", user.Email));
            parms.Add(new MySqlParameter("pr_permissaoADM", user.ADM));
            parms.Add(new MySqlParameter("pr_permissaoCadastro", user.Cadastro));
            parms.Add(new MySqlParameter("pr_permissaoConsulta", user.Consulta));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(UsuarioDTO user)
        {

            string script = @"UPDATE tb_login SET nm_funcionario = @nm_funcionario,
	                                              nm_usuario = @nm_usuario,
	                                              ds_senha = @ds_senha,
                                                  ds_email = @ds_email,
	                                              pr_permissaoADM = @pr_permissaoADM,
	                                              pr_permissaoCadastro = @pr_permissaoCadastro,
	                                              pr_permissaoConsulta = @pr_permissaoConsulta WHERE
                                                  id_usuario = @id_usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcionario", user.Nome));
            parms.Add(new MySqlParameter("nm_usuario", user.Login));
            parms.Add(new MySqlParameter("ds_senha", user.Senha));
            parms.Add(new MySqlParameter("ds_email", user.Email));
            parms.Add(new MySqlParameter("pr_permissaoADM", user.ADM));
            parms.Add(new MySqlParameter("pr_permissaoCadastro", user.Cadastro));
            parms.Add(new MySqlParameter("pr_permissaoConsulta", user.Consulta));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_login WHERE id_login = @id_login";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_login", Id));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<UsuarioDTO> Listar()
        {

            string script = @"SELECT * FROM tb_login ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.Id = reader.GetInt32("id_login");
                dto.Nome = reader.GetString("nm_funcionario");
                dto.Login = reader.GetString("nm_usuario");
                dto.Senha = reader.GetString("ds_senha");
                dto.Email = reader.GetString("ds_email");
                dto.ADM = reader.GetString("pr_permissaoADM");
                dto.Cadastro = reader.GetString("pr_permissaoCadastro");
                dto.Consulta = reader.GetString("pr_permissaoConsulta");

                lista.Add(dto);
            }

            reader.Close();

            return lista;

        }

        public List<UsuarioDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_login WHERE nm_usuario LIKE @nm_usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_usario", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {

                UsuarioDTO add = new UsuarioDTO();
                add. = reader.Get("");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }





    }
}
