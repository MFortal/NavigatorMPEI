using System.IO;

namespace Services.DiscreteMap
{
    public class DiscreteMapField
    {
        private DiscreteVector _radiusVector;

        public Cell[,,] Field { get; set; }

        public DiscreteMapField(DiscreteVector min, DiscreteVector max)
        {
            _radiusVector = min;
            var sizeRadiusVector = max - min;
            Field = new Cell[sizeRadiusVector.X, sizeRadiusVector.Y, sizeRadiusVector.Level];
        }

        public void PrintToFile()
        {
            using (var sw = new StreamWriter(@"C:\Navigator\field.txt", append: false))
            {
                // levels
                for (int l = 0; l < Field.GetLength(2); l++)
                {
                    sw.WriteLine($"Level {l}");
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
