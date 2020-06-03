using System;
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
                new Node() {X = 130, Y = 400},
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
                new Node() { X = 1230, Y = 110 },
                new Node() { X = 1250, Y = 110 },
            });

            // Кабинет Ж-201 [7]
            result.Add(new[]
            {
                new Node() { X = 240, Y = 60 },
                new Node() { X = 230, Y = 60 },
                new Node() { X = 230, Y = 90 },
                new Node() { X = 250, Y = 90 },
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
                new Node() {X = 130, Y = 400},
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


            // 2 этаж К
            // Кабинет на кафедре [12]
            result.Add(new[]
            {
                new Node() {X = 1290, Y = 40},
                new Node() {X = 1320, Y = 40},
                new Node() {X = 1320, Y = 50},
                new Node() {X = 1290, Y = 50}
            });

            // Кабинет на кафедре [13]
            result.Add(new[]
            {
                new Node() {X = 1290, Y = 50},
                new Node() {X = 1320, Y = 50},
                new Node() {X = 1320, Y = 70},
                new Node() {X = 1290, Y = 70},
                new Node() {X = 1290, Y = 60}
            });

            // Кабинет на кафедре [14]
            result.Add(new[]
            {
                new Node() {X = 1280, Y = 70},
                new Node() {X = 1320, Y = 70},
                new Node() {X = 1320, Y = 90},
                new Node() {X = 1270, Y = 90},
                new Node() {X = 1270, Y = 70}
            });

            // Стена [15]
            result.Add(new[]
            {
                new Node() {X = 1270, Y = 90},
                new Node() {X = 1260, Y = 90}
            });

            // Стена [16]
            result.Add(new[]
            {
                new Node() {X = 1270, Y = 70},
                new Node() {X = 1260, Y = 70},
                new Node() {X = 1260, Y = 60}
            });

            // Стена [17]
            result.Add(new[]
            {
                new Node() {X = 1260, Y = 40},
                new Node() {X = 1260, Y = 50}
            });

            // Туалет м [18]
            result.Add(new[]
            {
                new Node() {X = 1220, Y = 60},
                new Node() {X = 1230, Y = 60},
                new Node() {X = 1230, Y = 90},
                new Node() {X = 1210, Y = 90},
                new Node() {X = 1210, Y = 60}
            });

            // Туалет ж [19]
            result.Add(new[]
            {
                new Node() {X = 1200, Y = 60},
                new Node() {X = 1210, Y = 60},
                new Node() {X = 1210, Y = 90},
                new Node() {X = 1190, Y = 90},
                new Node() {X = 1190, Y = 60}
            });

            // Стена [20]
            result.Add(new[]
            {
                new Node() {X = 1320, Y = 110},
                new Node() {X = 1230, Y = 110}
            });

            //--------------------------------------------------
            // Кабинет [21]
            result.Add(new[]
            {
                new Node() {X = 1180, Y = 60},
                new Node() {X = 1190, Y = 60},
                new Node() {X = 1190, Y = 90},
                new Node() {X = 1150, Y = 90},
                new Node() {X = 1150, Y = 60},
                new Node() {X = 1170, Y = 60},
            });

            // Кабинет [22]
            result.Add(new[]
            {
                new Node() {X = 1110, Y = 60},
                new Node() {X = 1150, Y = 60},
                new Node() {X = 1150, Y = 90},
                new Node() {X = 1080, Y = 90},
                new Node() {X = 1080, Y = 60},
                new Node() {X = 1100, Y = 60},
            });

            // Кабинет [23]
            result.Add(new[]
            {
                new Node() {X = 1070, Y = 60},
                new Node() {X = 1080, Y = 60},
                new Node() {X = 1080, Y = 90},
                new Node() {X = 1030, Y = 90},
                new Node() {X = 1030, Y = 60},
                new Node() {X = 1060, Y = 60},
            });

            // Лестница [24]
            result.Add(new[]
            {
                new Node() {X = 1030, Y = 60},
                new Node() {X = 1030, Y = 90},
                new Node() {X = 1010, Y = 90},
                new Node() {X = 1010, Y = 90},
            });

            // Кабинет [25]
            result.Add(new[]
            {
                new Node() {X = 1000, Y = 60},
                new Node() {X = 1010, Y = 60},
                new Node() {X = 1010, Y = 90},
                new Node() {X = 970, Y = 90},
                new Node() {X = 970, Y = 60},
                new Node() {X = 990, Y = 60},
            });

            // Касса [26]
            result.Add(new[]
            {
                new Node() {X = 950, Y = 70},
                new Node() {X = 950, Y = 60},
                new Node() {X = 970, Y = 60},
                new Node() {X = 970, Y = 90},
                new Node() {X = 950, Y = 90},
                new Node() {X = 950, Y = 80},
            });

            // Кабинет [27]
            result.Add(new[]
            {
                new Node() {X = 1220, Y = 40},
                new Node() {X = 1200, Y = 40},
                new Node() {X = 1200, Y = 0},
                new Node() {X = 1230, Y = 0},
                new Node() {X = 1230, Y = 40},
            });

            // Кабинет [28]
            result.Add(new[]
            {
                new Node() {X = 1190, Y = 40},
                new Node() {X = 1170, Y = 40},
                new Node() {X = 1170, Y = 0},
                new Node() {X = 1200, Y = 0},
                new Node() {X = 1200, Y = 40},
            });

            // Кабинет [29]
            result.Add(new[]
            {
                new Node() {X = 1160, Y = 40},
                new Node() {X = 1130, Y = 40},
                new Node() {X = 1130, Y = 0},
                new Node() {X = 1170, Y = 0},
                new Node() {X = 1170, Y = 40},
            });

            // Кабинет [30]
            result.Add(new[]
            {
                new Node() {X = 1120, Y = 40},
                new Node() {X = 1090, Y = 40},
                new Node() {X = 1090, Y = 0},
                new Node() {X = 1130, Y = 0},
                new Node() {X = 1130, Y = 40},
            });

            // Кабинет [31]
            result.Add(new[]
            {
                new Node() {X = 1170, Y = 40},
                new Node() {X = 1090, Y = 40},
                new Node() {X = 1090, Y = 0},
                new Node() {X = 1050, Y = 0},
                new Node() {X = 1050, Y = 40},
                new Node() {X = 1060, Y = 40},
            });

            // Кабинет [32]
            result.Add(new[]
            {
                new Node() {X = 1050, Y = 40},
                new Node() {X = 1050, Y = 0},
                new Node() {X = 1010, Y = 0},
                new Node() {X = 1010, Y = 40},
                new Node() {X = 1040, Y = 40},
            });

            // Кабинет [33]
            result.Add(new[]
            {
                new Node() {X = 1000, Y = 40},
                new Node() {X = 1010, Y = 40},
                new Node() {X = 1010, Y = 0},
                new Node() {X = 970, Y = 0},
                new Node() {X = 970, Y = 40},
                new Node() {X = 990, Y = 40},
            });

            // Кабинет [34]
            result.Add(new[]
            {
                new Node() {X = 940, Y = 40},
                new Node() {X = 970, Y = 40},
                new Node() {X = 970, Y = 0},
                new Node() {X = 930, Y = 0},
                new Node() {X = 930, Y = 40},
            });

            // Кабинет [35]
            result.Add(new[]
            {
                new Node() {X = 920, Y = 40},
                new Node() {X = 930, Y = 40},
                new Node() {X = 930, Y = 0},
                new Node() {X = 880, Y = 0},
                new Node() {X = 880, Y = 40},
                new Node() {X = 910, Y = 40},
            });


            // Кабинет [36]
            result.Add(new[]
            {
                new Node() {X = 900, Y = 40},
                new Node() {X = 880, Y = 40},
                new Node() {X = 880, Y = 70},
                new Node() {X = 900, Y = 70},
                new Node() {X = 900, Y = 50},
            });

            // Кабинет [37]
            result.Add(new[]
            {
                new Node() {X = 900, Y = 80},
                new Node() {X = 900, Y = 110},
                new Node() {X = 880, Y = 110},
                new Node() {X = 880, Y = 70},
                new Node() {X = 900, Y = 70},
            });

            // Кабинет [38]
            result.Add(new[]
            {
                new Node() {X = 900, Y = 120},
                new Node() {X = 900, Y = 110},
                new Node() {X = 880, Y = 110},
                new Node() {X = 880, Y = 130},
                new Node() {X = 900, Y = 130},
            });


            // Кабинет [39]
            result.Add(new[]
            {
                new Node() {X = 860, Y = 170},
                new Node() {X = 880, Y = 170},
                new Node() {X = 880, Y = 150},
                new Node() {X = 850, Y = 150},
                new Node() {X = 850, Y = 170},
            });

            // Кабинет [40]
            result.Add(new[]
            {
                new Node() {X = 860, Y = 170},
                new Node() {X = 880, Y = 170},
                new Node() {X = 880, Y = 150},
                new Node() {X = 850, Y = 150},
                new Node() {X = 850, Y = 170},
            });

            // Кабинет [41]
            result.Add(new[]
            {
                new Node() {X = 850, Y = 170},
                new Node() {X = 850, Y = 150},
                new Node() {X = 820, Y = 150},
                new Node() {X = 820, Y = 170},
                new Node() {X = 820, Y = 170},
                new Node() {X = 840, Y = 170},
            });

            // Кабинет [42]
            result.Add(new[]
            {
                new Node() {X = 810, Y = 170},
                new Node() {X = 780, Y = 170},
                new Node() {X = 780, Y = 150},
                new Node() {X = 820, Y = 150},
                new Node() {X = 820, Y = 170},
            });

            // Кабинет [43]
            result.Add(new[]
            {
                new Node() {X = 700, Y = 150},
                new Node() {X = 700, Y = 170},
                new Node() {X = 670, Y = 170},
                new Node() {X = 670, Y = 150},
                new Node() {X = 690, Y = 150},
            });


            // Кабинет [44]
            result.Add(new[]
            {
                new Node() {X = 660, Y = 170},
                new Node() {X = 670, Y = 170},
                new Node() {X = 670, Y = 150},
                new Node() {X = 620, Y = 150},
                new Node() {X = 620, Y = 170},
                new Node() {X = 650, Y = 170},
            });

            // Кабинет [45]
            result.Add(new[]
            {
                new Node() {X = 610, Y = 170},
                new Node() {X = 590, Y = 170},
                new Node() {X = 590, Y = 150},
                new Node() {X = 620, Y = 150},
                new Node() {X = 620, Y = 170},
            });

            // Туалет М [46]
            result.Add(new[]
            {
                new Node() {X = 910, Y = 190},
                new Node() {X = 920, Y = 190},
                new Node() {X = 920, Y = 220},
                new Node() {X = 910, Y = 220},
                new Node() {X = 890, Y = 220},
                new Node() {X = 890, Y = 190},
                new Node() {X = 900, Y = 190},
            });

            // Кабинет [47]
            result.Add(new[]
            {
                new Node() {X = 850, Y = 190},
                new Node() {X = 890, Y = 190},
                new Node() {X = 890, Y = 220},
                new Node() {X = 850, Y = 220},
                new Node() {X = 850, Y = 210},
            });

            // Кабинет [48]
            result.Add(new[]
            {
                new Node() {X = 850, Y = 200},
                new Node() {X = 850, Y = 190},
                new Node() {X = 800, Y = 190},
                new Node() {X = 800, Y = 220},
                new Node() {X = 850, Y = 220},
                new Node() {X = 850, Y = 210},
            });

            // Кабинет [49]
            result.Add(new[]
            {
                new Node() {X = 790, Y = 190},
                new Node() {X = 800, Y = 190},
                new Node() {X = 800, Y = 220},
                new Node() {X = 760, Y = 220},
                new Node() {X = 760, Y = 190},
                new Node() {X = 780, Y = 190},
            });

            // Кабинет [50]
            result.Add(new[]
            {
                new Node() {X = 690, Y = 190},
                new Node() {X = 710, Y = 190},
                new Node() {X = 710, Y = 220},
                new Node() {X = 670, Y = 220},
                new Node() {X = 670, Y = 190},
                new Node() {X = 680, Y = 190},
            });

            // Кабинет [51]
            result.Add(new[]
            {
                new Node() {X = 640, Y = 190},
                new Node() {X = 670, Y = 190},
                new Node() {X = 670, Y = 220},
                new Node() {X = 620, Y = 220},
                new Node() {X = 620, Y = 190},
                new Node() {X = 630, Y = 190},
            });

            // Кабинет [52]
            result.Add(new[]
            {
                new Node() {X = 640, Y = 190},
                new Node() {X = 670, Y = 190},
                new Node() {X = 670, Y = 220},
                new Node() {X = 620, Y = 220},
                new Node() {X = 620, Y = 190},
                new Node() {X = 630, Y = 190},
            });

            // Туалет Ж [53]
            result.Add(new[]
            {
                new Node() {X = 610, Y = 190},
                new Node() {X = 620, Y = 190},
                new Node() {X = 620, Y = 220},
                new Node() {X = 600, Y = 220},
                new Node() {X = 600, Y = 190},
            });

            // Кабинет [54]
            result.Add(new[]
            {
                new Node() {X = 600, Y = 190},
                new Node() {X = 600, Y = 220},
                new Node() {X = 580, Y = 220},
                new Node() {X = 580, Y = 190},
                new Node() {X = 590, Y = 190},
            });

            // Кабинет [55]
            result.Add(new[]
            {
                new Node() {X = 580, Y = 190},
                new Node() {X = 580, Y = 220},
                new Node() {X = 540, Y = 220},
                new Node() {X = 540, Y = 190},
                new Node() {X = 570, Y = 190},
            });

            // Кабинет [56]
            result.Add(new[]
            {
                new Node() {X = 580, Y = 190},
                new Node() {X = 580, Y = 220},
                new Node() {X = 540, Y = 220},
                new Node() {X = 540, Y = 190},
                new Node() {X = 570, Y = 190},
            });

            // Стена [57]
            result.Add(new[]
            {
                new Node() {X = 540, Y = 150},
                new Node() {X = 550, Y = 150},
            });

            // Стена [58]
            result.Add(new[]
            {
                new Node() {X = 540, Y = 130},
                new Node() {X = 550, Y = 130},
            });

            // Стена [59]
            result.Add(new[]
            {
                new Node() {X = 540, Y = 90},
                new Node() {X = 550, Y = 90},
            });

            // Лестница [60]
            result.Add(new[]
            {
                new Node() {X = 560, Y = 150},
                new Node() {X = 590, Y = 150},
                new Node() {X = 590, Y = 130},
                new Node() {X = 560, Y = 130},
            });

            // Кабинет [61]
            result.Add(new[]
            {
                new Node() {X = 560, Y = 60},
                new Node() {X = 560, Y = 90},
                new Node() {X = 590, Y = 90},
                new Node() {X = 590, Y = 40},
                new Node() {X = 560, Y = 40},
                new Node() {X = 560, Y = 50},
            });

            // Кабинет [62]
            result.Add(new[]
            {
                new Node() {X = 550, Y = 40},
                new Node() {X = 590, Y = 40},
                new Node() {X = 590, Y = 0},
                new Node() {X = 530, Y = 0},
                new Node() {X = 530, Y = 40},
                new Node() {X = 540, Y = 40},
            });

            // Кабинет [63]
            result.Add(new[]
            {
                new Node() {X = 550, Y = 40},
                new Node() {X = 590, Y = 40},
                new Node() {X = 590, Y = 0},
                new Node() {X = 530, Y = 0},
                new Node() {X = 530, Y = 40},
                new Node() {X = 540, Y = 40},
            });

            // Кабинет [64]
            result.Add(new[]
            {
                new Node() {X = 470, Y = 40},
                new Node() {X = 530, Y = 40},
                new Node() {X = 530, Y = 0},
                new Node() {X = 400, Y = 0},
                new Node() {X = 400, Y = 40},
            });

            // Кабинет [65]
            result.Add(new[]
            {
                new Node() {X = 420, Y = 40},
                new Node() {X = 450, Y = 40},
                new Node() {X = 450, Y = 0},
                new Node() {X = 400, Y = 0},
                new Node() {X = 400, Y = 40},
                new Node() {X = 420, Y = 40},
            });

            // Кабинет [66]
            result.Add(new[]
            {
                new Node() {X = 390, Y = 40},
                new Node() {X = 400, Y = 40},
                new Node() {X = 400, Y = 0},
                new Node() {X = 350, Y = 0},
                new Node() {X = 350, Y = 40},
                new Node() {X = 380, Y = 40},
            });

            // Кабинет [67]
            result.Add(new[]
            {
                new Node() {X = 340, Y = 40},
                new Node() {X = 350, Y = 40},
                new Node() {X = 350, Y = 0},
                new Node() {X = 320, Y = 0},
                new Node() {X = 320, Y = 40},
                new Node() {X = 330, Y = 40},
            });

            // Кабинет [68]
            result.Add(new[]
            {
                new Node() {X = 280, Y = 40},
                new Node() {X = 320, Y = 40},
                new Node() {X = 320, Y = 0},
                new Node() {X = 260, Y = 0},
                new Node() {X = 260, Y = 40},
                new Node() {X = 270, Y = 40},
            });

            // Кабинет [69]
            result.Add(new[]
            {
                new Node() {X = 250, Y = 40},
                new Node() {X = 230, Y = 40},
                new Node() {X = 230, Y = 0},
                new Node() {X = 260, Y = 0},
                new Node() {X = 260, Y = 40},
            });

            // Кабинет [70]
            result.Add(new[]
            {
                new Node() {X = 200, Y = 40},
                new Node() {X = 230, Y = 40},
                new Node() {X = 230, Y = 0},
                new Node() {X = 180, Y = 0},
                new Node() {X = 180, Y = 40},
                new Node() {X = 190, Y = 40},
            });

            // Кабинет [71]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 40},
                new Node() {X = 130, Y = 40},
                new Node() {X = 130, Y = 0},
                new Node() {X = 180, Y = 0},
                new Node() {X = 180, Y = 40},
            });

            // Кабинет [72]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 70},
                new Node() {X = 170, Y = 40},
                new Node() {X = 130, Y = 40},
                new Node() {X = 130, Y = 90},
                new Node() {X = 170, Y = 90},
            });

            // Кабинет [72]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 70},
                new Node() {X = 170, Y = 40},
                new Node() {X = 130, Y = 40},
                new Node() {X = 130, Y = 90},
                new Node() {X = 170, Y = 90},
            });

            // Кабинет [73]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 130},
                new Node() {X = 130, Y = 130},
                new Node() {X = 130, Y = 180},
                new Node() {X = 170, Y = 180},
                new Node() {X = 170, Y = 140},
            });

            // Кабинет [74]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 180},
                new Node() {X = 130, Y = 180},
                new Node() {X = 130, Y = 240},
                new Node() {X = 170, Y = 240},
                new Node() {X = 170, Y = 190},
            });

            // Кабинет [75]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 240},
                new Node() {X = 130, Y = 240},
                new Node() {X = 130, Y = 290},
                new Node() {X = 170, Y = 290},
                new Node() {X = 170, Y = 250},
            });

            // Кабинет [76]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 300},
                new Node() {X = 170, Y = 290},
                new Node() {X = 130, Y = 290},
                new Node() {X = 130, Y = 330},
                new Node() {X = 170, Y = 330},
                new Node() {X = 170, Y = 310},
            });

            // Кабинет [77]
            result.Add(new[]
            {
                new Node() {X = 170, Y = 330},
                new Node() {X = 130, Y = 330},
                new Node() {X = 130, Y = 400},
                new Node() {X = 170, Y = 400},
                new Node() {X = 170, Y = 340},
            });

            // Кабинет [78]
            result.Add(new[]
            {
                new Node() {X = 190, Y = 360},
                new Node() {X = 170, Y = 360},
                new Node() {X = 170, Y = 400},
                new Node() {X = 230, Y = 400},
                new Node() {X = 230, Y = 350},
                new Node() {X = 190, Y = 350},
            });

            // Кабинет [79]
            result.Add(new[]
            {
                new Node() {X = 190, Y = 360},
                new Node() {X = 170, Y = 360},
                new Node() {X = 170, Y = 400},
                new Node() {X = 230, Y = 400},
                new Node() {X = 230, Y = 350},
                new Node() {X = 190, Y = 350},
            });

            // Кабинет [80]
            result.Add(new[]
            {
                new Node() {X = 190, Y = 270},
                new Node() {X = 190, Y = 350},
                new Node() {X = 230, Y = 350},
                new Node() {X = 230, Y = 260},
                new Node() {X = 190, Y = 260},
            });

            // Кабинет [81]
            result.Add(new[]
            {
                new Node() {X = 190, Y = 210},
                new Node() {X = 190, Y = 260},
                new Node() {X = 230, Y = 260},
                new Node() {X = 230, Y = 180},
                new Node() {X = 190, Y = 180},
                new Node() {X = 190, Y = 200},
            });

            // Кабинет [82]
            result.Add(new[]
            {
                new Node() {X = 190, Y = 170},
                new Node() {X = 190, Y = 180},
                new Node() {X = 230, Y = 180},
                new Node() {X = 230, Y = 150},
                new Node() {X = 190, Y = 150},
                new Node() {X = 190, Y = 160},
            });

            // Кабинет [83]
            result.Add(new[]
            {
                new Node() {X = 190, Y = 140},
                new Node() {X = 190, Y = 110},
                new Node() {X = 230, Y = 110},
                new Node() {X = 230, Y = 150},
                new Node() {X = 190, Y = 150},
            });

            // Кабинет [85]
            result.Add(new[]
            {
                new Node() {X = 300, Y = 60},
                new Node() {X = 250, Y = 60},
                new Node() {X = 250, Y = 90},
                new Node() {X = 320, Y = 90},
                new Node() {X = 320, Y = 60},
                new Node() {X = 310, Y = 60},
            });

            // Кабинет [86]
            result.Add(new[]
            {
                new Node() {X = 330, Y = 60},
                new Node() {X = 320, Y = 60},
                new Node() {X = 320, Y = 90},
                new Node() {X = 350, Y = 90},
                new Node() {X = 350, Y = 60},
                new Node() {X = 340, Y = 60},
            });

            // Кабинет [87]
            result.Add(new[]
            {
                new Node() {X = 360, Y = 60},
                new Node() {X = 350, Y = 60},
                new Node() {X = 350, Y = 90},
                new Node() {X = 400, Y = 90},
                new Node() {X = 400, Y = 60},
                new Node() {X = 370, Y = 60},
            });

            // Кабинет [88]
            result.Add(new[]
            {
                new Node() {X = 400, Y = 60},
                new Node() {X = 400, Y = 90},
                new Node() {X = 430, Y = 90},
                new Node() {X = 430, Y = 60},
                new Node() {X = 410, Y = 60},
            });

            // Кабинет [89]
            result.Add(new[]
            {
                new Node() {X = 430, Y = 60},
                new Node() {X = 430, Y = 90},
                new Node() {X = 500, Y = 90},
                new Node() {X = 500, Y = 60},
                new Node() {X = 450, Y = 60},
            });


            // Лестница [90]
            result.Add(new[]
            {
                new Node() {X = 500, Y = 60},
                new Node() {X = 500, Y = 90},
                new Node() {X = 540, Y = 90},
                new Node() {X = 540, Y = 60},
            });




            foreach (var nodeArray in result)
            {
                foreach (var t in nodeArray)
                {
                    t.Id = Guid.NewGuid();
                }

                for (int i = 0; i < nodeArray.Length-1; i++)
                {
                    nodeArray[i].NextNodeId = nodeArray[i + 1].Id;
                }
            }

            return result;
        }
    }
}