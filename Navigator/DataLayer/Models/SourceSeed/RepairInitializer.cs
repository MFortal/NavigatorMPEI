using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class RepairInitializer
    {
        public static Repair[] Initialize()
        {
            return new Repair[]
            {
                new Repair{Id=1, Name=0},
                new Repair{Id=2, Name=1}
            };
        }
    }
}