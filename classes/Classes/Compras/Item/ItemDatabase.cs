﻿using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras.Item
{
    public class ItemDatabase
    {
        public int Salvar(ItemDTO dto)
        {
            string script = @"INSERT INTO tb_item(
                                          nm_item,
                                          id_fornecedor,
                                          vl_preco,
                                          ds_item) VALUES(
                                          @nm_item,
                                          @id_fornecedor,
                                          @vl_preco,
                                          @ds_item)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_item", dto.Nome));
            parms.Add(new MySqlParameter("id_fornecedor", dto.FornecedorId));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));
            parms.Add(new MySqlParameter("ds_item", dto.Descricao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ItemDTO> Listar()
        {
            string script = @"SELECT * FROM tb_item";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ItemDTO> lista = new List<ItemDTO>();
            if (reader.Read())
            {
                ItemDTO dto = new ItemDTO();
                dto.Id = reader.GetInt32("id_item");
                dto.Nome = reader.GetString("nm_item");
                dto.FornecedorId = reader.GetInt32("id_fornecedor");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Descricao = reader.GetString("ds_item");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ItemDTO> ListarPraGrid()
        {
            string script = @"SELECT * FROM tb_item";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ItemDTO> lista = new List<ItemDTO>();
            if (reader.Read())
            {
                ItemDTO dto = new ItemDTO();
                dto.Id = reader.GetInt32("id_item");
                dto.Nome = reader.GetString("nm_item");
                dto.FornecedorId = reader.GetInt32("id_fornecedor");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Descricao = reader.GetString("ds_item");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ItemDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_item WHERE nm_item LIKE @nm_item";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_item", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ItemDTO> lista = new List<ItemDTO>();
            while (reader.Read())
            {
                ItemDTO dto = new ItemDTO();
                dto.Id = reader.GetInt32("id_item");
                dto.Nome = reader.GetString("nm_item");
                dto.FornecedorId = reader.GetInt32("id_fornecedor");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Descricao = reader.GetString("ds_item");

                lista.Add(dto);
            }
            reader.Close();
            return lista;

        }

        public ItemDTO ConsultarProTxt(string nome, int fornecedor)
        {
            string script = @"SELECT * FROM tb_item WHERE nm_item LIKE @nm_item AND id_fornecedor LIKE @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_item", nome + "%"));
            parms.Add(new MySqlParameter("id_fornecedor", fornecedor + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            ItemDTO dto = null;
            while (reader.Read())
            {
                dto = new ItemDTO();
                dto.Id = reader.GetInt32("id_item");
                dto.Nome = reader.GetString("nm_item");
                dto.FornecedorId = reader.GetInt32("id_fornecedor");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Descricao = reader.GetString("ds_item");
            }
            reader.Close();
            return dto;

        }
    }
}
