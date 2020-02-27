using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    class WagonDepartment
    {
        private List<Wagon> wagons = new List<Wagon>();
        private List<Animal> notDistributedAnimals = new List<Animal>();

        public List<Wagon> GetBestWagonDistribution(List<Animal> animals)
        {
            this.notDistributedAnimals = new List<Animal>(animals);
            wagons.Clear();

            CalculateWagonDistribution();

            return wagons;
        }

        private void CalculateWagonDistribution()
        {
            notDistributedAnimals
                .Where(animal => animal.GetEater() == AnimalEater.MeatEater)
                .ToList()
                .ForEach(animal =>
                {
                    notDistributedAnimals.Remove(animal);
                    AddNewWagon(animal);
                });
        }

        private void AddNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(animal);
            wagons.Add(wagon);
        }
    }
}
