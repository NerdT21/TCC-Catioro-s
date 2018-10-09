using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class PrecoDatabase
    {


        public int Salvar(PrecoDTO preco)
        {

           string script = @"INSERT INTO tb_preco ( id_fornecedor ,
                                                    id_produto,
                                                    ds_produto_compra )
                                            VALUE ( @id_fornecedor ,
                                                    @id_produto,
                                                    @ds_produto_compra )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", preco.Idfornecedor));
            parms.Add(new MySqlParameter("id_produto", preco.IdProduto));
            parms.Add(new MySqlParameter("ds_produto_compra", preco.ProdutoCompra));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(PrecoDTO preco)
        {

            string script = @"UPDATE tb_preco SET id_fornecedor = @id_fornecedor,
                                                  id_produto = @id_produto,
                                                  ds_produto_compra = @ds_produto_compra, 
                                            WHERE id_preco = @id_preco";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_preco",preco.Id));
            parms.Add(new MySqlParameter("id_fornecedor", preco.Idfornecedor));
            parms.Add(new MySqlParameter("id_produto", preco.IdProduto));
            parms.Add(new MySqlParameter("ds_produto_compra", preco.ProdutoCompra));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_preco WHERE id_preco = @id_preco ";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_preco", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<PrecoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_preco";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PrecoDTO> lista = new List<PrecoDTO>();
            while (reader.Read())
            {


                PrecoDTO add = new PrecoDTO();
                add.Id = reader.GetInt32("id_preco");
                add.Idfornecedor = reader.GetInt32("id_fornecedor");
                add.IdProduto = reader.GetInt32("id_produto");
                add.ProdutoCompra = reader.GetString("ds_produto_compra");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<PrecoDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_preco WHERE id_preco LIKE @id_preco";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_preco", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PrecoDTO> lista = new List<PrecoDTO>();
            while (reader.Read())
            {

                PrecoDTO add = new PrecoDTO();
                add.Id = reader.GetInt32("id_preco");
                add.Idfornecedor = reader.GetInt32("id_fornecedor");
                add.IdProduto = reader.GetInt32("id_produto");
                add.ProdutoCompra = reader.GetString("ds_produto_compra");


                lista.Add(add);

            }

            reader.Close();

            return lista;

        }




    }
}
