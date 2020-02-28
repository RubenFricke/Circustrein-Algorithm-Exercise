using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    class WagonDepartment
    {
        private List<Wagon> wagons = new List<Wagon>();
        private List<Animal> notDistributedAnimals;

        public List<Wagon> GetBestWagonDistribution(List<Animal> animals)
        {
            notDistributedAnimals = new List<Animal>(animals);
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

            wagons
                .Where(wagon => wagon.isWagonFull() == false)
                .ToList()
                .ForEach(wagon =>
                {
                    while (wagon.isWagonFull() == false && notDistributedAnimals.Count(a => (int)a.GetSize() > (int)wagon.GetMeatEaterSize()) != 0)
                    {
                        var animal = notDistributedAnimals.Where(a => (int)a.GetSize() > (int)wagon.GetMeatEaterSize()).OrderBy(a => a.GetSize()).FirstOrDefault();
                        if ((int) wagon.GetMeatEaterSize() < (int) animal.GetSize())
                        {
                            notDistributedAnimals.Remove(animal);
                            wagon.AddAnimal(animal);
                        }
                    }

                    if (wagon.GetMeatEaterSize() == AnimalSize.Small && wagon.GetPoints() <= 7)
                    {
                        var animal = notDistributedAnimals.FirstOrDefault(a => a.GetSize() == AnimalSize.Medium);
                        if (animal != null)
                        {
                            notDistributedAnimals.Remove(animal);
                            notDistributedAnimals.Add(wagon.SwitchAnimal(animal));
                        }
                    }
                });

            Enumerable.Range(0, notDistributedAnimals.Count)
                .ToList()
                .ForEach(i => AddToWagonWithRoom(notDistributedAnimals[0]));
        }

        private void AddToWagonWithRoom(Animal animal)
        {
            var wagon = wagons
                .FirstOrDefault(w => w.HasSpaceFor(animal.GetSize()) && (int)animal.GetSize() > (int)w.GetMeatEaterSize());
            if (wagon != null)
            {
                wagon.AddAnimal(animal);
            }
            else AddNewWagon(animal);

            notDistributedAnimals.Remove(animal);
        }

        private void AddNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(animal);
            wagons.Add(wagon);
        }
    }
}
