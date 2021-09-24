using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Clothes
{
    public class CasualHat : IHat
    {
        public string Name => "Baseball cap";
    }
}