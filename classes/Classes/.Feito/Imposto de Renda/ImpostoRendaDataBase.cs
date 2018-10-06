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

        public void Alterar(ImpostoRendaDTO renda)
        {

            string script = @"UPDATE tb_imposto_renda SET vl_aliquota = @vl_aliquota
                                                          vl_deducao = @vl_deducao
                                                          id_folha_pag = @id_folha_pag 
                                                    WHERE id_impost_rend = @id_impost_rend ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_impost_rend", renda.Id));
            parms.Add(new MySqlParameter("vl_aliquota", renda.Aliquota));
            parms.Add(new MySqlParameter("vl_deducao", renda.Deducao));
            parms.Add(new MySqlParameter("id_folha_pag", renda.IdFolhaPag));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        

        public List<ImpostoRendaDTO> Listar()
        {

            string script = @"SELECT * FROM tb_imposto_renda ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ImpostoRendaDTO> lista = new List<ImpostoRendaDTO>();
            while (reader.Read())
            {

                ImpostoRendaDTO add = new ImpostoRendaDTO();
                add.Id = reader.GetInt32("id_impost_rend");
                add.Aliquota = reader.GetDecimal("vl_aliquota");
                add.Deducao = reader.GetDecimal("vl_deducao");
                add.IdFolhaPag = reader.GetInt32("id_folha_pag");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<ImpostoRendaDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_imposto_renda WHERE id_impost_rend LIKE @id_impost_rend";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_impost_rend", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ImpostoRendaDTO> lista = new List<ImpostoRendaDTO>();
            while (reader.Read())
            {

                ImpostoRendaDTO add = new ImpostoRendaDTO();
                add.Id = reader.GetInt32("id_impost_rend");
                add.Aliquota = reader.GetDecimal("vl_aliquota");
                add.Deducao = reader.GetDecimal("vl_deducao");
                add.IdFolhaPag = reader.GetInt32("id_folha_pag");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }




    }
}
