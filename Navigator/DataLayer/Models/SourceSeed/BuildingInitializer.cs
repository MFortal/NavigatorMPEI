using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class BuildingInitializer
    {
        public static Building[] Initialize()
        {
            return new Building[]
            {
                new Building{Name="testingField"}
            };
        }
    }
}