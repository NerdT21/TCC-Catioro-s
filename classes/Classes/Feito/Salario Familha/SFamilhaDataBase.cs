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

            string script = @"SELECT * FROM tb_salarioFamilia ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            SFamilhaDTO add = null;
            if (reader.Read())
            {

                add = new SFamilhaDTO();
                add.Id = reader.GetInt32("id_salFamilia");
                add.SalFamilia = reader.GetDecimal("vl_salFamilia");
                add.Valor = reader.GetInt32("int_qtdDependente");
            }

            reader.Close();

            return add;

        }

    }
}
