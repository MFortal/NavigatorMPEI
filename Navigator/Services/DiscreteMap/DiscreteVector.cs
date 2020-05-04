namespace Services.DiscreteMap
{
    public class DiscreteVector
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Level { get; set; }

        #region Math

        public static DiscreteVector operator + (DiscreteVector first, DiscreteVector second)
        {
            return new DiscreteVector()
            {
                X = first.X + second.X,
                Y = first.Y + second.Y,
                Level = first.Level + second.Level,
            };
        }

        public static DiscreteVector operator *(int value, DiscreteVector vector)
        {
            return new DiscreteVector()
            {
                X = vector.X * value,
                Y = vector.Y + value,
                Level = vector.Level + value,
            };
        }

        public static DiscreteVector operator - (DiscreteVector first, DiscreteVector second) => first + -1 * second;
        
        #endregion
    }
}
