using System.Collections.Generic;
using System.Linq;
using Circustrein.Enums;

namespace Circustrein.Models
{
    public class Wagon
    {
        private static int MaxPoints= 10;

        MeatEaterInfo meatEaterInfo = new MeatEaterInfo(); 

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
                meatEaterInfo.SetMeatEaterSize(animal.GetSize());
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
            if (meatEaterInfo.HasMeatEater() && points >= MaxPoints - (int) meatEaterInfo.GetMeatEaterSize())
                return true;
            else if (points >= MaxPoints) return true;
            return false;
        }

        public Animal SwitchSmallToMediumAnimal(Animal animal)
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
            return points + (int) size <= MaxPoints;
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

        public static int GetMaxPoints()
        {
            return MaxPoints;
        }

        public static void SetMaxPoints(int points)
        {
            MaxPoints = points;
        }
    }
}