using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
    public class AgendaDataBase
    {
        public int Salvar(AgendaDTO agenda)
        {
            string script = @"INSERT INTO tb_agenda(
            dt_data,
            dt_hora,
            id_servico,
            ds_saida,
            id_animal,
            ds_status)
            VALUES(
            @dt_data,
            @dt_hora,
            @id_servico,
            @ds_saida,
            @id_animal,
            @ds_status)";
            List<MySqlParameter> parm = new List<MySqlParameter>();
            parm.Add(new MySqlParameter("dt_data", agenda.Data));
            parm.Add(new MySqlParameter("dt_hora", agenda.Hora));
            parm.Add(new MySqlParameter("id_servico", agenda.IdServ));
            parm.Add(new MySqlParameter("ds_saida", agenda.Saida));
            parm.Add(new MySqlParameter("id_animal", agenda.IdAnimal));
            parm.Add(new MySqlParameter("ds_status", agenda.Status));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parm);
            return pk;
        }
        public void Alterar(AgendaDTO agenda)
        {
            string script = @"UPDATE tb_agenda SET
            dt_data = @dt_data,
            dt_hora = @dt_hora,
            id_servico = @id_servico,
            ds_saida = @ds_saida,
            id_animal = @id_animal,
            ds_status = @ds_status,
            WHERE id_agenda = @id_agenda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_agenda", agenda.Id));
            parms.Add(new MySqlParameter("dt_data", agenda.Data));
            parms.Add(new MySqlParameter("dt_hora", agenda.Hora));
            parms.Add(new MySqlParameter("id_servico", agenda.IdServ));
            parms.Add(new MySqlParameter("ds_saida", agenda.Saida));
            parms.Add(new MySqlParameter("id_animal", agenda.IdAnimal));
            parms.Add(new MySqlParameter("ds_status", agenda.Status));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int idagenda)
        {
            string script = @"DELETE FROM tb_agenda WHERE id_agenda = @id_agenda";
            List<MySqlParameter> parm = new List<MySqlParameter>();
            parm.Add(new MySqlParameter("id_agenda", idagenda));

            Database db = new Database();
            db.ExecuteInsertScript(script, parm);
        }
        public List<AgendaDTO> Listar()
        {
            string script = @"SELECT * FROM tb_agenda";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);
            List<AgendaDTO> listar = new List<AgendaDTO>();

            while (reader.Read()) 
            {
                AgendaDTO lista = new AgendaDTO();
                lista.Id = reader.GetInt32("Id_agenda");
                lista.Data = reader.GetString("dt_data");
                lista.Hora = reader.GetString("dt_hora");
                lista.IdServ = reader.GetInt32("id_servico");
                lista.Saida = reader.GetString("ds_saida");
                lista.IdAnimal = reader.GetInt32("id_animal");
                lista.Status = reader.GetString("ds_status");

                listar.Add(lista);


            }
            reader.Close();
            return listar;
        }
    }
}
