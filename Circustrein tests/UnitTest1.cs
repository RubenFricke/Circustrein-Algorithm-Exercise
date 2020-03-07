using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Circustrein;
using Circustrein.Enums;
using Circustrein.Models;

namespace Circustrein_tests
{
    [TestFixture]
    public class Tests
    {
        readonly CircusTrain circusTrain = new CircusTrain();

        [Test]
        public void EasyTestsWagonCount()
        {
            Assert.AreEqual(3, circusTrain.GetWagons(new List<Animal>()
            {
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
            }).Count);

            Assert.AreEqual(3, circusTrain.GetWagons(new List<Animal>()
            {
                new Animal(AnimalSize.Small, AnimalEater.MeatEater),
                new Animal(AnimalSize.Small, AnimalEater.MeatEater),
                new Animal(AnimalSize.Small, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
            }).Count);

            Assert.AreEqual(4, circusTrain.GetWagons(new List<Animal>()
            {
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.MeatEater),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
                new Animal(AnimalSize.Large, AnimalEater.Herbivore),
            }).Count);
        }

        [Test]
        public void HardTestWagonCount()
        {
            Assert.AreEqual(7, circusTrain.GetWagons(new List<Animal>()
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
            }).Count);
        }

        //[Test]
        //public void AnimalPresenceCheck()
        //{
        //    Assert.AreEqual(3, circusTrain.GetWagons(new List<Animal>()
        //    {
        //        new Animal(AnimalSize.Large, AnimalEater.MeatEater),
        //        new Animal(AnimalSize.Large, AnimalEater.MeatEater),
        //        new Animal(AnimalSize.Medium, AnimalEater.Herbivore),
        //    });
        //}
    }
}