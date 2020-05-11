using System;
using System.Collections.Generic;
using System.Linq;

namespace Abstractions.ViewModels
{
    public class PathForLevelVm
    {
        public LevelVm Level { get; set; }

        public IList<PointVm> Path { get; set; }

        public string PathString => string.Join(" ", Path.Select(x => x.ToString()));

        public PathForLevelVm()
        {
            Path = new List<PointVm>();
        }
    }
}
