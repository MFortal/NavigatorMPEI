using System;
using System.Collections.Generic;

namespace DataLayer.Models.DataModels
{
    public class Item : BaseTableModel
    {
        public string Description { get; set; }

        public string Number { get; set; }

        public bool Repair { get; set; }

        public Guid LevelId { get; set; }
        public virtual Level Level { get; set; }

        public Guid BuildingId { get; set; }
        public virtual Building Building { get; set; }

        public Guid TypeItemId { get; set; }
        public virtual TypeItem TypeItem { get; set; }


        public Guid NodeId { get; set; }
        public virtual Node Node { get; set; }
    }
}