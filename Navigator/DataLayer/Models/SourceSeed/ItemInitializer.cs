using System.Collections.Generic;
using System.Linq;
using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class ItemInitializer
    {
        public static Item[] Initialize(List<Node[]> nodes)
        {
            var levels = LevelInitializer.Initialize();
            var itemTypes = TypeItemInitializer.Initialize();
            //var nodes = NodeInitializer.Initialize();

            return new[]
            {
                // Граница 2 этажа
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[1],
                    Node = nodes[0].First(),
                    Repair = false
                },

                // Лестница Ж
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[1].First(),
                    Repair = false
                },

                // Лестница З [2]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[2].First(),
                    Repair = false
                },

                // Лестница И [3]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[3].First(),
                    Repair = false
                },

                // Лестница К-3 [4]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[4].First(),
                    Repair = false
                },

                // Лестница К-середина [5]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[5].First(),
                    Repair = false
                },

                // Лестница К [6]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[6].First(),
                    Repair = false
                },

                // Кабинет Ж-201 [7]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[7].First(),
                    Number = "Ж-201",
                    Description = "Описание",
                    Repair = false
                },

                // Кабинет К-204 [8]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[8].First(),
                    Number = "К-204",
                    Description = "204",
                    Repair = false
                },

                // Кабинет К-202 [9]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[9].First(),
                    Number = "К-202",
                    Description = "БИТ",
                    Repair = false
                },

                // Граница 1 этажа [10]
                new Item
                {
                    Level = levels[0],
                    TypeItem = itemTypes[1],
                    Node = nodes[10].First(),
                    Repair = false
                },

                // Кабинет К-102 [11]
                new Item
                {
                    Level = levels[0],
                    TypeItem = itemTypes[0],
                    Node = nodes[11].First(),
                    Number = "К-102",
                    Description = "Описание",
                    Repair = false
                },

                // Лестница К-середина [5]
                new Item
                {
                    Level = levels[0],
                    TypeItem = itemTypes[2],
                    Node = nodes[5].First(),
                    Repair = false
                },

                // Лестница Ж [1]
                new Item
                {
                    Level = levels[0],
                    TypeItem = itemTypes[2],
                    Node = nodes[1].First(),
                    Repair = false
                },
            };
        }
    }
}