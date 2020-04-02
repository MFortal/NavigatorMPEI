using Navigator.Models.DataModels;

namespace Navigator.Models.Sourceseed
{
    public class LevelsInitializer
    {
        public static Level[] Initialize()
        {
            return new Level[]
            {
                new Level{Id=1, Name=1},
                new Level{Id=2, Name=2}
            };
        }
    }
}