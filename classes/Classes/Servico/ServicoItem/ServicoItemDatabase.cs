using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Servico.ServicoItem
{
    public class ServicoItemDatabase
    {
        public int Salvar(ServicoItemDTO dto)
        {
            string script = @"INSERT INTO tb_servico_item(id_servico, id_item)
                                                   VALUES(@id_servico, @id_item)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_servico", dto.ServicoId));
            parms.Add(new MySqlParameter("id_item", dto.ItemId));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
    }
}
