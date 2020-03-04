using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    public class Wagon
    {
        private const int maxPoints = 10;

        MeatEaterInfo meatEaterInfo = new MeatEaterInfo(); 
        
        //struct maken? 
        //https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct
        //private bool hasMeatEater = false;
        
        //private AnimalSize meatEaterSize;
        private int points = 0;
        private bool isFull = false;
        List<Animal> animals = new List<Animal>();

        public Wagon() { }

        public Wagon(Animal animal)
        {
            //i/*nt.TryParse()*/
            AddAnimal(animal);
        }

        public Wagon(List<Animal> animals)
        {
            animals.ForEach(this.animals.Add);
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            if (animal.GetEater() == AnimalEater.MeatEater)
            {
                meatEaterInfo.SetMeatEaterSize(animal.GetSize());
                //hasMeatEater = true;
                //meatEaterSize = animal.GetSize();
            }
            UpdateStats();
        }

        private void UpdateStats()
        {
            points = animals.Sum(a => a.GetPoints());
            isFull = CheckFull();
        }

        private bool CheckFull()
        {
            if (/*hasMeatEater*/meatEaterInfo.HasMeatEater())
            {
                if (/*GetMeatEaterSize()*/meatEaterInfo.GetMeatEaterSize() == AnimalSize.Large) return true;
                else if (meatEaterInfo.GetMeatEaterSize() == AnimalSize.Medium && points >= maxPoints - (int)meatEaterInfo.GetMeatEaterSize()) return true;
                else if (meatEaterInfo.GetMeatEaterSize() == AnimalSize.Small && points >= maxPoints - (int) meatEaterInfo.GetMeatEaterSize()) return true;
            }
            else if (points >= maxPoints) return true;
            return false;
        }

        public Animal SwitchAnimal(Animal animal)
        {
            var anim = animals.OrderBy(a => a.GetSize()).FirstOrDefault(a => a.GetEater() == AnimalEater.Herbivore);
            animals.Remove(anim);
            animals.Add(animal);
            UpdateStats();
            return anim;
        }

        public int GetPoints()
        {
            return points;
        }
        
        public bool HasSpaceFor(AnimalSize size)
        {
            return points + (int) size <= maxPoints;
        }

        public AnimalSize GetMeatEaterSize()
        {
            return meatEaterInfo.GetMeatEaterSize();
        }

        public IList<Animal> GetAnimals()
        {
            IList<Animal> list = animals.AsReadOnly();
            return list;
        }

        public bool IsWagonFull()
        {
            return isFull;
        }
    }
}
