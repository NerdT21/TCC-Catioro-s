using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Animal
{
    public class AnimalDataBase
    {
        public int Salvar (AnimalDTO animal)
        {

            string scrip =
            @"INSERT INTO tb_animal(nm_animal,
                                    ds_pelagem,
                                    ds_cor_da_pelagem,
                                    ds_data_nasc,
                                    ds_pedigree,
                                    id_raca,
                                    ds_sexo,
                                    id_cliente,
                                    ds_obs,
                                    id_ficha_animal)
                             VALUES(@nm_animal,
                                    @ds_pelagem,
                                    @ds_cor_da_pelagem,
                                    @ds_data_nasc,
                                    @ds_pedigree,
                                    @id_raca,
                                    @ds_sexo,
                                    @id_cliente,
                                    @ds_obs,
                                    @id_ficha_animal)";




            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_animal", animal.NomeAnimal));
            parms.Add(new MySqlParameter("ds_pelagem", animal.Pelagem));
            parms.Add(new MySqlParameter("ds_cor_da_pelagem", animal.CorPelo));
            parms.Add(new MySqlParameter("ds_data_nasc", animal.DataNasc));
            parms.Add(new MySqlParameter("ds_pedigree", animal.Pedigree));
            parms.Add(new MySqlParameter("id_raca", animal.IdRaca));
            parms.Add(new MySqlParameter("ds_sexo", animal.Sexo));
            parms.Add(new MySqlParameter("id_cliente", animal.IdCliente));
            parms.Add(new MySqlParameter("ds_obs", animal.Obs));
            parms.Add(new MySqlParameter("id_ficha_animal", animal.IdFichaAnimal));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(scrip, parms);
            return pk;
        }

        public void Alterar(AnimalDTO animal)
        {

            string script = @"UPDATE tb_animal SET nm_animal = @nm_animal,
                                                   ds_pelagem = @ds_pelagem,
                                                   ds_cor_da_pelagem = @ds_cor_da_pelagem,
                                                   ds_data_nasc = @ds_data_nasc,
                                                   ds_pedigree = @ds_pedigree,
                                                   id_raca = @id_raca,
                                                   ds_sexo = @ds_sexo,
                                                   id_cliente = @id_cliente,
                                                   ds_obs = @ds_obs,
                                                   id_ficha_animal = @id_ficha_animal,
                                             WHERE id_animal = @id_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", animal.Id));
            parms.Add(new MySqlParameter("nm_animal", animal.NomeAnimal));
            parms.Add(new MySqlParameter("ds_pelagem", animal.Pelagem));
            parms.Add(new MySqlParameter("ds_cor_da_pelagem", animal.CorPelo));
            parms.Add(new MySqlParameter("ds_data_nasc", animal.DataNasc));
            parms.Add(new MySqlParameter("ds_pedigree", animal.Pedigree));
            parms.Add(new MySqlParameter("id_raca",animal.IdRaca));
            parms.Add(new MySqlParameter("ds_sexo", animal.Sexo));
            parms.Add(new MySqlParameter("id_cliente", animal.IdCliente));
            parms.Add(new MySqlParameter("ds_obs", animal.Obs));
            parms.Add(new MySqlParameter("id_ficha_animal", animal.IdFichaAnimal));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int idAnimal)
        {

            string script = @"DELETE FROM tb_animal WHERE id_animal = @id_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_curso",idAnimal));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<AnimalDTO> Listar()
        {

            string script = @"SELECT * FROM tb_animal";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<AnimalDTO> animalL = new List<AnimalDTO>();
            while (reader.Read())
            {

                AnimalDTO animal = new AnimalDTO();
                    animal.Id = reader.GetInt32("id_animal");
                    animal.NomeAnimal = reader.GetString("nm_animal");
                    animal.Pelagem = reader.GetString("ds_pelagem");
                    animal.CorPelo = reader.GetString("ds_cor_da_pelagem");
                    animal.DataNasc = reader.GetString("ds_data_nasc");
                    animal.Pedigree = reader.GetString("ds_pedigree");
                    animal.IdRaca = reader.GetInt32("id_raca");
                    animal.Sexo = reader.GetString("ds_sexo");
                    animal.IdCliente = reader.GetInt32("id_cliente");
                    animal.Obs = reader.GetString("ds_obs");
                    animal.IdFichaAnimal = reader.GetInt32("id_ficha_animal");

                animalL.Add(animal);

            }

            reader.Close();

            return animalL;

        }

        public List<AnimalDTO> Consultar(string nome, string nomeDono)
        {
            string script = @"SELECT * FROM tb_animal WHERE nm_animal LIKE @nm_animal AND id_cliente LIKE @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_animal", nome + "%"));
            parms.Add(new MySqlParameter("id_cliente", nomeDono + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<AnimalDTO> lista = new List<AnimalDTO>();
            while (reader.Read())
            {

                AnimalDTO add = new AnimalDTO();
                add.NomeAnimal = reader.GetString("nm_animal");
                add.IdCliente = reader.GetInt32("id_cliente");

                lista.Add(add);
            }

            reader.Close();
            return lista;
        }

    }
}
                                   
