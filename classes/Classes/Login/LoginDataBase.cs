using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Login
{
    public class LoginDataBase
    {

        public int Salvar(LoginDTO dto)
        {

            string script = @"INSERT INTO tb_login(nm_usuario,
                                                   nm_funcionario,
                                                   ds_senha,
                                                   ds_email,
                                                   pr_permissaoADM,
                                                   pr_permissaoCadastro,
                                                   pr_permissaoConsulta)
                                           VALUES (@nm_usuario,
                                                   @ds_senha,
                                                   @pr_permissaoADM,
                                                   @pr_permissaoCadastro,
                                                   @pr_permissaoConsulta) ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_usuario", dto.Nome));
            parms.Add(new MySqlParameter("nm_funcionario", dto.NmUsuario));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("pr_permissaoADM", dto.PermicaoADM));
            parms.Add(new MySqlParameter("pr_permissaoCadastro", dto.PermicaoCadastro));
            parms.Add(new MySqlParameter("pr_permissaoConsulta", dto.PermicaoConsulta));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public LoginDTO Logar (string usuario, string senha)
        {

            string script = @"SELECT * FROM tb_login WHERE nm_usuario = @nm_usuario AND ds_senha = @ds_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_usuario", usuario));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            LoginDTO dto = null;
            if (reader.Read())
            {

                dto = new LoginDTO();
                dto.Id = reader.GetInt32("id_usuario");
                dto.NmUsuario = reader.GetString("nm_funcionario");
                dto.Nome = reader.GetString("nm_usuario");
                dto.Senha = reader.GetString("ds_senha");
                dto.Email = reader.GetString("ds_email");
                dto.PermicaoADM = reader.GetBoolean("pr_permissaoADM");
                dto.PermicaoCadastro = reader.GetBoolean("pr_permissaoCadastro");
                dto. PermicaoConsulta= reader.GetBoolean("pr_permissaoConsulta");



            }

            reader.Close();

            return dto;

        }

    }
}
