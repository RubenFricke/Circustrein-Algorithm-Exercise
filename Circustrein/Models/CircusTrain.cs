using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Models
{
    class CircusTrain
    {
        private List<Animal> animals = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public IList<Animal> getAllAnimals()
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
    }
}
