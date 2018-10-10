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
        public List<AnimalDTO> Listar()
        {
            AnimalDataBase DB = new AnimalDataBase();
            List<AnimalDTO> animal = DB.Listar();
            return animal;
        }
    }
}
