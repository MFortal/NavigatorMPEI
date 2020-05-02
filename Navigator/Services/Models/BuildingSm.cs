using System.Collections.Generic;

namespace Services.Models
{
    public class BuildingSm : BaseSmModel
    {
        public string Name { get; set; }

        public IEnumerable<LevelSm> Levels { get; set; }
    }
}