using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Clothes
{
    public class CasualShirt : IShirt
    {
        public string Name => "Adidas running shirt";
    }
}