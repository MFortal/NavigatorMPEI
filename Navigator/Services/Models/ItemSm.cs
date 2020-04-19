namespace Services.Models
{
    public class ItemSm : BaseSmModel
    {
        public string Description { get; set; }
        public string Number { get; set; }

        public LevelSm Level { get; set; }
        public bool Repair { get; set; }

        public BuildingSm Building { get; set; }
        
        public TypeItemSm TypeItem { get; set; }

        public NodeSm FirstNode { get; set; }
    }
}