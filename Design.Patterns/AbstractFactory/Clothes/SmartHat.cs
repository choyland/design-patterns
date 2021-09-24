using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Clothes
{
    public class SmartHat : IHat
    {
        public string Name => "Fedora";
    }
}