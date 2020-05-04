using System.ComponentModel.DataAnnotations;

namespace Circustrein.Website.ViewModels
{
    public class HomeSetupViewModel
    {
        [Range(0, 100,ErrorMessage = "Maximum 100 Large meateaters (and minimum 0)")]
        public int TotalLargeMeateaters { get; set; }

        [Range(0, 100, ErrorMessage = "Maximum 100 Medium meateaters (and minimum 0)")]
        public int TotalMediumMeateaters { get; set; }

        [Range(0, 100, ErrorMessage = "Maximum 100 Small meateaters (and minimum 0)")]
        public int TotalSmallMeateaters { get; set; }

        [Range(0, 100, ErrorMessage = "Maximum 100 Large herbivores (and minimum 0)")]
        public int TotalLargeHerbivores { get; set; }

        [Range(0, 100, ErrorMessage = "Maximum 100 Medium herbivores (and minimum 0)")]
        public int TotalMediumHerbivores { get; set; }

        [Range(0, 100, ErrorMessage = "Maximum 100 Small herbivores (and minimum 0)")]
        public int TotalSmallHerbivores { get; set; }

    }
}