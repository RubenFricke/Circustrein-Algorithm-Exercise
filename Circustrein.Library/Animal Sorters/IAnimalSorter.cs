using System.Collections.Generic;
using Circustrein.Library.Models;

namespace Circustrein.Library.Animal_Sorters
{
    public interface IAnimalSorter
    {
        void SortAnimals(List<Animal> animals, CircusTrain train);
    }
}