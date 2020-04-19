using System.Collections.Generic;

namespace DataLayer.Models.DataModels
{
    public class Item
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Number { get; set; }

        public bool Repair { get; set; }

        public int LevelId { get; set; }
        public virtual Level Level { get; set; }

        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }

        public int TypeItemId { get; set; }
        public virtual TypeItem TypeItem { get; set; }


        public int NodeId { get; set; }
        public virtual Node Node { get; set; }
    }
}