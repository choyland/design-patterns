using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Factories
{
    public interface IClothesFactory
    {
        ITrouser CreateTrouser();

        IShirt CreateShirt();

        IHat CreateHat();
    }
}