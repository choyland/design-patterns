using AbstractFactory.Clothes;
using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Factories
{
    public class CasualClothesFactory : IClothesFactory
    {
        public ITrouser CreateTrouser()
        {
            return new CasualTrouser();
        }

        public IShirt CreateShirt()
        {
            return new CasualShirt();
        }

        public IHat CreateHat()
        {
            return new CasualHat();
        }
    }
}