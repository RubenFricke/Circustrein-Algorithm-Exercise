using System;
using Circustrein.Library;
using Circustrein.Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Circustrein.Library.Enums;
using Circustrein.Website.ViewModels;

namespace Circustrein.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly CircusTrainFiller filler;
        public HomeController()
        {
            filler = new CircusTrainFiller();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DistributedWagons()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DistributedWagons(HomeDistributeViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    List<Animal> animalsToDistribute = new List<Animal>();
                    List<AnimalTotalPair> animalsToAdd = new List<AnimalTotalPair>
                    {
                        new AnimalTotalPair(new Animal(AnimalSize.Large, AnimalEater.MeatEater), model.Setup.TotalLargeMeateaters),
                        new AnimalTotalPair(new Animal(AnimalSize.Medium, AnimalEater.MeatEater), model.Setup.TotalMediumMeateaters),
                        new AnimalTotalPair(new Animal(AnimalSize.Small, AnimalEater.MeatEater), model.Setup.TotalSmallMeateaters),
                        new AnimalTotalPair(new Animal(AnimalSize.Large, AnimalEater.Herbivore), model.Setup.TotalLargeHerbivores),
                        new AnimalTotalPair(new Animal(AnimalSize.Medium, AnimalEater.Herbivore), model.Setup.TotalMediumHerbivores),
                        new AnimalTotalPair(new Animal(AnimalSize.Small, AnimalEater.Herbivore), model.Setup.TotalSmallHerbivores),
                    };

                    animalsToAdd.ForEach(a => animalsToDistribute.AddRange(AddXAnimalXTimes(a)));

                    var wagons = filler.SortAnimalsInWagons(animalsToDistribute);
                    return View(new HomeDistributeViewModel{Wagons = wagons});
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View();
        }

        private List<Animal> AddXAnimalXTimes(AnimalTotalPair model)
        {
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < model.Amount; i++)
            {
                animals.Add(model.Animal);
            }

            return animals;
        }
    }

    public class AnimalTotalPair
    {
        public Animal Animal { get; }
        public int Amount { get; }

        public AnimalTotalPair(Animal animal, int amount)
        {
            Animal = animal;
            Amount = amount;
        }
    }
}