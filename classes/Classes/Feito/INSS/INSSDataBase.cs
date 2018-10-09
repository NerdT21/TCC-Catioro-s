using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
    public class INSSDatabase
    {

        public List<INSSDTO> Listar()
        {

            string script = @"SELECT * FROM tb_inss ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<INSSDTO> lista = new List<INSSDTO>();
            while (reader.Read())
            {

                INSSDTO add = new INSSDTO();
                add.Id = reader.GetInt32("id_inss");
                add.IdFolhaPag = reader.GetInt32("id_folha_pag");
                add.Aliquota = reader.GetDecimal("vl_aliquota");

                lista.Add(add);

            }

            reader.Close();

            return lista;

        }

        public List<INSSDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_inss WHERE id_inss LIKE @id_inss";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_inss", nome + "%"));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<INSSDTO> lista = new List<INSSDTO>();
            while (reader.Read())
            {
                INSSDTO add = new INSSDTO();
                add.Id = reader.GetInt32("id_inss");
                add.IdFolhaPag = reader.GetInt32("id_folha_pag");
                add.Aliquota = reader.GetDecimal("vl_aliquota");

                lista.Add(add);

            }

            reader.Close();

            return lista;

        }

    }
}
