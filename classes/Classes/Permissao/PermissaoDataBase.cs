using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PermissaoDatabase
    {



        public int Salvar(PermissaoDTO permissao)
        {

            string script = @"INSERT INTO ()  VALUE ()";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", .));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(PermissaoDTO permissao)
        {

            string script = @"UPDATE SET WHERE ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", .));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE  FROM  WHERE ";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<PermissaoDTO> Listar()
        {

            string script = @"SELECT * FROM ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PermissaoDTO> lista = new List<PermissaoDTO>();
            while (reader.Read())
            {

                add = new ();
                add. = reader.Get("");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<PermissaoDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM  WHERE  LIKE";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PermissaoDTO> lista = new List<PermissaoDTO>();
            while (reader.Read())
            {

                PermissaoDTO add = new PermissaoDTO();
                add. = reader.Get("");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }



    }
}
