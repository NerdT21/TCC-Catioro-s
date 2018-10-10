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

            string script = @"SELECT * FROM tb_salario_familh ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<SFamilhaDTO> lista = new List<SFamilhaDTO>();
            while (reader.Read())
            {

                SFamilhaDTO add = new SFamilhaDTO();
                add.Id = reader.GetInt32("id_sal_familia");
                add.SalFamilia = reader.GetDecimal("vl_sal_familia");
                add.QtdDepentes = reader.GetInt32("int_qtd_dependente");
                add.IdFolhaPag = reader.GetInt32("id_folha_pag");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<SFamilhaDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_salario_familia WHERE id_sal_familia LIKE @id_sal_familia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_sal_familia", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<SFamilhaDTO> lista = new List<SFamilhaDTO>();
            while (reader.Read())
            {
                SFamilhaDTO add = new SFamilhaDTO();
                add.Id = reader.GetInt32("id_sal_familia");
                add.SalFamilia = reader.GetDecimal("vl_sal_familia");
                add.QtdDepentes = reader.GetInt32("int_qtd_dependente");
                add.IdFolhaPag = reader.GetInt32("id_folha_pag");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

    }
}
