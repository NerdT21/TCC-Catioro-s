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


        public SFamilhaDTO Consultar(decimal salario)
        {

            string script = @"SELECT * FROM tb_salarioFamilia WHERE ds_salFamilia = @ds_salFamilia";

            Database db = new Database();
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_salFamilia", salario));

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            SFamilhaDTO add = null;
            if (reader.Read())
            {
                add = new SFamilhaDTO();
                add.Id = reader.GetInt32("id_salFamilia");
                add.SalFamilia = reader.GetDecimal("ds_salFamilia");
                add.Valor = reader.GetInt32("vl_salFamilia");
            }

            reader.Close();

            return add;

        }

    }
}
