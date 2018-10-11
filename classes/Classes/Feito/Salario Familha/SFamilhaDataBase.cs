using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class SFamilhaDatabase
    {


        public List<SFamilhaDTO> Listar()
        {

            string script = @"SELECT * FROM tb_salarioFamilia ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<SFamilhaDTO> lista = new List<SFamilhaDTO>();
            while (reader.Read())
            {

                SFamilhaDTO add = new SFamilhaDTO();
                add.Id = reader.GetInt32("id_salFamilia");
                add.SalFamilia = reader.GetDecimal("vl_salFamilia");
                add.QtdDepentes = reader.GetInt32("int_qtdDependente");
                add.IdFolhaPag = reader.GetInt32("id_folhaPagto");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<SFamilhaDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_salarioFamilia WHERE id_salFamilia LIKE @id_salFamilia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_salFamilia", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<SFamilhaDTO> lista = new List<SFamilhaDTO>();
            while (reader.Read())
            {
                SFamilhaDTO add = new SFamilhaDTO();
                add.Id = reader.GetInt32("id_salFamilia");
                add.SalFamilia = reader.GetDecimal("vl_salfamilia");
                add.QtdDepentes = reader.GetInt32("int_qtdDependente");
                add.IdFolhaPag = reader.GetInt32("id_folhaPagto");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

    }
}
