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

                // [12]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[12].First(),
                    Number = "К-204a",
                    Description = "Кафедра БИТ",
                    Repair = false
                },

                // [13]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[13].First(),
                    Number = "К-201",
                    Description = "Кафедра БИТ",
                    Repair = false
                },
                                
                // [14]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[14].First(),
                    Number = "К-203",
                    Description = "Кафедра БИТ",
                    Repair = false
                },
                                
                // [15]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[15].First(),
                    Repair = false
                },

                // [16]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[16].First(),
                    Repair = false
                },
                
                // [17]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[17].First(),
                    Repair = false
                },

                 // [18]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[5],
                    Node = nodes[18].First(),
                    Number = "Туалет (М)",
                    Repair = false
                },

                 // [19]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[4],
                    Node = nodes[19].First(),
                    Number = "Туалет (Ж)",
                    Repair = false
                },

                // [20]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[20].First(),
                    Repair = false
                },

                //-----------------------------------------
               // Кабинет К-2 [21]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[21].First(),
                    Number = "К-205",
                    Description = "Описание",
                    Repair = false
                },

                // Кабинет К-2 [22]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[22].First(),
                    Number = "К-206",
                    Description = "Описание",
                    Repair = false
                },

                // Кабинет К-2 [23]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[23].First(),
                    Number = "К-223",
                    Description = "Описание",
                    Repair = false
                },

                // Лестницп К-2 [24]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[24].First(),
                    Repair = false
                },

                // Кабинет К-2 [25]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[25].First(),
                    Number = "К-225",
                    Description = "Описание",
                    Repair = false
                },

                // Касса К-2 [26]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[3],
                    Node = nodes[26].First(),
                    Number = "Касса",
                    Repair = false
                },

                // Кабинет К-2 [27]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[27].First(),
                    Number = "К-227",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [28]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[28].First(),
                    Number = "К-228",
                    Description = "Описание",
                    Repair = false
                },

                // Кабинет К-2 [29]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[29].First(),
                    Number = "К-229",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [30]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[30].First(),
                    Number = "К-230",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [31]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[31].First(),
                    Number = "К-231",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [32]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[32].First(),
                    Number = "К-232",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [33]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[33].First(),
                    Number = "К-233",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [34]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[34].First(),
                    Number = "К-234",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [35]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[35].First(),
                    Number = "К-235",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [36]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[36].First(),
                    Number = "К-236",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [37]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[37].First(),
                    Number = "К-237",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [38]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[38].First(),
                    Number = "К-238",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [39]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[39].First(),
                    Number = "К-239",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [40]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[40].First(),
                    Number = "К-240",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [41]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[41].First(),
                    Number = "К-241",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [42]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[42].First(),
                    Number = "К-242",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [43]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[43].First(),
                    Number = "К-243",
                    Description = "Описание",
                    Repair = false
                },
                                
                // Кабинет К-2 [44]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[44].First(),
                    Number = "К-244",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [45]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[45].First(),
                    Number = "К-245",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [46]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[46].First(),
                    Number = "К-246",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [47]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[47].First(),
                    Number = "К-247",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [48]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[48].First(),
                    Number = "К-248",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [49]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[49].First(),
                    Number = "К-249",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [50]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[50].First(),
                    Number = "К-250",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [52]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[52].First(),
                    Number = "К-252",
                    Description = "Описание",
                    Repair = false
                },
                
                // Туалет Ж К-2 [53]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[4],
                    Node = nodes[53].First(),
                    Repair = false
                },
                
                // Кабинет К-2 [54]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[54].First(),
                    Number = "К-254",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [55]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[55].First(),
                    Number = "К-255",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [56]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[56].First(),
                    Number = "К-256",
                    Description = "Описание",
                    Repair = false
                },
                
                // Стена [57]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[57].First(),
                    Repair = false
                },
                
                // Стена К-2 [58]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[58].First(),
                    Repair = false
                },
                
                // Стена К-2 [59]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[9],
                    Node = nodes[59].First(),
                    Repair = false
                },
                
                // Лестница К-2 [60]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[60].First(),
                    Repair = false
                },
                
                // Кабинет К-2 [61]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[61].First(),
                    Number = "Ж-200",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [62]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[62].First(),
                    Number = "Ж-202",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [63]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[63].First(),
                    Number = "Ж-203",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [64]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[64].First(),
                    Number = "Ж-204",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [65]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[43].First(),
                    Number = "Ж-205",
                    Description = "Описание",
                    Repair = false
                },

                // Кабинет К-2 [66]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[66].First(),
                    Number = "Ж-206",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [67]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[67].First(),
                    Number = "Ж-207",
                    Description = "Описание",
                    Repair = false
                },               
                
                // Кабинет К-2 [68]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[68].First(),
                    Number = "Ж-208",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [69]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[69].First(),
                    Number = "И-209",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [70]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[70].First(),
                    Number = "И-202",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [71]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[71].First(),
                    Number = "И-203",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [72]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[72].First(),
                    Number = "И-204",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [73]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[73].First(),
                    Number = "И-205",
                    Description = "Описание",
                    Repair = false
                },               
                
                // Кабинет К-2 [74]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[74].First(),
                    Number = "И-206",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [75]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[75].First(),
                    Number = "И-207",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [76]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[76].First(),
                    Number = "И-208",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [77]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[77].First(),
                    Number = "И-209",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [78]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[78].First(),
                    Number = "И-210",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [79]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[79].First(),
                    Number = "И-211",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [80]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[80].First(),
                    Number = "И-212",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [81]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[81].First(),
                    Number = "И-213",
                    Description = "Описание",
                    Repair = false
                },               
                
                // Кабинет К-2 [82]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[82].First(),
                    Number = "И-214",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [83]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[83].First(),
                    Number = "И-215",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [84]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[84].First(),
                    Number = "И-216",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [85]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[85].First(),
                    Number = "И-217",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [86]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[86].First(),
                    Number = "И-218",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [87]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[87].First(),
                    Number = "И-219",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Кабинет К-2 [88]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[88].First(),
                    Number = "И-220",
                    Description = "Описание",
                    Repair = false
                },
                
                // Кабинет К-2 [89]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[0],
                    Node = nodes[89].First(),
                    Number = "И-221",
                    Description = "Описание",
                    Repair = false
                },                
                
                // Лестница К-2 [90]
                new Item
                {
                    Level = levels[1],
                    TypeItem = itemTypes[2],
                    Node = nodes[90].First(),
                    Repair = false
                },
               
            };
        }
    }
}