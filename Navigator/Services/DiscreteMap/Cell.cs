namespace Services.DiscreteMap
{
    public class Cell
    {
        public bool Available { get; set; }

        public bool IsStair { get; set; }

        public int? Distance { get; set; }

        public int? Weight{ get; set; }

        public Cell()
        {
            Available = true;
        }
    }
}
