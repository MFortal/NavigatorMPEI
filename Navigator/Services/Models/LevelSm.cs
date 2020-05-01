namespace Services.Models
{
    public class LevelSm : BaseSmModel
    {
        public int Number { get; set; }

        public BuildingSm Building { get; set; }
    }
}