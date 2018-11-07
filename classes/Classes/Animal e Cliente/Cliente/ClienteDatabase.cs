using Catiotro_s.classes.Base;
using Catiotro_s.classes.Classes.AddConsultar.Cliente;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
    public class ClienteDataBase
    {
        public int Salvar(ClienteDTO cliente)
        {

            string script = @"INSERT INTO tb_cliente(
                                           nm_nome,
                                           ds_email,
                                           ds_rg,
                                           ds_cpf,
                                           id_estado,
                                           ds_cidade,
                                           ds_cep,
                                           ds_rua,
                                           ds_numero,
                                           ds_complemento,
                                           ds_telefone,
                                           dt_nasc,
                                           dt_dataCadastro)                                           
                                    VALUES(@nm_nome,
                                           @ds_email,
                                           @ds_rg,
                                           @ds_cpf,
                                           @id_estado,
                                           @ds_cidade,
                                           @ds_cep,
                                           @ds_rua,
                                           @ds_numero,
                                           @ds_complemento,
                                           @ds_telefone,
                                           @dt_nasc,
                                           @dt_dataCadastro)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", cliente.Nome));
            parms.Add(new MySqlParameter("ds_cpf", cliente.Cpf));
            parms.Add(new MySqlParameter("ds_email", cliente.Email));
            parms.Add(new MySqlParameter("ds_rg", cliente.Rg));
            parms.Add(new MySqlParameter("id_estado", cliente.EstadoId));
            parms.Add(new MySqlParameter("ds_cidade", cliente.Cidade));
            parms.Add(new MySqlParameter("ds_cep", cliente.Cep));
            parms.Add(new MySqlParameter("ds_rua", cliente.Rua));
            parms.Add(new MySqlParameter("ds_numero", cliente.Numero));
            parms.Add(new MySqlParameter("ds_complemento", cliente.Complemento));
            parms.Add(new MySqlParameter("ds_telefone", cliente.Telefone));
            parms.Add(new MySqlParameter("dt_nasc", cliente.DataNascimento));
            parms.Add(new MySqlParameter("dt_dataCadastro", cliente.DataCadastro));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(ClienteDTO cliente)
        {

            string script = @"UPDATE tb_cliente SET nm_nome = @nm_nome,
                                                    ds_cpf = @ds_cpf,
                                                    ds_email = @ds_email,
                                                    ds_rg = @ds_rg,
                                                    id_estado = @id_estado,
                                                    ds_cidade  = @ds_cidade,
                                                    ds_cep = @ds_cep,
                                                    ds_rua = @ds_rua,
                                                    ds_numero = @ds_numero,
                                                    ds_complemento = @ds_complemento, 
                                                    ds_email = @ds_email,
                                                    ds_telefone = @ds_telefone,
                                                    dt_nasc = @dt_nasc,
                                                    dt_dataCadastro = @dt_dataCadastro,
                                              WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", cliente.id));
            parms.Add(new MySqlParameter("nm_nome", cliente.Nome));
            parms.Add(new MySqlParameter("ds_cpf", cliente.Cpf));
            parms.Add(new MySqlParameter("ds_email", cliente.Email));
            parms.Add(new MySqlParameter("ds_rg", cliente.Rg));
            parms.Add(new MySqlParameter("id_estado", cliente.EstadoId));
            parms.Add(new MySqlParameter("ds_cidade", cliente.Cidade));
            parms.Add(new MySqlParameter("ds_cep", cliente.Cep));
            parms.Add(new MySqlParameter("ds_rua", cliente.Rua));
            parms.Add(new MySqlParameter("ds_numero", cliente.Numero));
            parms.Add(new MySqlParameter("ds_complemento", cliente.Complemento));
            parms.Add(new MySqlParameter("ds_telefone", cliente.Telefone));
            parms.Add(new MySqlParameter("dt_nasc", cliente.DataNascimento));
            parms.Add(new MySqlParameter("dt_dataCadastro", cliente.DataCadastro));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int IdCliente)
        {

            string script = @"DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", IdCliente));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<ClienteView> Listar()
        {
            string script = @"SELECT * FROM vw_consultarCliente";


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ClienteView> lista = new List<ClienteView>();
            while (reader.Read())
            {
                ClienteView dto = new ClienteView();
                dto.id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_nome");
                dto.Email = reader.GetString("ds_email");
                dto.Rg = reader.GetString("ds_rg");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Estado = reader.GetString("nm_estado");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.Cep = reader.GetString("ds_cep");
                dto.Rua = reader.GetString("ds_rua");
                dto.Numero = reader.GetInt32("ds_numero");
                dto.Complemento = reader.GetString("ds_complemento");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.DataNascimento = reader.GetString("dt_nasc");
                dto.DataCadastro = reader.GetString("dt_dataCadastro");
                

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ClienteDTO> ListarPraCombo()
        {
            string script = @"SELECT * FROM tb_cliente";


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_nome");
                dto.Email = reader.GetString("ds_email");
                dto.Rg = reader.GetString("ds_rg");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.EstadoId = reader.GetInt32("id_estado");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.Cep = reader.GetString("ds_cep");
                dto.Rua = reader.GetString("ds_rua");
                dto.Numero = reader.GetInt32("ds_numero");
                dto.Complemento = reader.GetString("ds_complemento");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.DataNascimento = reader.GetString("dt_nasc");
                dto.DataCadastro = reader.GetString("dt_dataCadastro");
                dto.Imagem = reader.GetString("img_cliente");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ClienteView> Consultar(string nome, string cpf)
        {
            string script = @"SELECT * FROM vw_consultarCliente WHERE nm_nome LIKE @nm_nome AND ds_cpf LIKE @ds_cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", nome + "%"));
            parms.Add(new MySqlParameter("ds_cpf", cpf + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteView> lista = new List<ClienteView>();
            while (reader.Read())
            {
                ClienteView dto = new ClienteView();
                dto.id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_nome");
                dto.Email = reader.GetString("ds_email");
                dto.Rg = reader.GetString("ds_rg");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Estado = reader.GetString("nm_estado");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.Cep = reader.GetString("ds_cep");
                dto.Rua = reader.GetString("ds_rua");
                dto.Numero = reader.GetInt32("ds_numero");
                dto.Complemento = reader.GetString("ds_complemento");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.DataNascimento = reader.GetString("dt_nasc");
                dto.DataCadastro = reader.GetString("dt_dataCadastro");
                dto.Imagem = reader.GetString("img_cliente");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
    }
}
