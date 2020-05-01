using System;
using System.Collections.Generic;
using System.Linq;

namespace Navigator.ViewModels
{
    public class MainMapVm
    {
        public Guid LevelId { get; set; }

        public IEnumerable<PointVm> Border { get; set; }
        public string BorderString => string.Join(" ", Border.Select(x => x.ToString()));

        public IEnumerable<ItemVm> Rooms { get; set; }

        public IEnumerable<ItemVm> Stairs { get; set; }
    }
}