using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
    public class ServicoDatabase
    {



        public int Salvar(ServicoDTO servico)
        {

            string script = @"INSERT INTO tb_servico(  id_animal,
                                                       dt_duracao,
                                                       ds_servico,
                                                       ds_valor) 
                                              VALUES (
                                                       @id_animal,
                                                       @dt_duracao,
                                                       @ds_servico,
                                                       @ds_valor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal",servico.IdAnimal));
            parms.Add(new MySqlParameter("dt_duracao", servico.Duracao));
            parms.Add(new MySqlParameter("ds_servico", servico.Servico));
            parms.Add(new MySqlParameter("ds_valor", servico.Valor));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(ServicoDTO servico)
        {

            string script = @"UPDATE tb_servico SET id_animal = @id_animal,
                                                     dt_duracao = @dt_duracao,
                                                     ds_servico = @ds_servico,
                                                     ds_valor = @ds_valor
                                              WHERE id_servico = @id_servico";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_servico",servico.Id));
            parms.Add(new MySqlParameter("id_animal", servico.IdAnimal));
            parms.Add(new MySqlParameter("dt_duracao", servico.Duracao));
            parms.Add(new MySqlParameter("ds_servico", servico.Servico));
            parms.Add(new MySqlParameter("ds_valor", servico.Valor));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE  FROM tb_servico WHERE id_servico = @id_servico";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_servico", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<ServicoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_servico";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ServicoDTO> lista = new List<ServicoDTO>();
            while (reader.Read())
            {

                ServicoDTO add = new ServicoDTO();
                add.Id = reader.GetInt32("id_servico");
                add.IdAnimal = reader.GetInt32("id_animal");
                add.Duracao = reader.GetString("dt_duracao");
                add.Servico = reader.GetString("ds_servico");
                add.Valor = reader.GetDecimal("ds_valor");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<ServicoDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_servico WHERE id_animal LIKE @id_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ServicoDTO> lista = new List<ServicoDTO>();
            while (reader.Read())
            {

                ServicoDTO add = new ServicoDTO();
                add.IdAnimal = reader.GetInt32("id_animal");


                lista.Add(add);
            }

            reader.Close();

            return lista;

        }





    }
}
