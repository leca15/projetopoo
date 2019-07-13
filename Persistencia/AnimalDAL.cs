using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class AnimalDAL
    {
        //private EFContext context;
        public List<Animal> TodosOsAnimais()
        {
            using (var context = new EFContext())
            {
                return context.Animals.ToList<Animal>();
            }
        } 

        public void GravarAnimal (Animal animal)
        {
            using (var context = new EFContext())
            {
                if (animal.AnimalID > 0) context.Entry(animal).State = EntityState.Modified;
                else
                    context.Animals.Add(animal);
                context.SaveChanges();
            }
        }

        public void Remover(long animalID)
        {
            using (var context = new EFContext())
            {
                var animal = context.Animals.Single(d => d.AnimalID == animalID);
                context.Animals.Remove(animal);
                context.SaveChanges();
            }
        }

        public List<Animal> BuscarAnimal(string cpf)
        {
            using (var context = new EFContext())
            {
                return context.Animals.Where<Animal>(animal => animal.CliCPF == cpf).ToList<Animal>();
            }
        }
    }
}
