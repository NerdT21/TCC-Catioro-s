using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PedidoItemDatabase
    {



        public int Salvar(PedidoItemDTO item)
        {

            string script = @"INSERT INTO tb_item_pedido ( id_pedido,
                                                           ds_qtd,
                                                           ds_tipo )
                                                   VALUE ( @id_pedido,
                                                           @ds_qtd,
                                                           @ds_tipo)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", item.IdPedido));
            parms.Add(new MySqlParameter("ds_qtd", item.Quantidade));
            parms.Add(new MySqlParameter("ds_tipo",item.Tipo));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(PedidoItemDTO item)
        {
             
            string script = @"UPDATE tb_item_pedido SET id_pedido = @id_pedido,
                                                        ds_qtd = @ds_qtd,
                                                        ds_tipo = @ds_tipo,
                                                  WHERE id_item_pedido = @id_item_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item_pedido", item.Id));
            parms.Add(new MySqlParameter("id_pedido", item.IdPedido));
            parms.Add(new MySqlParameter("ds_qtd", item.Quantidade));
            parms.Add(new MySqlParameter("ds_tipo", item.Tipo));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_item_pedido WHERE id_item_pedido  = @id_item_pedido";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item_pedido", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<PedidoItemDTO> Listar()
        {

            string script = @"SELECT * FROM tb_item_pedido";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PedidoItemDTO> lista = new List<PedidoItemDTO>();
            while (reader.Read())
            {

                PedidoItemDTO add = new PedidoItemDTO();
                add.Id = reader.GetInt32("id_item_pedido");
                add.IdPedido = reader.GetInt32("id_pedido");
                add.Quantidade = reader.GetInt32("ds_qtd");
                add.Tipo = reader.GetString("ds_tipo");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<PedidoItemDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_item_pedido WHERE id_item_pedido LIKE @id_item_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item_pedido", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PedidoItemDTO> lista = new List<PedidoItemDTO>();
            while (reader.Read())
            {

                PedidoItemDTO add = new PedidoItemDTO();
                add.Id = reader.GetInt32("id_item_pedido");
                add.IdPedido = reader.GetInt32("id_pedido");
                add.Quantidade = reader.GetInt32("ds_qtd");
                add.Tipo = reader.GetString("ds_tipo");


                lista.Add(add);

            }

            reader.Close();

            return lista;

        }





    }
}
