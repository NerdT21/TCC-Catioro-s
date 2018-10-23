using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Estoque
{
    public class EstoqueDatabase
    {
        public int Salvar(EstoqueDTO dto)
        {
            string script = @"INSERT INTO tb_estoque(id_itemProduto, nm_produto, qtd_estocado)
                                              VALUES(@id_itemProduto, @nm_produto, @qtd_estocado)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_itemProduto", dto.ItemProdutoId));
            parms.Add(new MySqlParameter("nm_produto", dto.Produto));
            parms.Add(new MySqlParameter("qtd_estocado", dto.QtdEstocado));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<EstoqueView> Listar()
        {
            string script = @"SELECT * FROM vw_estoque";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<EstoqueView> lista = new List<EstoqueView>();
            while (reader.Read())
            {
                EstoqueView dto = new EstoqueView();
                dto.Id = reader.GetInt32("id_estoque");
                dto.ItemId = reader.GetInt32("id_itemProduto");
                dto.Produto = reader.GetString("nm_produto");
                dto.QtdEstocado = reader.GetInt32("qtd_estocado");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<EstoqueView> Consultar(string produto)
        {
            string script = @"SELECT * FROM vw_estoque WHERE nm_produto LIKE @nm_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", produto + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueView> lista = new List<EstoqueView>();
            while (reader.Read())
            {
                EstoqueView dto = new EstoqueView();
                dto.Id = reader.GetInt32("id_estoque");
                dto.ItemId = reader.GetInt32("id_itemProduto");
                dto.Produto = reader.GetString("nm_produto");
                dto.QtdEstocado = reader.GetInt32("qtd_estocado");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public void Adicionar(int qtd, string item)
        {
            string script = @"SELECT qtd_estocado + " + qtd + " FROM vw_estoque WHERE id_itemProduto = @id_itemProduto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_itemProduto", item));

            Database db = new Database();
            db.ExecuteSelectScript(script, parms);
        }

        public void Remover(int qtd, string item)
        {
            string script = @"SELECT qtd_estocado - " + qtd + " FROM vw_estoque WHERE id_itemProduto = @id_itemProduto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_itemProduto", item));

            Database db = new Database();
            db.ExecuteSelectScript(script, parms);
        }

    }
}
