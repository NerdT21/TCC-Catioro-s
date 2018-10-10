using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
  public  class FichaAnimalDatabase
    {
        public int Salvar (FichaAnimalDTO ficha)
        {

            string script = @"INSERT INTO tb_ficha_animal(dt_proxima_vc,
                                                          nm_proxima_vc)
                                                  VALUES (@dt_proxima_vc,
                                                          @nm_proxima_vc)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_proxima_vc", ficha.DataProxVc));
            parms.Add(new MySqlParameter("nm_proxima_vc", ficha.NomeProxVc));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;            

        }

        public void Alterar(FichaAnimalDTO ficha)
        {

            string script = @"UPDATE tb_ficha_animal SET dt_proxima_vc = @dt_proxima_vc,
                                                         nm_proxima_vc = @nm_proxima_vc,
                                                   WHERE id_ficha_animal = @id_ficha_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_ficha_animal", ficha.Id));
            parms.Add(new MySqlParameter("dt_proxima_vc", ficha.DataProxVc));
            parms.Add(new MySqlParameter("nm_proxima_vc", ficha.NomeProxVc));

            Database db = new Database();
            db.ExecuteInsertScript(script,parms);

        }

        public void Remover (int IdFicha)
        {

            string scrips = @"DELETE FROM tb_ficha_animal WHERE id_ficha_animal = @id_ficha_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_ficha_animal", IdFicha));

            Database db = new Database();
            db.ExecuteInsertScript(scrips,parms);
        }

        public List<FichaAnimalDTO> Listar()
        {

            string script = @"SELEC * FROM tb_ficha_animal";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FichaAnimalDTO> fichas = new List<FichaAnimalDTO>();
            while (reader.Read())
            {

                FichaAnimalDTO ficha = new FichaAnimalDTO();
                    ficha.Id = reader.GetInt32("id_ficha_animal");
                    ficha.DataProxVc = reader.GetString("dt_proxima_vc");
                    ficha.NomeProxVc = reader.GetString("nm_proxima_vc");

                fichas.Add(ficha);

            }

            reader.Close();

            return fichas;

        }

    }
}
