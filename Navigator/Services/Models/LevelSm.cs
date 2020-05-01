using System.Collections.Generic;

namespace Services.Models
{
    public class LevelSm : BaseSmModel
    {
        public BuildingSm Building { get; set; }

        public int Name { get; set; }

        public IEnumerable<ItemSm> Items { get; set; }
    }
}