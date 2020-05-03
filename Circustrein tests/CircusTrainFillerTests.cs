using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Circustrein.Library;
using Circustrein.Library.Enums;
using Circustrein.Library.Models;

namespace Circustrein_tests
{
    [TestFixture]
    public class CircusTrainFillerTests
    {
        private CircusTrainFiller filler;
        private Animal largeHerbivore = new Animal(AnimalSize.Large, AnimalEater.Herbivore);
        private Animal mediumHerbivore = new Animal(AnimalSize.Medium, AnimalEater.Herbivore);
        private Animal smallHerbivore = new Animal(AnimalSize.Small, AnimalEater.Herbivore);
        private Animal largeMeateater = new Animal(AnimalSize.Large, AnimalEater.MeatEater);
        private Animal mediumMeateater = new Animal(AnimalSize.Medium, AnimalEater.MeatEater);
        private Animal smallMeateater = new Animal(AnimalSize.Small, AnimalEater.MeatEater);

        [SetUp]
        public void Setup()
        {
            filler = new CircusTrainFiller();
        }

        [Test]
        public void WagonsRuleDoNotExceeds()
        {
            // Arrange
            List<Animal> animals = loadAnimalSet();

            // Act
            var wagons = filler.SortAnimalsInWagons(animals);

            bool meateaterDoesNotEatHerbivore = wagons.All(w =>
                WagonContainsMeateater(w) && IsThereSmallerHerbivore(w) == false ||
                WagonContainsMeateater(w) == false);
            bool maxPointsDoNotExceed = wagons.All(w => w.Points <= 10);

            // Assert
            Assert.IsTrue(meateaterDoesNotEatHerbivore);
            Assert.IsTrue(maxPointsDoNotExceed);
        }

        [Test]
        public void AnimalPressenceCheck()
        {
            // Arrange
            List<Animal> animals = loadAnimalSet();

            // Act
            var wagons = filler.SortAnimalsInWagons(animals);
            var animalsInWagons = wagons.SelectMany(w => w.GetAnimals()).ToList();

            bool allAnimalsAreInWagons = animals.Any(a => animalsInWagons.Contains(a));
            bool AllAnimalsInWagonsAreInList = animalsInWagons.Any(a => animals.Contains(a));

            // Assert
            Assert.IsTrue(allAnimalsAreInWagons);
            Assert.IsTrue(AllAnimalsInWagonsAreInList);
        }

        [Test]
        public void OptimalWagonQuantity()
        {
            // Arrange
            List<Animal> animals = loadAnimalSet();
            int totalWagonsExpected = 6;

            // Act
            var wagons = filler.SortAnimalsInWagons(animals);

            // Assert
            Assert.AreEqual(totalWagonsExpected, wagons.Count);
        }

        [Test]
        public void OptimalWagonQuantity_SwitchAnimals()
        {
            // Arrange
            List<Animal> animals = new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Medium, AnimalEater.MeatEater),
                new Animal(AnimalSize.Small, AnimalEater.MeatEater),
                new Animal(AnimalSize.Small, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
                new Animal(AnimalSize.Small, AnimalEater.Herbivore),
                new Animal(AnimalSize.Small, AnimalEater.Herbivore)
            };
            int expectedWagons = 7;

            // Act
            var wagons = filler.SortAnimalsInWagons(animals);

            // Assert
            Assert.AreEqual(expectedWagons, wagons.Count);
        }

        private List<Animal> loadAnimalSet()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(smallHerbivore);
            animals.Add(smallHerbivore);
            animals.Add(largeMeateater); 
            animals.Add(largeMeateater); 
            animals.Add(largeMeateater); 
            animals.Add(mediumMeateater);
            animals.Add(smallMeateater); 
            animals.Add(largeHerbivore); 
            return animals;
        }

        private bool WagonContainsMeateater(Wagon wagon)
        {
            return wagon.GetAnimals().Any(a => a.Eater == AnimalEater.MeatEater);
        }

        private bool IsThereSmallerHerbivore(Wagon wagon)
        {
            AnimalSize meateaterSize = wagon.GetMeatEaterSize();
            return wagon.GetAnimals().Any(a => a.Size < meateaterSize && a.Eater == AnimalEater.Herbivore);
        }
    }
}