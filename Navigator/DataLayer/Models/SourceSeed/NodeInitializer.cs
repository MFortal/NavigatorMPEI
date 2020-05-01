using System.Collections.Generic;
using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class NodeInitializer
    {
        public static List<Node[]> Initialize()
        {
            var result = new List<Node[]>();

            // Граница 2 этажа [0]
            result.Add(new[]
            {
                new Node() {X = 130, Y = 400},
                new Node() {X = 130, Y = 0},
                new Node() {X = 590, Y = 0},
                new Node() {X = 590, Y = 150},
                new Node() {X = 880, Y = 150},
                new Node() {X = 880, Y = 0},
                new Node() {X = 1320, Y = 0},
                new Node() {X = 1320, Y = 370},
                new Node() {X = 1230, Y = 370},
                new Node() {X = 1230, Y = 90},
                new Node() {X = 920, Y = 90},
                new Node() {X = 920, Y = 220},
                new Node() {X = 540, Y = 220},
                new Node() {X = 540, Y = 90},
                new Node() {X = 230, Y = 90},
                new Node() {X = 230, Y = 400},
            });

            // Лестница Ж [1]
            result.Add(new[]
            {
                new Node() { X = 210, Y = 80 },
                new Node() { X = 210, Y = 110 },
                new Node() { X = 230, Y = 110 },
                new Node() { X = 230, Y = 80 },
            });

            // Лестница З [2]
            result.Add(new[]
            {
                new Node() { X = 210, Y = 150 },
                new Node() { X = 230, Y = 150 },
                new Node() { X = 230, Y = 180 },
                new Node() { X = 210, Y = 180 },
            });

            // Лестница И [3]
            result.Add(new[]
            {
                new Node() { X = 710, Y = 190 },
                new Node() { X = 710, Y = 220 },
                new Node() { X = 760, Y = 220 },
                new Node() { X = 760, Y = 190 },
            });

            // Лестница К-3 [4]
            result.Add(new[]
            {
                new Node() { X = 900, Y = 150 },
                new Node() { X = 880, Y = 150 },
                new Node() { X = 880, Y = 130 },
                new Node() { X = 900, Y = 130 },
            });

            // Лестница К-середина [5]
            result.Add(new[]
            {
                new Node() { X = 1010, Y = 60 },
                new Node() { X = 1010, Y = 90 },
                new Node() { X = 1030, Y = 90 },
                new Node() { X = 1030, Y = 60 },
            });

            // Лестница К [6]
            result.Add(new[]
            {
                new Node() { X = 1250, Y = 90 },
                new Node() { X = 1230, Y = 90 },
                new Node() { X = 1230, Y = 190 },
                new Node() { X = 1250, Y = 190 },
            });

            // Кабинет Ж-201 [7]
            result.Add(new[]
            {
                new Node() { X = 240, Y = 60 },
                new Node() { X = 230, Y = 60 },
                new Node() { X = 290, Y = 90 },
                new Node() { X = 250, Y = 60 },
            });

            // Кабинет К-204 [8]
            result.Add(new[]
            {
                new Node() { X = 1270, Y = 40 },
                new Node() { X = 1230, Y = 40 },
                new Node() { X = 1230, Y = 0 },
                new Node() { X = 1280, Y = 0 },
                new Node() { X = 1280, Y = 40 },
            });

            // Кабинет К-202 [9]
            result.Add(new[]
            {
                new Node() { X = 1280, Y = 40 },
                new Node() { X = 1280, Y = 0 },
                new Node() { X = 1320, Y = 0 },
                new Node() { X = 1320, Y = 40 },
                new Node() { X = 1290, Y = 40 },
            });


            // Граница 1 этажа [10]
            result.Add(new[]
            {
                new Node() {X = 130, Y = 400},
                new Node() {X = 130, Y = 0},
                new Node() {X = 590, Y = 0},
                new Node() {X = 590, Y = 150},
                new Node() {X = 880, Y = 150},
                new Node() {X = 880, Y = 0},
                new Node() {X = 1320, Y = 0},
                new Node() {X = 1320, Y = 370},
                new Node() {X = 1230, Y = 370},
                new Node() {X = 1230, Y = 90},
                new Node() {X = 920, Y = 90},
                new Node() {X = 920, Y = 220},
                new Node() {X = 540, Y = 220},
                new Node() {X = 540, Y = 90},
                new Node() {X = 230, Y = 90},
                new Node() {X = 230, Y = 400},
            });

            // Кабинет К-102 [11]
            result.Add(new[]
            {
                new Node() {X = 1180, Y = 60},
                new Node() {X = 1190, Y = 60},
                new Node() {X = 1190, Y = 90},
                new Node() {X = 1150, Y = 90},
                new Node() {X = 1150, Y = 60},
                new Node() {X = 1170, Y = 60}
            });

            return result;
        }
    }
}