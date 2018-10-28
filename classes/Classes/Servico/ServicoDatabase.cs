using Catiotro_s.classes.Base;
using Catiotro_s.classes.Classes.Servico;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Servicos
{
    public class ServicoDatabase
    {
        public int Salvar(ServicoDTO servico)
        {

            string script = @"INSERT INTO tb_servicos (id_animal,
	                                                  dt_duracao,
	                                                  ds_servico,
	                                                  ds_valor)  VALUES (
                                                      @id_animal,
	                                                  @dt_duracao,
	                                                  @ds_servico,
	                                                  @ds_valor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", servico.IdAnimal));
            parms.Add(new MySqlParameter("dt_duracao", servico.Data));
            parms.Add(new MySqlParameter("ds_servico", servico.Servico));
            parms.Add(new MySqlParameter("ds_valor", servico.Valor));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Remover(int Id)
        {
            string script ="DELETE FROM tb_servicos WHERE id_servico = @id_servico ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_servico", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ServicoView> Listar()
        {
            string script = @"SELECT * FROM vw_servico";
       
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ServicoView> lista = new List<ServicoView>();
            while (reader.Read())
            {
                ServicoView add = new ServicoView();
                add.Id = reader.GetInt32("id_servico");
                add.Animal = reader.GetString("nm_animal");
                add.Cliente = reader.GetString("nm_nome");
                add.Data = reader.GetString("dt_duracao");
                add.Servico = reader.GetString("ds_servico");
                add.Valor = reader.GetDecimal("ds_valor");

                lista.Add(add);
            }
            reader.Close();
            return lista;
        }

        public List<ServicoView> Consultar(string nome, string data)
        {
            string script = @"SELECT * FROM vw_servico WHERE nm_animal LIKE @nm_animal AND dt_duracao LIKE @ dt_duracao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_animal", nome + "%"));
            parms.Add(new MySqlParameter("dt_duracao", data + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ServicoView> lista = new List<ServicoView>();
            while (reader.Read())
            {
                ServicoView add = new ServicoView();
                add.Id = reader.GetInt32("id_servico");
                add.Animal = reader.GetString("nm_animal");
                add.Cliente = reader.GetString("nm_nome");
                add.Data = reader.GetString("dt_duracao");
                add.Servico = reader.GetString("ds_servico");
                add.Valor = reader.GetDecimal("ds_valor");

                lista.Add(add);
            }
            reader.Close();
            return lista;
        }
    }
}
