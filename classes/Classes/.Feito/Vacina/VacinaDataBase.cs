using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class VacinaDatabase
    {
        public int Salvar (VacinaDTO vacina)
        {

            string script = @"INSERT INTO tb_vacina(ds_tipo,
                                                    ds_prioridade,
                                                    ds_qtd_dose)
                                            VALUES (@ds_tipo,
                                                    @ds_prioridade,
                                                    @ds_qtd_dose)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_tipo", vacina.Tipo));
            parms.Add(new MySqlParameter("ds_prioridade", vacina.Prioridade));
            parms.Add(new MySqlParameter("ds_qtd_dose", vacina.QtdDose));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar (VacinaDTO vacina)
        {

            string script = @"UPDATE tb_vacina SET ds_tipo = @ds_tipo,
                                                    ds_prioridade = @ds_prioridade,
                                                    ds_qtd_dose = @ds_qtd_dose,
                                              WHERE id_vacina = @id_vacina";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_vacina",vacina.Id));
            parms.Add(new MySqlParameter("ds_tipo", vacina.Tipo));
            parms.Add(new MySqlParameter("ds_prioridade", vacina.Prioridade));
            parms.Add(new MySqlParameter("ds_qtd_dose", vacina.QtdDose));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover (int idVacina)
        {

            string script = @"DELETE FROM tb_vacina WHERE id_vacina = @id_vacina";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_vacina",idVacina));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<VacinaDTO> Listar()
        {

            string script = @"SELECT * FROM tb_vacina";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<VacinaDTO> vacinaL = new List<VacinaDTO>();
            while (reader.Read())
            {
                VacinaDTO vacina = new VacinaDTO();
                vacina.Id = reader.GetInt32("id_vacina");
                vacina.Tipo = reader.GetString("ds_tipo");
                vacina.Prioridade = reader.GetString("ds_prioridade");
                vacina.QtdDose = reader.GetString("ds_qtd_dose");

                vacinaL.Add(vacina);

            }

            reader.Close();

            return vacinaL;

        }

        public List<VacinaDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_vacina WHERE ds_tipo, ds_prioridade LIKE @ds_tipo, @ds_prioridade";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_tipo", nome + "%"));
            parms.Add(new MySqlParameter("ds_prioridade", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<VacinaDTO> vacinaL = new List<VacinaDTO>();
            while (reader.Read())
            {
                VacinaDTO vacina = new VacinaDTO();
                vacina.Id = reader.GetInt32("id_vacina");
                vacina.Tipo = reader.GetString("ds_tipo");
                vacina.Prioridade = reader.GetString("ds_prioridade");
                vacina.QtdDose = reader.GetString("ds_qtd_dose");

                vacinaL.Add(vacina);

            }

            reader.Close();

            return vacinaL;

        }


    }
}




//public List<ClienteDTO> Consultar(string nome)
//{
//    string script = @"SELECT * FROM tb_cliente WHERE nm_cliente LIKE @nm_cliente";

//    List<MySqlParameter> parms = new List<MySqlParameter>();
//    parms.Add(new MySqlParameter("nm_cliente", nome + "%"));

//    Database db = new Database();
//    MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

//    List<ClienteDTO> cliente = new List<ClienteDTO>();
//    while (reader.Read())
//    {
//        ClienteDTO DTO = new ClienteDTO();
//        DTO.Id = reader.GetInt32("id_cliente");
//        DTO.Nome = reader.GetString("nm_cliente");
//        DTO.Telefone = reader.GetString("ds_telefone");
//        DTO.Email = reader.GetString("ds_email");
//        DTO.CPF = reader.GetString("ds_cpf");
//        DTO.Cidade = reader.GetString("nm_cidade");
//        DTO.Estado = reader.GetString("nm_estado");

//        cliente.Add(DTO);
//    }
//    reader.Close();
//    return cliente;
//}








