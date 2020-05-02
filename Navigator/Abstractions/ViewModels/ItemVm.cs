using System;
using System.Collections.Generic;
using System.Linq;

namespace Abstractions.ViewModels
{
    public class ItemVm
    {
        public Guid ItemId { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }

        public IEnumerable<PointVm> Border { get; set; }
        public string BorderString => string.Join(" ", Border.Select(x => x.ToString()));
    }
}