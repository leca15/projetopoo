using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class AnimalServico
    {
        private AnimalDAL animalDAL = new AnimalDAL();
        public IList<Animal> TodosOsAnimais ()
        {
            return animalDAL.TodosOsAnimais();
        }

        public void GravarAnimal (Animal animal)
        {
            animalDAL.GravarAnimal(animal);
        }

        public void RemoverAnimal(long animalId)
        {
            animalDAL.Remover(animalId);
        }

        public List<Animal> BuscarAnimal(string cpf)
        {
            List<Animal> animals = animalDAL.BuscarAnimal(cpf);
            return animals;
        }
    }
}
