using System.Collections.Generic;
using System.Linq;
using Circustrein.Library.Enums;
using Circustrein.Library.Models;

namespace Circustrein.Library.Animal_Sorters
{
    public class MeatEaterSorter : IAnimalSorter
    {
        public void SortAnimals(List<Animal> animals, CircusTrain train)
        {
            var meateaters = GetMeatEaters(animals);
            meateaters.ForEach(train.AddToNewWagon);
        }

        private List<Animal> GetMeatEaters(List<Animal> animals)
        {
            return animals.Where(a => a.Eater == AnimalEater.MeatEater).ToList();
        }
    }
}