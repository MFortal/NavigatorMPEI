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
    }
}
