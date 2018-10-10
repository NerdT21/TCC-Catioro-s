using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class FornecedoresDataBase
    {



        public int Salvar(FornecedoresDTO fornecedor)
        {

            string script = @"INSERT INTO tb_fornecedor(id_estado,
                                                        nm_fornecedor,
                                                        ds_email,
                                                        ds_cnpj,
                                                        ds_telefone,
                                                        ds_cidade,
                                                        ds_bairro
                                                        )  VALUES (
                                                        @id_estado,
                                                        @nm_fornecedor,
                                                        @ds_email,
                                                        @ds_cnpj,
                                                        @ds_telefone,
                                                        @ds_cidade,
                                                        @ds_bairro)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estado", fornecedor.IdEstado));
            parms.Add(new MySqlParameter("nm_fornecedor", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_email", fornecedor.Email));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.Cnpj));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            parms.Add(new MySqlParameter("ds_cidade", fornecedor.Cidade));
            parms.Add(new MySqlParameter("ds_bairro", fornecedor.Bairro));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(FornecedoresDTO fornecedor)
        {

            string script = @"UPDATE tb_fornecedor SET  id_estado = @id_estado,
                                                        nm_fornecedor = @nm_fornecedor,
                                                        ds_email = @ds_email,
                                                        ds_cnpj = @ds_cnpj,
                                                        ds_telefone = @ds_telefone,
                                                        ds_cidade = @ds_cidade,
                                                        ds_bairro = @ds_bairro
                                                        WHERE ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estado", fornecedor.IdEstado));
            parms.Add(new MySqlParameter("nm_fornecedor", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_email", fornecedor.Email));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.Cnpj));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            parms.Add(new MySqlParameter("ds_cidade", fornecedor.Cidade));
            parms.Add(new MySqlParameter("ds_bairro", fornecedor.Bairro));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE  FROM tb_fornecedor WHERE id_fornecedor = @id_fornecedor ";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<FornecedoresDTO> Listar()
        {

            string script = @"SELECT * FROM ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FornecedoresDTO> lista = new List<FornecedoresDTO>();
            while (reader.Read())
            {

                FornecedoresDTO add = new FornecedoresDTO();
                add.Id = reader.GetInt32("id_fornecedor");
                add.IdEstado = reader.GetInt32("id_estado");
                add.Nome = reader.GetString("nm_fornecedor");
                add.Email = reader.GetString("ds_email");
                add.Cnpj = reader.GetString("ds_cnpj");
                add.Telefone = reader.GetString("ds_telefone");
                add.Cidade = reader.GetString("ds_cidade");
                add.Bairro = reader.GetString("ds_bairro");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<FornecedoresDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM  WHERE  LIKE";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FornecedoresDTO> lista = new List<FornecedoresDTO>();
            while (reader.Read())
            {

                FornecedoresDTO add = new FornecedoresDTO();
                add. = reader.Get("");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }





    }
}
