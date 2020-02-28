using Circustrein.Enums;

namespace Circustrein.Models
{
    public class Animal
    {
        private AnimalSize size;
        private AnimalEater eater;
        private int points;

        public string Name { get; private set; }

        public Animal(AnimalSize size, AnimalEater eater)
        {
            this.size = size;
            this.eater = eater;
            points = (int) size;
            Name = (size == AnimalSize.Small ? "Kleine" : size == AnimalSize.Medium ? "Gemiddelde" : "Grote")
                + " " + (eater == AnimalEater.MeatEater ? "vleeseter" : "planteneter");
        }

        public AnimalSize GetSize()
        {
            return size;
        }

        public AnimalEater GetEater()
        {
            return eater;
        }

        public int GetPoints()
        {
            return points;
        }
    }
}
