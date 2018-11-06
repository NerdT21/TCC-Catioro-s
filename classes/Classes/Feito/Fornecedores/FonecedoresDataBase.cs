using Catiotro_s.classes.Base;
using Catiotro_s.classes.Classes.Feito.Fornecedores;
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
                                                        id_fornecedor,
                                                        ds_email,
                                                        ds_cnpj,
                                                        ds_telefone,
                                                        ds_cidade,
                                                        ds_cep,
                                                        ds_rua,
                                                        ds_numero    
                                                        )  VALUES (
                                                        @id_estado,
                                                        @id_fornecedor,
                                                        @ds_email,
                                                        @ds_cnpj,
                                                        @ds_telefone,
                                                        @ds_cidade,
                                                        @ds_cep,
                                                        @ds_rua,
                                                        @ds_numero)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estado", fornecedor.IdEstado));
            parms.Add(new MySqlParameter("id_fornecedor", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_email", fornecedor.Email));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.CNPJ));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            parms.Add(new MySqlParameter("ds_cidade", fornecedor.Cidade));
            parms.Add(new MySqlParameter("ds_cep", fornecedor.CEP));
            parms.Add(new MySqlParameter("ds_rua", fornecedor.Rua));
            parms.Add(new MySqlParameter("ds_numero", fornecedor.Numero));

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
                                                        ds_cep = @ds_cep,
                                                        ds_rua = @ds_rua,
                                                        ds_numero = @ds_numero
                                                        WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estado", fornecedor.IdEstado));
            parms.Add(new MySqlParameter("nm_fornecedor", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_email", fornecedor.Email));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.CNPJ));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            parms.Add(new MySqlParameter("ds_cidade", fornecedor.Cidade));
            parms.Add(new MySqlParameter("ds_cep", fornecedor.CEP));
            parms.Add(new MySqlParameter("ds_rua", fornecedor.Rua));
            parms.Add(new MySqlParameter("ds_numero", fornecedor.Numero));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_fornecedor WHERE id_fornecedor = @id_fornecedor ";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public FornecedoresDTO Listar()
        {

            string script = @"SELECT * FROM tb_fornecedor";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            FornecedoresDTO add = null;
            while (reader.Read())
            {
                add = new FornecedoresDTO();
                add.Id = reader.GetInt32("id_fornecedor");
                add.IdEstado = reader.GetInt32("id_estado");
                add.Nome = reader.GetString("nm_fornecedor");
                add.Email = reader.GetString("ds_email");
                add.CNPJ = reader.GetString("ds_cnpj");
                add.Telefone = reader.GetString("ds_telefone");
                add.Cidade = reader.GetString("ds_cidade");
                add.CEP = reader.GetString("ds_cep");
                add.Rua = reader.GetString("ds_rua");
                add.Numero = reader.GetInt32("ds_numero");
            }
            reader.Close();
            return add;
        }

        public List<FornecedorView> Consultar(string nome, string cidade)
        {
            string script = @"SELECT * FROM vw_consultarFornecedor WHERE nm_fornecedor LIKE @nm_fornecedor AND ds_cidade LIKE @ds_cidade";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_fornecedor", nome + "%"));
            parms.Add(new MySqlParameter("ds_cidade", cidade + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorView> lista = new List<FornecedorView>();
            while (reader.Read())
            {
                FornecedorView add = new FornecedorView();
                add.Id = reader.GetInt32("id_fornecedor");
                add.Estado = reader.GetString("nm_estado");
                add.Nome = reader.GetString("nm_fornecedor");
                add.Email = reader.GetString("ds_email");
                add.CNPJ = reader.GetString("ds_cnpj");
                add.Telefone = reader.GetString("ds_telefone");
                add.Cidade = reader.GetString("ds_cidade");
                add.CEP = reader.GetString("ds_cep");
                add.Rua = reader.GetString("ds_rua");
                add.Numero = reader.GetInt32("ds_numero");

                lista.Add(add);
            }
            reader.Close();
            return lista;
        }

        public List<FornecedorView> ListarPraGrid()
        {
            string script = @"SELECT * FROM vw_consultarFornecedor";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FornecedorView> lista = new List<FornecedorView>();
            while (reader.Read())
            {
                FornecedorView add = new FornecedorView();
                add.Id = reader.GetInt32("id_fornecedor");
                add.Estado = reader.GetString("nm_estado");
                add.Nome = reader.GetString("nm_fornecedor");
                add.Email = reader.GetString("ds_email");
                add.CNPJ = reader.GetString("ds_cnpj");
                add.Telefone = reader.GetString("ds_telefone");
                add.Cidade = reader.GetString("ds_cidade");
                add.CEP = reader.GetString("ds_cep");
                add.Rua = reader.GetString("ds_rua");
                add.Numero = reader.GetInt32("ds_numero");

                lista.Add(add);
            }

            reader.Close();
            return lista;
        }

        public List<FornecedoresDTO> ListarPraCombo()
        {
            string script = @"SELECT * FROM tb_fornecedor";

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
                add.CNPJ = reader.GetString("ds_cnpj");
                add.Telefone = reader.GetString("ds_telefone");
                add.Cidade = reader.GetString("ds_cidade");
                add.CEP = reader.GetString("ds_cep");
                add.Rua = reader.GetString("ds_rua");
                add.Numero = reader.GetInt32("ds_numero");

                lista.Add(add);
            }

            reader.Close();
            return lista;
        }
    }
}
