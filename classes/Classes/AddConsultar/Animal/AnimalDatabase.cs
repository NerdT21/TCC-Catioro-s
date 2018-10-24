using Catiotro_s.classes.Base;
using Catiotro_s.classes.Classes.AddConsultar.Animal;
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
        public int Salvar(AnimalDTO animal)
        {

            string scrip =
            @"INSERT INTO tb_animal(
	                                nm_animal,
	                                ds_pelagem,
	                                dt_dataNasc,
	                                ds_raca,
	                                ds_sexo,
	                                id_cliente,
	                                ds_obs,
                                    ds_corPelagem)
                             VALUES(@nm_animal,
	                                @ds_pelagem,
	                                @dt_dataNasc,
	                                @ds_raca,
	                                @ds_sexo,
	                                @id_cliente,
	                                @ds_obs,
                                    @ds_corPelagem)";




            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_animal", animal.NomeAnimal));
            parms.Add(new MySqlParameter("ds_pelagem", animal.Pelagem));
            parms.Add(new MySqlParameter("dt_dataNasc", animal.DataNasc));
            parms.Add(new MySqlParameter("ds_raca", animal.Raca));
            parms.Add(new MySqlParameter("ds_sexo", animal.Sexo));
            parms.Add(new MySqlParameter("id_cliente", animal.IdCliente));
            parms.Add(new MySqlParameter("ds_obs", animal.Obs));
            parms.Add(new MySqlParameter("ds_corPelagem", animal.CorPelo));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(scrip, parms);
            return pk;
        }

        public void Alterar(AnimalDTO animal)
        {

            string script = @"UPDATE tb_animal SET nm_animal = @nm_animal,
	                                               ds_pelagem = @ds_pelagem,
	                                               dt_dataNasc = @dt_dataNasc,
                                                   ds_sexo = @ds_sexo,
	                                               id_cliente = @id_cliente,
	                                               ds_obs = @ds_obs,
                                                   ds_corPelagem = @ds_corPelagem
                                             WHERE id_animal = @id_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_animal", animal.NomeAnimal));
            parms.Add(new MySqlParameter("ds_pelagem", animal.Pelagem));
            parms.Add(new MySqlParameter("dt_dataNasc", animal.DataNasc));
            parms.Add(new MySqlParameter("ds_raca", animal.Raca));
            parms.Add(new MySqlParameter("ds_sexo", animal.Sexo));
            parms.Add(new MySqlParameter("id_cliente", animal.IdCliente));
            parms.Add(new MySqlParameter("ds_obs", animal.Obs));
            parms.Add(new MySqlParameter("ds_corPelagem", animal.CorPelo));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int idAnimal)
        {

            string script = @"DELETE FROM tb_animal WHERE id_animal = @id_animal";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_animal", idAnimal));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<AnimalView> Listar()
        {

            string script = @"SELECT * FROM vw_animal_nmcliente";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<AnimalView> animalL = new List<AnimalView>();
            while (reader.Read())
            {

                AnimalView animal = new AnimalView();
                animal.Id = reader.GetInt32("id_animal");
                animal.Nome = reader.GetString("nm_animal");
                animal.dsPelagem = reader.GetString("ds_pelagem");
                animal.dsCorPelagem = reader.GetString("ds_corPelagem");
                animal.DtDataNasc = reader.GetString("dt_dataNasc");
                animal.dsRaca = reader.GetString("ds_raca");
                animal.dsSexo = reader.GetString("ds_sexo");
                animal.IdCliente = reader.GetString("nm_nome");
                animal.dsObs = reader.GetString("ds_obs");

                animalL.Add(animal);

            }
            reader.Close();
            return animalL;
        }

        public List<AnimalView> Consultar(string nome, string nomeDono)
        {
            string script = @"SELECT * FROM vw_animal_nmcliente WHERE nm_animal LIKE @nm_animal AND nm_nome LIKE @nm_nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_animal", nome + "%"));
            parms.Add(new MySqlParameter("nm_nome", nomeDono + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<AnimalView> lista = new List<AnimalView>();
            while (reader.Read())
            {
                AnimalView animal = new AnimalView();
                animal.Id = reader.GetInt32("id_animal");
                animal.Nome = reader.GetString("nm_animal");
                animal.dsPelagem = reader.GetString("ds_pelagem");
                animal.dsCorPelagem = reader.GetString("ds_corPelagem");
                animal.DtDataNasc = reader.GetString("dt_dataNasc");
                animal.dsRaca = reader.GetString("ds_raca");
                animal.dsSexo = reader.GetString("ds_sexo");
                animal.IdCliente = reader.GetString("nm_nome");
                animal.dsObs = reader.GetString("ds_obs");

                lista.Add(animal);
            }

            reader.Close();
            return lista;
        }

    }
}

