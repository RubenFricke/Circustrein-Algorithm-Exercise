using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using Circustrein.Enums;

namespace Circustrein.Models
{
    public class CircusTrain
    {
        WagonDepartment wagonDepartment = new WagonDepartment();

        //dubbele lijst hier weghalen en dit in de form laten, dus dat hier alleen berekend 
        //wordt naar de optimale combinatie

        //wel de get all animals houden zodat met unit tests gebruikt kan worden
        // dus dit krijg je vanuit alle animals uit de verdeelde wagons
        private List<Animal> animals = new List<Animal>();

        public List<Animal> GetAllAnimals()
        {
            IList<Animal> list = animals.AsReadOnly(); 
            return animals;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void AddAnimal(List<Animal> animals)
        {
            animals.ForEach(a => this.animals.Add(a));
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public List<Wagon> GetWagons()
        {
            return wagonDepartment.GetBestWagonDistribution(animals);
        }

        public List<Wagon> GetWagons(List<Animal> animalList)
        {
            return wagonDepartment.GetBestWagonDistribution(animalList);
        }

        public void ClearAllAnimals()
        {
            animals.Clear();
        }
    }
}
