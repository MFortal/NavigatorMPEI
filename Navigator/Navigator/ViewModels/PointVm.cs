namespace Navigator.ViewModels
{
    public class PointVm
    {
        public int X { get; set; }

        public int Y { get; set; }

        public PointVm(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}