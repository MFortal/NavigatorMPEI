using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class LevelInitializer
    {
        public static Level[] Initialize()
        {
            var buildings = BuildingInitializer.Initialize();

            return new[]
            {
                new Level{/*Id=1,*/ Number= 1, Building = buildings[0]}
            };
        }
    }
}