using Catiotro_s.classes.Classes.AddConsultar.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Animal
{
    public class AnimalBusiness
    {
        public int Salvar(AnimalDTO animal)
        {
            AnimalDataBase DB = new AnimalDataBase();
            int id = DB.Salvar(animal);
            return id;
        }
        public void Alterar(AnimalDTO animal)
        {
            AnimalDataBase DB = new AnimalDataBase();
            DB.Alterar(animal);
        }
        public void Remover(int idanimal)
        {
            AnimalDataBase DB = new AnimalDataBase();
            DB.Remover(idanimal);
        }
        public List<AnimalView> Listar()
        {
            AnimalDataBase DB = new AnimalDataBase();
            List<AnimalView> animal = DB.Listar();
            return animal;
        }
        public List<AnimalView> Consultar(string nome, string nomeDono)
        {
            AnimalDataBase db = new AnimalDataBase();
            return db.Consultar(nome, nomeDono);
        }
    }
}
