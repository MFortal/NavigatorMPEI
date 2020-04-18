using Navigator.Models.DataModels;

namespace Navigator.Models.SourceSeed
{
    public class BuildingInitializer
    {
        public static Building[] Initialize()
        {
            return new Building[]
            {
                new Building{Id=1, Name="testingField"}
            };
        }
    }
}