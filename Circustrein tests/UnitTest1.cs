using System.Collections.Generic;
using NUnit.Framework;
using Circustrein;
using Circustrein.Enums;
using Circustrein.Models;

namespace Circustrein_tests
{
    [TestFixture]
    public class Tests
    {
        CircusTrain circusTrain = new CircusTrain();

        [Test]
        public void EasyTests()
        {
            Assert.AreEqual(new List<Wagon>()
            {
                new Wagon(new Animal(AnimalSize.Large, AnimalEater.MeatEater)),
                new Wagon(new Animal(AnimalSize.Large, AnimalEater.MeatEater))
            },circusTrain.GetWagons(new List<Animal>()
            {
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.MeatEater)
            }));
        }

        [Test]
        public void HardTest()
        {
            Assert.AreEqual(new List<Wagon>()
                {
                    new Wagon(new Animal(AnimalSize.Large, AnimalEater.MeatEater)),
                    new Wagon(new Animal(AnimalSize.Large, AnimalEater.MeatEater)),
                    new Wagon(new List<Animal>(){new Animal(AnimalSize.Medium, AnimalEater.MeatEater), new Animal(AnimalSize.Large, AnimalEater.Herbivore)}),
                    new Wagon(new List<Animal>(){new Animal(AnimalSize.Small, AnimalEater.MeatEater), new Animal(AnimalSize.Medium, AnimalEater.Herbivore),new Animal(AnimalSize.Medium, AnimalEater.Herbivore),new Animal(AnimalSize.Medium, AnimalEater.Herbivore)}),
                    new Wagon(new List<Animal>(){new Animal(AnimalSize.Small, AnimalEater.MeatEater), new Animal(AnimalSize.Medium, AnimalEater.Herbivore),new Animal(AnimalSize.Medium, AnimalEater.Herbivore),new Animal(AnimalSize.Large, AnimalEater.Herbivore)}),
                    new Wagon(new List<Animal>(){new Animal(AnimalSize.Large,AnimalEater.Herbivore),new Animal(AnimalSize.Large,AnimalEater.Herbivore)}),
                    new Wagon(new List<Animal>(){new Animal(AnimalSize.Large,AnimalEater.Herbivore),new Animal(AnimalSize.Small,AnimalEater.Herbivore),new Animal(AnimalSize.Small,AnimalEater.Herbivore)})
                },
                circusTrain.GetWagons(new List<Animal>()
            {
                new Animal(AnimalSize.Large,AnimalEater.MeatEater),
                new Animal(AnimalSize.Large,AnimalEater.MeatEater),
                new Animal(AnimalSize.Medium,AnimalEater.MeatEater),
                new Animal(AnimalSize.Small,AnimalEater.MeatEater),
                new Animal(AnimalSize.Small,AnimalEater.MeatEater),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium,AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium,AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium,AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium,AnimalEater.Herbivore),
                new Animal(AnimalSize.Medium,AnimalEater.Herbivore),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore),
                new Animal(AnimalSize.Large,AnimalEater.Herbivore)
            }));
        }
    }
}