using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the clothes factory, what type of clothes would you like? Enter [S] for smart or [C] for casual");
            var input = Console.ReadLine();
            var clothesFactory = GetClothesFactory(input);

            Console.WriteLine("Here are your clothes:");
            Console.WriteLine($"Trousers: {clothesFactory.CreateTrouser().Name}");
            Console.WriteLine($"Shirt: {clothesFactory.CreateShirt().Name}");
            Console.WriteLine($"Hat: {clothesFactory.CreateHat().Name}");

            Console.ReadLine();
        }

        private static IClothesFactory GetClothesFactory(string clothesStyle)
        {
            return clothesStyle.ToLower() switch
            {
                "s" => new SmartClothesFactory(),
                "c" => new CasualClothesFactory(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
