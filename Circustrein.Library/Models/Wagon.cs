using System;
using System.Collections.Generic;
using System.Linq;
using Circustrein.Library.Enums;

namespace Circustrein.Library.Models
{
    public class Wagon
    {
        public static int MaxPoints { get; set; } = 10;

        private MeatEaterInfo meatEaterInfo = new MeatEaterInfo();

        public int Points { get; private set; }

        public bool IsFull { get; private set; }

        List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            if (animal.Eater == AnimalEater.MeatEater)
            {
                meatEaterInfo.SetMeatEaterSize(animal.Size);
            }
            UpdateStats();
        }

        public Animal SwitchSmallToMediumAnimal(Animal animal)
        {
            var anim = animals.OrderBy(a => a.Size).FirstOrDefault(a => a.Eater == AnimalEater.Herbivore);
            animals.Remove(anim);
            animals.Add(animal);
            UpdateStats();
            return anim;
        }

        public bool HasSpaceFor(AnimalSize size)
        {
            return Points + (int) size <= MaxPoints;
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

        public static void SetMaxPoints(int points)
        {
            if(points < 0)
                throw new ArgumentException("Points for wagons should be positive values");
            MaxPoints = points;
        }
        private void UpdateStats()
        {
            Points = animals.Sum(a => a.Points);
            IsFull = CheckFull();
        }

        private bool CheckFull()
        {
            if (meatEaterInfo.HasMeatEater() && Points >= MaxPoints - (int) meatEaterInfo.GetMeatEaterSize())
                return true;
            else if (Points >= MaxPoints) return true;
            return false;
        }
    }
}