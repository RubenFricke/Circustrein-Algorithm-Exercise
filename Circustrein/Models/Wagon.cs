using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.Enums;

namespace Circustrein.Models
{
    class Wagon
    {
        //private const int maxPoints = 10;

        private bool hasMeatEater = false;
        private AnimalSize meatEaterSize;
        private int points = 0;
        //private bool isFull = false;
        List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            points += animal.GetPoints();
            //isFull = CheckFull();
            //isFull = points >= maxPoints;
            if (animal.GetEater() == AnimalEater.MeatEater)
            {
                hasMeatEater = true; meatEaterSize = animal.GetSize();
            }
        }

        //private bool CheckFull()
        //{
        //    if (points >= maxPoints) return true;
        //    else if (animals.Count(x => x.GetEater() == AnimalEater.MeatEater && x.GetSize() == AnimalSize.Large) >= 1)
        //        return true;
        //    //else if()
        //    return false;
        //}

        //public int GetPoints()
        //{
        //    return points;
        //}

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
    }
}
