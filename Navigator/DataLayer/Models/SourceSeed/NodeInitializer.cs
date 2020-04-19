using System.Collections.Generic;
using System.Linq;
using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public class NodeInitializer
    {
        public static Node[] Initialize()
        {
            var borderNodes = new LinkedList<Node>();
            borderNodes.AddFirst(new Node() {X = 1, Y = 1});
            borderNodes.AddLast(new Node() { X = 1, Y = 12 });
            borderNodes.AddLast(new Node() { X = 12, Y = 12 });
            borderNodes.AddLast(new Node() { X = 12, Y = 1 });

            var currentNode = borderNodes.First;
            while (currentNode.Next != null)
            {
                currentNode.Value.NextNode = currentNode.Next.Value;
                currentNode = currentNode.Next;
            }

            return borderNodes.ToArray();

            //return new Node[]
            //{
            //    //кабинеты
            //    //new Node{Id=1, NextId=null, X=11, Y=11},
            //    //new Node{Id=2, NextId=null, X=7, Y=11},
            //    //new Node{Id=3, NextId=null, X=2, Y=11},
            //    //new Node{Id=4, NextId=null, X=2, Y=2},
            //    //new Node{Id=5, NextId=null, X=4, Y=2},
            //    //new Node{Id=6, NextId=null, X=8, Y=2},
            //    //new Node{Id=7, NextId=null, X=11, Y=2},
            //    //new Node{Id=8, NextId=null, X=5, Y=7},

            //    ////точки границ внешней стены
            //    //new Node{/*Id=12,*/ NextNodeId=null, X=12, Y=1},
            //    //new Node{/*Id=11, */NextNodeId=12, X=12, Y=12},
            //    //new Node{/*Id=10, */NextNodeId=11, X=1, Y=12},
            //    //new Node{/*Id=9, */NextNodeId=10, X=1, Y=1},

            //    //внутренние стены
            //    //(4)
            //    //new Node{Id=13, NextNodeId=14, X=1, Y=1},
            //    //new Node{Id=14, NextNodeId=15, X=1, Y=3},
            //    //new Node{Id=38, NextNodeId=39, X=2, Y=3},
            //    //new Node{Id=39, NextNodeId=40, X=3, Y=1},
            //    //new Node{Id=40, NextNodeId=null, X=3, Y=3},
            //    //(5)
            //    //new Node{Id=15, NextId=16, X=3, Y=1},
            //    //new Node{Id=16, NextId=17, X=3, Y=3},
            //    //new Node{Id=17, NextId=null, X=5, Y=3},
            //    ////(6)
            //    //new Node{Id=18, NextId=19, X=6, Y=1},
            //    //new Node{Id=19, NextId=20, X=6, Y=3},
            //    //new Node{Id=20, NextId=null, X=8, Y=3},
            //    ////(7)
            //    //new Node{Id=21, NextId=22, X=10, Y=1},
            //    //new Node{Id=22, NextId=null, X=10, Y=3},
            //    //new Node{Id=23, NextId=24, X=10, Y=4},
            //    //new Node{Id=24, NextId=null, X=12, Y=4},
            //    ////(3)
            //    //new Node{Id=25, NextId=26, X=1, Y=10},
            //    //new Node{Id=26, NextId=null, X=3, Y=10},
            //    ////(1-2)
            //    //new Node{Id=27, NextId=28, X=4, Y=10},
            //    //new Node{Id=28, NextId=null, X=4, Y=12},
            //    //new Node{Id=29, NextId=30, X=6, Y=10},
            //    //new Node{Id=30, NextId=31, X=8, Y=10},
            //    //new Node{Id=31, NextId=null, X=8, Y=12},
            //    //new Node{Id=32, NextId=30, X=10, Y=10},
            //    ////(8)
            //    //new Node{Id=33, NextId=34, X=3, Y=5},
            //    //new Node{Id=34, NextId=35, X=3, Y=8},
            //    //new Node{Id=35, NextId=36, X=6, Y=8},
            //    //new Node{Id=36, NextId=37, X=6, Y=5},
            //    //new Node{Id=37, NextId=null, X=4, Y=5}
            //};
        }
    }
}