using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class RacaDatabase
    {
        public int Salvar(RacaDTO raca)
        {

            string script = @"INSERT INTO tb_raca(nm_nome,
                                                    nm_especie,)
                                            VALUES (@nm_nome,
                                                    @nm_especie,)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", raca.Nome));
            parms.Add(new MySqlParameter("nm_especie", raca.NmEspecie));
          

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(RacaDTO raca)
        {

            string script = @"UPDATE tb_raca SET nm_nome = @nm_nome,
                                                    nm_especie = @nm_especie,
                                              WHERE id_raca = @id_raca";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_raca", raca.Id));
            parms.Add(new MySqlParameter("nm_nome", raca.Nome));
            parms.Add(new MySqlParameter("nm_especie", raca.NmEspecie));
            
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int idraca)
        {

            string script = @"DELETE FROM tb_raca WHERE id_raca = @id_raca";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_raca", idraca));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<RacaDTO> Listar()
        {

            string script = @"SELECT * FROM tb_raca";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<RacaDTO> racaL = new List<RacaDTO>();
            while (reader.Read())
            {
                RacaDTO raca = new RacaDTO();
                raca.Id = reader.GetInt32("id_raca");
                raca.Nome= reader.GetString("nm_nome");
                raca.NmEspecie= reader.GetString("nm_especie");
              

                racaL.Add(raca);

            }

            reader.Close();

            return racaL;

        }

        public List<VacinaDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_raca WHERE id_raca, nm_nome LIKE @id_raca, @nm_nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_raca", nome + "%"));
            parms.Add(new MySqlParameter("nm_nome", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<VacinaDTO> racaL = new List<VacinaDTO>();
            while (reader.Read())
            {
                VacinaDTO raca = new VacinaDTO();
                raca.Id = reader.GetInt32("id_raca");
                raca.Tipo = reader.GetString("nm_nome");
                raca.Prioridade = reader.GetString("nm_especie");
                

                racaL.Add(raca);

            }

            reader.Close();

            return racaL;

        }


    }
}
