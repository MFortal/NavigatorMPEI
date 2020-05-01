namespace Navigator.ViewModels
{
    public class PointVm
    {
        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}