using Navigator.Models.DataModels;

namespace Navigator.Models.SourceSeed
{
    public class TypeItemInitializer
    {
        public static TypeItem[] Initialize()
        {
            return new TypeItem[]
            {
                new TypeItem{Id=1, Name="1"},
                new TypeItem{Id=2, Name="2"},
                new TypeItem{Id=3, Name="3"},
                new TypeItem{Id=4, Name="4"},
                new TypeItem{Id=5, Name="5"},
                new TypeItem{Id=6, Name="6"},
                new TypeItem{Id=7, Name="7"},
                new TypeItem{Id=8, Name="8"},
                new TypeItem{Id=9, Name="Стена"}
            };
        }
    }
}