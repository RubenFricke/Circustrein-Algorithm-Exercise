using System.Collections.Generic;
using System.Linq;
using Circustrein.Library.Enums;
using Circustrein.Library.Models;

namespace Circustrein.Library.Animal_Sorters
{
    public class HerbivoreSorter : IAnimalSorter
    {
        public void SortAnimals(List<Animal> animals, CircusTrain train)
        {
            var herbivores = GetHerbivores(animals);
            train.Wagons
                .Where(wagon => wagon.IsFull == false)
                .ToList()
                .ForEach(wagon =>
                {
                    while (wagon.IsFull == false && herbivores.OrderByDescending(a => a.Size).Count(a => (int)a.Size > (int)wagon.GetMeatEaterSize()) != 0)
                    {
                        var animal = herbivores.Where(a => (int)a.Size > (int)wagon.GetMeatEaterSize()).OrderBy(a => a.Size).FirstOrDefault();
                        if ((int)wagon.GetMeatEaterSize() < (int)animal.Size &&
                            wagon.Points + animal.Points <= Wagon.MaxPoints)
                        {
                            herbivores.Remove(animal);
                            wagon.AddAnimal(animal);
                        }
                        else break;
                    }

                    if (wagon.GetMeatEaterSize() == AnimalSize.Small && wagon.Points <= Wagon.MaxPoints - ((int)AnimalSize.Medium - (int)AnimalSize.Small))
                    {
                        var animal = herbivores.FirstOrDefault(a => a.Size == AnimalSize.Large && a.Eater == AnimalEater.Herbivore);
                        if (animal != null)
                        {
                            herbivores.Add(wagon.SwitchSmallToMediumAnimal(animal));
                            herbivores.Remove(animal);
                        }
                    }
                });
            FillRemainders(herbivores, train);
        }

        private void FillRemainders(List<Animal> remainders, CircusTrain train)
        {
            Enumerable.Range(0, remainders.Count)
                .ToList()
                .ForEach(i =>
                {
                    train.TryAddToWagonWithRoom(remainders[0]);
                    remainders.RemoveAt(0);
                });
        }

        private List<Animal> GetHerbivores(List<Animal> animals)
        {
            return animals.Where(a => a.Eater == AnimalEater.Herbivore).OrderByDescending(a => a.Size).ToList();
        }
    }
}