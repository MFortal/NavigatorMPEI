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

        public int MaxX => Border.Select(x => x.X).Max();
        public int MaxY => Border.Select(x => x.Y).Max();
        public int MinX => Border.Select(x => x.X).Min();
        public int MinY => Border.Select(x => x.Y).Min();

        public int Width => MaxX - MinX;
        public int Height => MaxY - MinY;

    }
}