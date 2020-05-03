using System.Collections.Generic;
using Circustrein.Library.Animal_Sorters;

namespace Circustrein.Library
{
    public class AnimalSorterLoader
    {
        private List<IAnimalSorter> sorters;

        public List<IAnimalSorter> ReturnSorters()
        {
            sorters = new List<IAnimalSorter>();
            sorters.Add(new MeatEaterSorter());
            sorters.Add(new HerbivoreSorter());
            return sorters;
        }
    }
}