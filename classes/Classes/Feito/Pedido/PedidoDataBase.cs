using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PedidoDatabase
    {



        public int Salvar(PedidoDTO pedido)
        {

            string script = @"INSERT INTO tb_pedido (id_cliente,
                                                     id_funcionario,
                                                     int_valor,
                                                     ds_data,
                                                     ds_hora,
                                                     ds_forma_pagamento,
                                                     ds_status)  
                                              VALUE (@id_cliente,
                                                     @id_funcionario,
                                                     @int_valor,
                                                     @ds_data,
                                                     @ds_hora,
                                                     @ds_forma_pagamento,
                                                     @ds_status)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", pedido.Id));
            parms.Add(new MySqlParameter("id_funcionario", pedido.IdFuncionario));
            parms.Add(new MySqlParameter("int_valor", pedido.Valor));
            parms.Add(new MySqlParameter("ds_data", pedido.Data));
            parms.Add(new MySqlParameter("ds_hora", pedido.Hora));
            parms.Add(new MySqlParameter("ds_forma_pagamento", pedido.FormaPag));
            parms.Add(new MySqlParameter("ds_status", pedido.Satus));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(PedidoDTO pedido)
        {

            string script = @"UPDATE tb_pedido SET  id_cliente = @id_cliente,
                                                    id_funcionario = @id_funcionario,
                                                    int_valor = @int_valor,
                                                    ds_data = @ds_data,
                                                    ds_hora = @ds_hora,
                                                    ds_forma_pagamento = @ds_forma_pagamento,
                                                    ds_status = @ds_status
                                              WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", pedido.Id));
            parms.Add(new MySqlParameter("id_cliente", pedido.IdCliente));
            parms.Add(new MySqlParameter("id_funcionario", pedido.IdFuncionario));
            parms.Add(new MySqlParameter("int_valor", pedido.Valor));
            parms.Add(new MySqlParameter("ds_data", pedido.Data));
            parms.Add(new MySqlParameter("ds_hora", pedido.Hora));
            parms.Add(new MySqlParameter("ds_forma_pagamento", pedido.FormaPag));
            parms.Add(new MySqlParameter("ds_status", pedido.Satus));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_pedido WHERE id_pedido = @id_pedido";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<PedidoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_pedido ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PedidoDTO> lista = new List<PedidoDTO>();
            while (reader.Read())
            {

                PedidoDTO add = new PedidoDTO();
                add.Id = reader.GetInt32("id_pedido");
                add.IdCliente = reader.GetInt32("id_cliente");
                add.IdFuncionario = reader.GetInt32("id_funcionario");
                add.Valor = reader.GetDecimal("int_valor");
                add.Data = reader.GetString("ds_data");
                add.Hora = reader.GetString("ds_hora");
                add.FormaPag = reader.GetString("ds_forma_pagamento");
                add.Satus = reader.GetString("ds_status");

                lista.Add(add);

                //id_pedido,
                //id_cliente,                                     
                //id_funcionario,
                //int_valor,
                //ds_data,
                //ds_hora,
                //ds_forma_pagamento,
                //ds_status
            }

            reader.Close();

            return lista;

        }

        public List<PedidoDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_pedido WHERE id_pedido LIKE @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PedidoDTO> lista = new List<PedidoDTO>();
            while (reader.Read())
            {

                PedidoDTO add = new PedidoDTO();
                add.Id = reader.GetInt32("id_pedido");
                add.IdCliente = reader.GetInt32("id_cliente");
                add.IdFuncionario = reader.GetInt32("id_funcionario");
                add.Valor = reader.GetDecimal("int_valor");
                add.Data = reader.GetString("ds_data");
                add.Hora = reader.GetString("ds_hora");
                add.FormaPag = reader.GetString("ds_forma_pagamento");
                add.Satus = reader.GetString("ds_status");

                lista.Add(add);

                //id_pedido,
                //id_cliente,                                     
                //id_funcionario,
                //int_valor,
                //ds_data,
                //ds_hora,
                //ds_forma_pagamento,
                //ds_status
            }

            reader.Close();

            return lista;

        }





    }
}
