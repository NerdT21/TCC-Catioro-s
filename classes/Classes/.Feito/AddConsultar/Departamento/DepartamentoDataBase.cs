﻿using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class DeptoDataBase
    {

        public class DeptoDatabase
        {
            public int Salvar(DeptoDTO depto)
            {
                string script = @"INSERT INTO tb_Depto(nm_Depto, ds_Depto) VALUES(@nm_depto, @ds_Depto)";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("nm_Depto", depto.Nome));
                parms.Add(new MySqlParameter("ds_Depto", depto.Descricao));

                Database db = new Database();
                return db.ExecuteInsertScriptWithPk(script, parms);
            }

            public List<DeptoDTO> Listar()
            {
                string script = @"SELECT * FROM tb_Depto";

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, null);

                List<DeptoDTO> deptos = new List<DeptoDTO>();
                while (reader.Read())
                {
                    DeptoDTO dto = new DeptoDTO();
                    dto.Id = reader.GetInt32("id_Depto");
                    dto.Nome = reader.GetString("nm_Depto");
                    dto.Descricao = reader.GetString("ds_Depto");

                    deptos.Add(dto);
                }
                reader.Close();
                return deptos;
            }

            public List<DeptoDTO> Consultar(string depto)
            {
                string script = @"SELECT * FROM tb_depto WHERE nm_depto LIKE @nm_depto";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("nm_depto", depto + "%"));
                parms.Add(new MySqlParameter("ds_depto", depto + "%"));

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

                List<DeptoDTO> lista = new List<DeptoDTO>();
                while (reader.Read())
                {
                    DeptoDTO dto = new DeptoDTO();
                    dto.Id = reader.GetInt32("id_depto");
                    dto.Nome = reader.GetString("nm_depto");
                    dto.Descricao = reader.GetString("ds_Depto");

                    lista.Add(dto);
                }
                reader.Close();
                return lista;
            }

            public void Alterar(DeptoDTO depto)
            {
                string script = @"UPDATE tb_depto SET nm_depto = @nm_depto WHERE id_depto = @id_depto";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_depto", depto.Id));
                parms.Add(new MySqlParameter("nm_depto", depto.Nome));
                parms.Add(new MySqlParameter("ds_Depto", depto.Descricao));

                Database db = new Database();
                db.ExecuteInsertScript(script, parms);
            }

            public void Remover(int Iddepto)
            {
                string script = @"DELETE FROM tb_depto WHERE id_depto = @id_depto";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_depto", Iddepto));

                Database db = new Database();
                db.ExecuteInsertScript(script, parms);
            }
        }

    }
}
