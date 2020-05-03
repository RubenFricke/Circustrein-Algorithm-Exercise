using System.Collections.Generic;
using Circustrein.Library.Animal_Sorters;
using Circustrein.Library.Models;

namespace Circustrein.Library
{
    public class CircusTrainFiller
    {
        private readonly AnimalSorterLoader loader;
        private readonly List<IAnimalSorter> sorters;
        private CircusTrain train;

        public CircusTrainFiller()
        {
            loader = new AnimalSorterLoader();
            sorters = loader.ReturnSorters();
            train = new CircusTrain();
        }

        public List<Wagon> SortAnimalsInWagons(List<Animal> animalsToSort)
        {
            train.Wagons.Clear();
            foreach (var sorter in sorters)
            {
                sorter.SortAnimals(animalsToSort, train);
            }

            return train.Wagons;
        }
    }
}