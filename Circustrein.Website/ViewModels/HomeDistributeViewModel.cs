using System.Collections.Generic;
using Circustrein.Library.Models;

namespace Circustrein.Website.ViewModels
{
    public class HomeDistributeViewModel
    {
        public HomeSetupViewModel Setup { get; set; }

        public List<Wagon> Wagons { get; set; }
    }
}