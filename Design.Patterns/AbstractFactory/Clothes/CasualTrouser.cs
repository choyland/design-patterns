using AbstractFactory.Clothes.Interfaces;

namespace AbstractFactory.Clothes
{
    public class CasualTrouser : ITrouser
    {
        public string Name => "Nike joggers";
    }
}