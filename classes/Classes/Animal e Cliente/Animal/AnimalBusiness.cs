using Catiotro_s.classes.Classes.AddConsultar.Animal;
using Catiotro_s.CustomException;
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
            //==================NOME=======================
            string nome = animal.NomeAnimal;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do animal não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do animal não pode estar vazio.");
            }

            //==============TipoPelagem===================
            string tipo = animal.Pelagem;
            tipo = tipo.Trim();
            int qtdTipo = tipo.Count();

            if (qtdTipo > 50)
            {
                throw new ValidacaoException("O tipo da palegam não pode passar de 50 caracteres.");
            }
            else if (qtdTipo == 0)
            {
                throw new ValidacaoException("O tipo da pelagem é obrigatório.");
            }

            //==============CorPelagem=====================
            string cor = animal.CorPelo;
            cor = cor.Trim();
            int qtdCor = cor.Count();

            if (qtdCor > 20)
            {
                throw new ValidacaoException("A cor da pelagem não pode passar de 20 caracteres.");
            }
            else if (qtdCor == 0)
            {
                throw new ValidacaoException("A cor da pelagem é obrigatória.");
            }

            //====================RAÇA========================
            string raca = animal.Raca;
            raca = raca.Trim();
            int qtdRaca = raca.Count();

            if (qtdRaca > 25)
            {
                throw new ValidacaoException("A raça não pode passar de 25 caracteres.");
            }
            else if (qtdRaca == 0)
            {
                throw new ValidacaoException("A raça é obrigatória.");
            }

            //=================SEXO===========================
            string sexo = animal.Sexo;
            sexo = sexo.Trim();

            if (sexo == string.Empty)
            {
                throw new ValidacaoException("Selecione um sexo para o animal.");
            }

            //================OBS============================
            string obs = animal.Obs;
            obs = obs.Trim();
            int qtdObs = obs.Count();

            if (qtdObs > 1000)
            {
                throw new ValidacaoException("O campo 'OBS' não pode passar der 1000 caracteres.");
            }
           

            AnimalDataBase DB = new AnimalDataBase();
            int id = DB.Salvar(animal);
            return id;
        }
        public void Alterar(AnimalDTO animal)
        {
            //==================NOME=======================
            string nome = animal.NomeAnimal;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do animal não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do animal não pode estar vazio.");
            }

            //==============TipoPelagem===================
            string tipo = animal.Pelagem;
            tipo = tipo.Trim();
            int qtdTipo = tipo.Count();

            if (qtdTipo > 50)
            {
                throw new ValidacaoException("O tipo da palegam não pode passar de 50 caracteres.");
            }
            else if (qtdTipo == 0)
            {
                throw new ValidacaoException("O tipo da pelagem é obrigatório.");
            }

            //==============CorPelagem=====================
            string cor = animal.CorPelo;
            cor = cor.Trim();
            int qtdCor = cor.Count();

            if (qtdCor > 20)
            {
                throw new ValidacaoException("A cor da pelagem não pode passar de 20 caracteres.");
            }
            else if (qtdCor == 0)
            {
                throw new ValidacaoException("A cor da pelagem é obrigatória.");
            }

            //====================RAÇA========================
            string raca = animal.Raca;
            raca = raca.Trim();
            int qtdRaca = raca.Count();

            if (qtdRaca > 25)
            {
                throw new ValidacaoException("A raça não pode passar de 25 caracteres.");
            }
            else if (qtdRaca == 0)
            {
                throw new ValidacaoException("A raça é obrigatória.");
            }

            //=================SEXO===========================
            string sexo = animal.Sexo;
            sexo = sexo.Trim();

            if (sexo == string.Empty)
            {
                throw new ValidacaoException("Selecione um sexo para o animal.");
            }

            //================OBS============================
            string obs = animal.Obs;
            obs = obs.Trim();
            int qtdObs = obs.Count();

            if (qtdObs > 1000)
            {
                throw new ValidacaoException("O campo 'OBS' não pode passar der 1000 caracteres.");
            }

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
