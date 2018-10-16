using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Animal
{
    public class AnimalDTO
    {
        public int Id { get; set; }

        public string NomeAnimal { get; set; }

        public string Pelagem { get; set; }

        public string CorPelo { get; set; }

        public string DataNasc { get; set; }

        public string Pedigree { get; set; }

        public string Raca { get; set; }

        public string Sexo { get; set; }

        public int IdCliente { get; set; }

        public string Obs { get; set; }

        public int IdFichaAnimal { get; set; }
    }
}
