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

            string script = @"INSERT INTO ()  VALUE ()";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", .));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(UsuarioDTO user)
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

        public List<> Listar()
        {

            string script = @"SELECT * FROM ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<> lista = new List<>();
            while (reader.Read())
            {

                add = new ();
                add. = reader.Get("");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<UsuarioDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM  WHERE  LIKE";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", nome + "%"));


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
