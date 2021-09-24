using AbstractFactory.Clothes;
using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Factories
{
    public class SmartClothesFactory : IClothesFactory
    {
        public ITrouser CreateTrouser()
        {
            return new SmartTrouser();
        }

        public IShirt CreateShirt()
        {
            return new SmartShirt();
        }

        public IHat CreateHat()
        {
            return new SmartHat();
        }
    }
}