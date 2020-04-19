using Abstractions.Enums;
using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class TypeItemInitializer
    {
        public static TypeItem[] Initialize()
        {
            return new TypeItem[]
            {
                new TypeItem{Id=1, Name="Кабинет", Code = (int)ItemType.Room},
                new TypeItem{Id=2, Name="Граница", Code = (int)ItemType.Border}
            };
        }
    }
}