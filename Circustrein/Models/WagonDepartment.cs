using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    public class WagonDepartment
    {
        /// <summary>
        /// Hier nog alle magic numbers vervangen door variabelen die veranderd kunnen worden.
        /// </summary>
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
                .Where(wagon => wagon.IsWagonFull() == false)
                .ToList()
                .ForEach(wagon =>
                {
                    while (wagon.IsWagonFull() == false && notDistributedAnimals.OrderByDescending(a => a.GetSize()).Count(a => (int)a.GetSize() > (int)wagon.GetMeatEaterSize()) != 0)
                    {
                        var animal = notDistributedAnimals.OrderByDescending(a => a.GetSize()).Where(a => (int)a.GetSize() > (int)wagon.GetMeatEaterSize()).OrderBy(a => a.GetSize()).FirstOrDefault();
                        if ((int)wagon.GetMeatEaterSize() < (int)animal.GetSize() &&
                            wagon.GetPoints() + animal.GetPoints() <= 10)
                        {
                            notDistributedAnimals.Remove(animal);
                            wagon.AddAnimal(animal);
                        }
                        else break;
                    }

                    if (wagon.GetMeatEaterSize() == AnimalSize.Small && wagon.GetPoints() <= 7)
                    {
                        var animal = notDistributedAnimals.FirstOrDefault(a => a.GetSize() == AnimalSize.Large && a.GetEater() == AnimalEater.Herbivore);
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
