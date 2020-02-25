using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    class CircusTrain
    {
        private List<Animal> animals = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public IList<Animal> GetAllAnimals()
        {
            IList<Animal> list = animals.AsReadOnly(); 
            return list;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        private void calculateWagonDistribution()
        {

        }
    }
}
