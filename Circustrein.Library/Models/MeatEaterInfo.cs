using Circustrein.Library.Enums;

namespace Circustrein.Library.Models
{
    public struct MeatEaterInfo
    {
        private AnimalSize size;
        private bool hasMeatEater;

        public bool HasMeatEater()
        {
            return hasMeatEater;
        }

        public AnimalSize GetMeatEaterSize()
        {
            return size;
        }

        public void SetMeatEaterSize(AnimalSize size)
        {
            this.size = size;
            hasMeatEater = true;
        }
    }
}