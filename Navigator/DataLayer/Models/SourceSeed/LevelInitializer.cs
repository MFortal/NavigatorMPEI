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
                new Level{Number = 1, Building = buildings[0]},
                new Level{Number = 2, Building = buildings[0]}
            };
        }
    }
}