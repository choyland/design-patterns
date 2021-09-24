namespace Builder
{
    public class HouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            _house = new House();
        }

        public HouseBuilder WithBuildingMaterial(string buildingMaterial)
        {
            _house.BuildingMaterial = buildingMaterial;
            return this;
        }

        public HouseBuilder WithNumberOfBedrooms(int numberOfRooms)
        {
            _house.NumberOfBedrooms = numberOfRooms;
            return this;
        }

        public HouseBuilder WithAcresOfLand(double acresOfLand)
        {
            _house.AcresOfLand = acresOfLand;
            return this;
        }

        public void Reset()
        {
            _house = new House();
        }

        public House Build()
        {
            return _house;
        }
    }
}
