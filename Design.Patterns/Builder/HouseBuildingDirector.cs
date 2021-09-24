namespace Builder
{
    public class HouseBuildingDirector
    {
        private readonly HouseBuilder _houseBuilder;

        public HouseBuildingDirector()
        {
            _houseBuilder = new HouseBuilder();
        }

        public House BuildTerracedHouse()
        {
            _houseBuilder.Reset();

            var terracedHouse = _houseBuilder
                .WithBuildingMaterial("Red Brick")
                .WithAcresOfLand(0.1)
                .WithNumberOfBedrooms(2)
                .Build();

            return terracedHouse;
        }

        public House BuildKitHouse()
        {
            _houseBuilder.Reset();

            var terracedHouse = _houseBuilder
                .WithBuildingMaterial("Wood")
                .WithAcresOfLand(1)
                .WithNumberOfBedrooms(3)
                .Build();

            return terracedHouse;
        }

        public House BuildMansion()
        {
            _houseBuilder.Reset();

            var terracedHouse = _houseBuilder
                .WithBuildingMaterial("White Brick")
                .WithAcresOfLand(400)
                .WithNumberOfBedrooms(20)
                .Build();

            return terracedHouse;
        }
    }
}
