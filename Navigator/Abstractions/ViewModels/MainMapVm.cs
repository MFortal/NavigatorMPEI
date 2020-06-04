using System;
using System.Collections.Generic;
using System.Linq;

namespace Abstractions.ViewModels
{
    public class MainMapVm
    {
        public Guid CurrentLevelId { get; set; }

        public IEnumerable<LevelVm> AllLevels { get; set; }

        public IEnumerable<ItemVm> AllItems { get; set; }

        public IEnumerable<PointVm> Border { get; set; }

        public string BorderString => string.Join(" ", Border.Select(x => x.ToString()));

        public IEnumerable<ItemVm> Rooms { get; set; }

        public IEnumerable<ItemVm> Stairs { get; set; }

        public IEnumerable<ItemVm> WcWomans { get; set; }

        public IEnumerable<ItemVm> WcMans { get; set; }

        public IEnumerable<ItemVm> Walls { get; set; }

        public IEnumerable<BuildingVm> AllBuildings { get; set; }

    }
}