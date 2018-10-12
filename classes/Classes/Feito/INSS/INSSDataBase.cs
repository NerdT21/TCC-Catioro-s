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

        public INSSDTO Consultar(decimal salario)
        {

            string script = @"SELECT * FROM tb_inss WHERE ds_salarioDeContribuicao LIKE @ds_salarioDeContribuicao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_salarioDeContribuicao", salario + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            INSSDTO add = null;
            if (reader.Read())
            {
                add = new INSSDTO();
                add.Id = reader.GetInt32("id_inss");
                add.SalarioContribuicao = reader.GetDecimal("ds_salarioDeContribuicao");
                add.Aliquota = reader.GetDecimal("vl_aliquota");
            }

            reader.Close();
            return add;
        }

    }
}
