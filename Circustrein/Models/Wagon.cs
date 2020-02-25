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
        private const int maxPoints = 10;

        private bool hasMeatEater = false;
        private int points = 0;
        private bool isFull = false;
        List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            points += animal.GetPoints();
            isFull = points >= maxPoints;
            hasMeatEater = animal.GetEater() == AnimalEater.MeatEater;
        }

        public int GetPoints()
        {
            return points;
        }

        public bool HasMeatEater()
        {
            return hasMeatEater;
        }

        public bool IsFull()
        {
            return isFull;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}
