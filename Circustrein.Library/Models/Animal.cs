using Circustrein.Library.Enums;
using Newtonsoft.Json;

namespace Circustrein.Library.Models
{
    public class Animal
    {
        [JsonProperty] 
        public AnimalSize Size { get; }

        [JsonProperty] 
        public AnimalEater Eater { get; }

        [JsonProperty]
        public int Points { get; }

        [JsonProperty]
        public string Name { get; }

        public Animal(AnimalSize size, AnimalEater eater)
        {
            Size = size;
            Eater = eater;
            Points = (int) size;
            Name = GetName(size, eater);
        }

        private string GetName(AnimalSize size, AnimalEater eater)
        {
            string adjective = size == AnimalSize.Small ? "Kleine" : size == AnimalSize.Medium ? "Gemiddelde" : "Grote";

            string noun = eater == AnimalEater.MeatEater ? "vleeseter" : "planteneter";

            return $"{adjective} {noun}";
        }
    }
}
