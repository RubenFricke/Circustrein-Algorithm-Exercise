using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.Enums;

namespace Circustrein.Models
{
    public class Wagon
    {
        //private const int maxPoints = 10;

        private bool hasMeatEater = false;
        private AnimalSize meatEaterSize;
        private int points = 0;
        private bool isFull = false;
        List<Animal> animals = new List<Animal>();

        public Wagon() { }

        public Wagon(Animal animal)
        {
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
                hasMeatEater = true;
                meatEaterSize = animal.GetSize();
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
            if (hasMeatEater)
            {
                if (GetMeatEaterSize() == AnimalSize.Large) return true;
                else if (GetMeatEaterSize() == AnimalSize.Medium && points >= 8) return true;
                else if (GetMeatEaterSize() == AnimalSize.Small && points >= 9) return true;
            }
            else if (points >= 10) return true;
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
            if (points + (int) size <= 10) return true;
            return false;
        }

        public AnimalSize GetMeatEaterSize()
        {
            return meatEaterSize;
        }

        public IList<Animal> GetAnimals()
        {
            IList<Animal> list = animals.AsReadOnly();
            return list;
        }

        public bool isWagonFull()
        {
            return isFull;
        }
    }
}
