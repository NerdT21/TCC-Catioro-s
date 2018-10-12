using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class ImpostoRendaDatabase
    {
        public ImpostoRendaDTO Consultar(decimal baseCalculo)
        {

            string script = @"SELECT * FROM tb_impostoDeRenda WHERE ds_baseDeCalculo = @ds_baseDeCalculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("tb_impostoDeRenda", baseCalculo + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            ImpostoRendaDTO add = null;
            if (reader.Read())
            {
                add = new ImpostoRendaDTO();
                add.Id = reader.GetInt32("id_impost_rend");
                add.Base = reader.GetInt32("tb_impostoDeRenda");
                add.Aliquota = reader.GetDecimal("vl_aliquota");
                add.Deducao = reader.GetDecimal("vl_deducao");
            }
            reader.Close();
            return add;
        }
    }
}
