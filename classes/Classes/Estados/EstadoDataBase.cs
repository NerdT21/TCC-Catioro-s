using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class EstadoDatabase
    {
        public List<EstadoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_estados";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<EstadoDTO> lista = new List<EstadoDTO>();
            while (reader.Read())
            {
                EstadoDTO add = new EstadoDTO();
                add.Id = reader.GetInt32("id_estado");
                add.Estado = reader.GetString("nm_estado");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

    }
}
