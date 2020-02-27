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
            isFull = CheckFull();
            isFull = points >= maxPoints;
            hasMeatEater = animal.GetEater() == AnimalEater.MeatEater;
        }
        //check volheid, dus nog kijken naar medium vleeseter, kan dus alleen grote planteneter -> na 8 punten zie ie vol
        //zelfde met kleine vleeseter
        //misschien iets van formule voor te bedenken
        private bool CheckFull()
        {
            if (points >= maxPoints) return true;
            else if (animals.Count(x => x.GetEater() == AnimalEater.MeatEater && x.GetSize() == AnimalSize.Large) >= 1)
                return true;
            //else if()
            return false;
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

        public IList<Animal> GetAnimals()
        {
            IList<Animal> list = animals.AsReadOnly();
            return list;
        }
    }
}
