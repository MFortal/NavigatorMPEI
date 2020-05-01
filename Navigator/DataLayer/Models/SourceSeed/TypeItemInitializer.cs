using Abstractions.Enums;
using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class TypeItemInitializer
    {
        public static TypeItem[] Initialize()
        {
            return new[]
            {
                new TypeItem{Name="Кабинет", Code = (int)ItemType.Room},
                new TypeItem{Name="Граница", Code = (int)ItemType.Border},
                new TypeItem{Name="Лестница", Code = (int)ItemType.Stairs},
            };
        }
    }
}