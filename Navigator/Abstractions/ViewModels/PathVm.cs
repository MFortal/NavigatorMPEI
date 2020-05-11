using System.Collections.Generic;

namespace Abstractions.ViewModels
{
    public class PathVm
    {
        public IList<PathForLevelVm> FullPath { get; set; }

        public PathVm()
        {
            FullPath = new List<PathForLevelVm>();
        }
    }
}
