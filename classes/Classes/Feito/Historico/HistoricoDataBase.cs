using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class HistoriocoDatabase
    {



        public int Salvar(HistoricoDTO histo)
        {

            string script = @"INSERT INTO (id_animal,
                                            id_vacina,
                                            id_funcionario,
                                            ds_dose)  
                                    VALUES (
                                            @id_animal,
                                            @id_vacina,
                                            @id_funcionario,
                                            @ds_dose)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", histo.IdAnimal));
            parms.Add(new MySqlParameter("id_vacina", histo.IdVacina));
            parms.Add(new MySqlParameter("id_funcionario", histo.IdFuncionario));
            parms.Add(new MySqlParameter("ds_dose", histo.Dose));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(HistoricoDTO histo)
        {

            string script = @"UPDATE tb_historicoAnimal SET id_animal = @id_animal,
                                                            id_vacina = @id_vacina,
                                                            id_funcionario = @id_funcionario,
                                                            ds_dose = @ds_dose
                                                      WHERE id_historico = @id_historico";

           List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", histo.IdAnimal));
            parms.Add(new MySqlParameter("id_vacina", histo.IdVacina));
            parms.Add(new MySqlParameter("id_funcionario", histo.IdFuncionario));
            parms.Add(new MySqlParameter("ds_dose", histo.Dose));

            Database db = new Database();
           db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE  FROM tb_historico WHERE id_historico = @id_historico";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_historico", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<HistoricoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_historico";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<HistoricoDTO> lista = new List<HistoricoDTO>();
            while (reader.Read())
            {

                HistoricoDTO add = new HistoricoDTO();
                add.IdAnimal = reader.GetInt32("id_animal");
                add.IdVacina = reader.GetInt32("id_vacina");
                add.IdFuncionario = reader.GetInt32("id_funcionario");
                add.Dose = reader.GetString("ds_dose");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<HistoricoDTO> Consultar(string animal)
        {

            string script = @"SELECT * FROM tb_historico WHERE id_animal LIKE @id_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", animal + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<HistoricoDTO> lista = new List<HistoricoDTO>();
            while (reader.Read())
            {
                HistoricoDTO dto = new HistoricoDTO();
                dto.IdAnimal = reader.GetInt32("id_animal");




                lista.Add(dto);
            }

            reader.Close();

            return lista;

        }





    }
}
