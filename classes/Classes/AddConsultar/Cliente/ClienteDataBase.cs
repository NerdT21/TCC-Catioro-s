//using Catiotro_s.classes.Base;
//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Catiotro_s.classes.Classes.Cliente
//{
//    public class ClienteDataBase
//    {
//        public int Salvar(ClienteDTO cliente)
//        {

//            string script = @"INSERT INTO tb_cliente
//                                         ( id_estado,
//                                           nm_nome,
//                                           int_cpf,
//                                           ds_endereco,
//                                           nm_local,
//                                           ds_cidade,
//                                           int_cep,
//                                           ds_email,
//                                           int_tel,
//                                           dt_nasc,
//                                           dt_data_cadastro)                                           
//                                   VALUES( @id_estado,
//                                           @nm_nome,
//                                           @int_cpf,
//                                           @ds_endereco,
//                                           @nm_local,
//                                           @ds_cidade,
//                                           @int_cep,
//                                           @ds_email,
//                                           @int_tel,
//                                           @dt_nasc,
//                                           @dt_data_cadastro)";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_estado", cliente.IdEstado));
//            parms.Add(new MySqlParameter("nm_nome", cliente.Nome));
//            parms.Add(new MySqlParameter("int_cpf", cliente.CPF));
//            parms.Add(new MySqlParameter("ds_endereco", cliente.Endereco));
//            parms.Add(new MySqlParameter("nm_local", cliente.Local));
//            parms.Add(new MySqlParameter("ds_cidade", cliente.Cidade));
//            parms.Add(new MySqlParameter("int_cep", cliente.CEP));
//            parms.Add(new MySqlParameter("ds_email", cliente.Email));
//            parms.Add(new MySqlParameter("int_tel", cliente.Telefone));
//            parms.Add(new MySqlParameter("dt_nasc", cliente.DataNasc));
//            parms.Add(new MySqlParameter("dt_data_cadastro", cliente.DataCadastro));

//            Database db = new Database();
//            int pk = db.ExecuteInsertScriptWithPk(script, parms);
//            return pk;

//        }

//        public void Alterar(ClienteDTO cliente)
//        {

//            string script = @"UPDATE tb_cliente SET id_estado = @id_estado,
//                                                    nm_nome = @nm_nome,
//                                                    int_cpf = @int_cpf,
//                                                    ds_endereco = @ds_endereco,
//                                                    nm_local = @nm_local,
//                                                    ds_cidad  = @ds_cidade,
//                                                    int_cep = @int_cep,
//                                                    ds_email = @ds_email,
//                                                    int_tel = @int_tel,
//                                                    dt_nasc = @dt_nasc,
//                                                    dt_data_cadastro = @dt_data_cadastro,
//                                              WHERE id_pessoa = @id_pessoa";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_estado", cliente.Pessoa));
//            parms.Add(new MySqlParameter("id_estado", cliente.IdEstado));
//            parms.Add(new MySqlParameter("nm_nome", cliente.Nome));
//            parms.Add(new MySqlParameter("int_cpf", cliente.CPF));
//            parms.Add(new MySqlParameter("ds_endereco", cliente.Endereco));
//            parms.Add(new MySqlParameter("nm_local", cliente.Local));
//            parms.Add(new MySqlParameter("ds_cidade", cliente.Cidade));
//            parms.Add(new MySqlParameter("int_cep", cliente.CEP));
//            parms.Add(new MySqlParameter("ds_email", cliente.Email));
//            parms.Add(new MySqlParameter("int_tel", cliente.Telefone));
//            parms.Add(new MySqlParameter("dt_nasc", cliente.DataNasc));
//            parms.Add(new MySqlParameter("dt_data_cadastro", cliente.DataCadastro));

//            Database db = new Database();
//        //    db.ExecuteInsertScript(script, parms);

//        //}

//        //public void Remover(int IdCliente)
//        //{

//        //    string script = @"DELETE FROM tb_cliente WHERE id_pessoa = @id_pessoa";

//        //    List<MySqlParameter> parms = new List<MySqlParameter>();
//        //    parms.Add(new MySqlParameter("id_pessoa", IdCliente));

//        //    Database db = new Database();
//        //    db.ExecuteInsertScript(script, parms);

//        //}





//    }
//}
