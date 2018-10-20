﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Catiotro_s.classes.Base;

namespace Catiotro_s.classes.Classes.Compras.ItemCompras
{
    public class ItemComprasDatabase
    {
        public int Salvar(ItemComprasDTO dto)
        {
            string script = @"INSERT INTO tb_item_compra(id_item, id_compra) VALUES(@id_item, @id_compra)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.ItemId));
            parms.Add(new MySqlParameter("id_compra", dto.CompraId));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

    }
}
