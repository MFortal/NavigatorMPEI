using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class BuildingInitializer
    {
        public static Building[] Initialize()
        {
            return new[]
            {
                new Building { Name="К-З" }
            };
        }
    }
}