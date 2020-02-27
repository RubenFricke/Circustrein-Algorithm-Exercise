using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    class CircusTrain
    {
        WagonDepartment wagonDepartment = new WagonDepartment();
        private List<Animal> animals = new List<Animal>();

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

        public List<Wagon> GetWagons()
        {
            return wagonDepartment.GetBestWagonDistribution(animals);
        }
    }
}
