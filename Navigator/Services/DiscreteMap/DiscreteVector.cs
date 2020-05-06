namespace Services.DiscreteMap
{
    public class DiscreteVector
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Level { get; set; }

        public DiscreteVector(int x, int y, int l)
        {
            X = x;
            Y = y;
            Level = l;
        }

        #region Math

        public static DiscreteVector operator + (DiscreteVector first, DiscreteVector second) => new DiscreteVector(first.X + second.X, first.Y + second.Y, first.Level + second.Level);

        public static DiscreteVector operator + (DiscreteVector vector, int value) => new DiscreteVector(vector.X + value, vector.Y + value, vector.Level + value);

        public static DiscreteVector operator * (int value, DiscreteVector vector) => new DiscreteVector(vector.X * value, vector.Y * value, vector.Level * value);

        public static DiscreteVector operator - (DiscreteVector first, DiscreteVector second) => first + -1 * second;
        
        #endregion
    }
}
