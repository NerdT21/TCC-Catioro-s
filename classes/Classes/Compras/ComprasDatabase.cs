using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras
{
    public class ComprasDatabase
    {
        public int Salvar(ComprasDTO dto)
        {
            string script = @"INSERT INTO tb_compra(
                                            id_item, 
                                            qtd_comprado,
                                            dt_compra,
                                            ds_formaPagamento,
                                            vl_preco) VALUES(                                            
                                            @id_item, 
                                            @qtd_comprado,
                                            @dt_compra,
                                            @ds_formaPagamento,
                                            @vl_preco)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.ItemId));
            parms.Add(new MySqlParameter("qtd_comprado", dto.Qtd));
            parms.Add(new MySqlParameter("dt_compra", dto.Data));
            parms.Add(new MySqlParameter("ds_formaPagamento", dto.FormaPagto));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ComprasDTO> Listar()
        {
            string script = @"SELECT * FROM tb_compra";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ComprasDTO> lista = new List<ComprasDTO>();
            while (reader.Read())
            {
                ComprasDTO dto = new ComprasDTO();
                dto.Id = reader.GetInt32("id_compra");
                dto.ItemId = reader.GetInt32("id_item");
                dto.Qtd = reader.GetInt32("qtd_comprado");
                dto.Data = reader.GetString("dt_compra");
                dto.FormaPagto = reader.GetString("ds_formaPagamento");
                dto.Preco = reader.GetDecimal("vl_preco");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ComprasDTO> Consultar(string nome, string data)
        {
            string script = @"SELECT * FROM tb_compra WHERE id_item LIKE @id_item AND dt_compra LIKE @dt_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item ", nome + "%"));
            parms.Add(new MySqlParameter("ds_compra", data + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ComprasDTO> lista = new List<ComprasDTO>();
            while (reader.Read())
            {
                ComprasDTO dto = new ComprasDTO();
                dto.Id = reader.GetInt32("id_compra");
                dto.ItemId = reader.GetInt32("id_item");
                dto.Qtd = reader.GetInt32("qtd_comprado");
                dto.Data = reader.GetString("dt_compra");
                dto.FormaPagto = reader.GetString("ds_formaPagamento");
                dto.Preco = reader.GetDecimal("vl_preco");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
    }
}
