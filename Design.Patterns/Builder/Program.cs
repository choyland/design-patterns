using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, i'm in charge of building houses round here. What kind of house would you like to build? Enter [T] for terraced, [K] for a kit house or [M] for a mansion");
            var input = Console.ReadLine();
            var house = GetHouse(input);

            Console.WriteLine("Congrats, we've built your house!");
            Console.WriteLine($"It has been built using: {house.BuildingMaterial}");
            Console.WriteLine($"Has {house.NumberOfBedrooms} bedrooms");
            Console.WriteLine($"Has {house.AcresOfLand} acres of land");

            Console.ReadLine();
        }

        public static House GetHouse(string houseToBuild)
        {
            var houseBuildingDirector = new HouseBuildingDirector();

            return houseToBuild.ToLower() switch
            {
                "t" => houseBuildingDirector.BuildTerracedHouse(),
                "k" => houseBuildingDirector.BuildKitHouse(),
                "m" => houseBuildingDirector.BuildMansion(),
                _ => throw new ArgumentException()
            };
        }
    }
}
