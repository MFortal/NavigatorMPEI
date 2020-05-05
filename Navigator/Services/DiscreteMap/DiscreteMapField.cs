using System.IO;
using Services.Models;

namespace Services.DiscreteMap
{
    public class DiscreteMapField
    {
        private DiscreteVector _radiusVector;

        public Cell[,,] Field { get; set; }

        public DiscreteMapField(DiscreteVector min, DiscreteVector max)
        {
            _radiusVector = min;
            var sizeRadiusVector = max - min + 1;
            Field = new Cell[sizeRadiusVector.X, sizeRadiusVector.Y, sizeRadiusVector.Level];
            for (int l = 0; l < Field.GetLength(2); l++)
            {
                for (int x = 0; x < Field.GetLength(0); x++)
                {
                    for (int y = 0; y < Field.GetLength(1); y++)
                    {
                        Field[x, y, l] = new Cell();
                    }
                }
            }
        }

        public void AddWall(NodeSm startNode, NodeSm finishNode, int levelNumber)
        {
            var startCoordinate = new DiscreteVector(startNode.X, startNode.Y, levelNumber) - _radiusVector;
            var finishCoordinate = new DiscreteVector(finishNode.X, finishNode.Y, levelNumber) - _radiusVector;
            var level = startCoordinate.Level;

            var dx = finishCoordinate.X - startCoordinate.X;
            var dy = finishCoordinate.Y - startCoordinate.Y;

            var x = startCoordinate.X;
            var y = startCoordinate.Y;
            while (x != finishCoordinate.X || y != finishCoordinate.Y)
            {
                Field[x, y, level].Available = false;                

                // Определяем, по какой оси сдвигаться.
                if (finishCoordinate.X - x != 0)
                {
                    x += dx > 0 ? 1 : -1;
                }
                if (finishCoordinate.Y - y != 0)
                {
                    y += dy > 0 ? 1 : -1;
                }
            }
        }

        public void PrintToFile()
        {
            using (var sw = new StreamWriter(@"C:\Navigator\field.txt", append: false))
            {
                // levels
                for (int l = 0; l < Field.GetLength(2); l++)
                {
                    sw.WriteLine();
                    sw.WriteLine($"Level {l}");
                    sw.WriteLine();
                    for (int x = 0; x < Field.GetLength(0); x++)
                    {
                        for (int y = 0; y < Field.GetLength(1); y++)
                        {
                            var cell = Field[x, y, l].Available ? '.' : '#';
                            sw.Write(cell);
                        }
                        sw.WriteLine();
                    }
                }
            }
        }
    }
}
