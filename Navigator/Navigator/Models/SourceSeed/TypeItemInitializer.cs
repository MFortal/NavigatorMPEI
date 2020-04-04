using Navigator.Models.DataModels;

namespace Navigator.Models.SourceSeed
{
    public class TypeItemInitializer
    {
        public static TypeItem[] Initialize()
        {
            return new TypeItem[]
            {
                new TypeItem{Id=1, Name="Кабинет"},
                new TypeItem{Id=2, Name="Граница"}
            };
        }
    }
}