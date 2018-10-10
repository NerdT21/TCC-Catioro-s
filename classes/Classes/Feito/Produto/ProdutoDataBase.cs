using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class ProdutoDatabase
    {



        public int Salvar(ProdutoDTO produto)
        {

            string script = @"INSERT INTO tb_produto(nm_produto,
                                                    ds_marca,
                                                    ds_produto
                                                     ) 
                                              VALUES (
                                                    @nm_produto,
                                                    @ds_marca,
                                                    @ds_produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto",produto.Nome));
            parms.Add(new MySqlParameter("ds_marca", produto.Marca));
            parms.Add(new MySqlParameter("ds_produto", produto.Descricao));
            

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(ProdutoDTO produto)
        {

            string script = @"UPDATE tb_produto SET nm_produto = @nm_produto,
                                                    ds_marca = @ds_marca,
                                                     ds_produto = @ds_produto
                                              WHERE id_produto = @id_produto ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.Id));
            parms.Add(new MySqlParameter("nm_produto", produto.Nome));
            parms.Add(new MySqlParameter("ds_marca", produto.Marca));
            parms.Add(new MySqlParameter("ds_produto", produto.Descricao));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE  FROM tb_produto WHERE id_produto = @id_produto";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<ProdutoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_produto ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO add = new ProdutoDTO();
                add.Id = reader.GetInt32("id_produto");
                add.Nome = reader.GetString("nm_produto");
                add.Marca = reader.GetString("ds_marca");
                add.Descricao = reader.GetString("ds_produto");
                

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<ProdutoDTO> Consultar(string nome, string marca)
        {

            string script = @"SELECT * FROM tb_produto WHERE nm_produto LIKE @nm_produto 
                                                        AND ds_marca LIKE @ds_marca";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", nome + "%"));
            parms.Add(new MySqlParameter("ds_marca", marca + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO add = new ProdutoDTO();
                add.Nome = reader.GetString("nm_produto");
                add.Marca = reader.GetString("ds_marca");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }





    }
}
