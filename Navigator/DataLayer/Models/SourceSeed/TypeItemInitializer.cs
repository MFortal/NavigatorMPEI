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
                new TypeItem{Name="Касса", Code = (int)ItemType.Cashbox},
                new TypeItem{Name="Туалет (Ж)", Code = (int)ItemType.WсWoman},
                new TypeItem{Name="Туалет (М)", Code = (int)ItemType.WcMan},
                new TypeItem{Name="Буфет", Code = (int)ItemType.Buffet},
                new TypeItem{Name="Автомат с едой", Code = (int)ItemType.SnackMachine},
                new TypeItem{Name="Банкомат", Code = (int)ItemType.CashMachine},
                new TypeItem{Name="Стена", Code = (int)ItemType.Wall}
            };
        }
    }
}