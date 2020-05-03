using System.Collections.Generic;
using System.Linq;

namespace Circustrein.Library.Models
{
    public class CircusTrain
    {
        public List<Wagon> Wagons { get; }

        public CircusTrain()
        {
            Wagons = new List<Wagon>();
        }

        public void AddToNewWagon(Animal animal)
        {
            var newWagon = new Wagon();
            newWagon.AddAnimal(animal);
            Wagons.Add(newWagon);
        }

        public void TryAddToWagonWithRoom(Animal animal)
        {
            var wagon = Wagons
                .FirstOrDefault(w => w.HasSpaceFor(animal.Size) && (int)animal.Size > (int)w.GetMeatEaterSize());
            if (wagon != null)
                wagon.AddAnimal(animal);
            else AddToNewWagon(animal);
        }
    }
}
