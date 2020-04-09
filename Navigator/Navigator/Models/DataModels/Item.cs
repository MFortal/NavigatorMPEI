using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Navigator.Models.DataModels
{
    public class Item
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Number { get; set; }
        public int RepairId { get; set; }
        public int LevelId { get; set; }
        public int BuildingId { get; set; }
        public int TypeItemId { get; set; }
        public int NodeId { get; set; }


        public virtual ICollection<Item> Items { get; set; }
        
        public virtual Level Level { get; set; }
        public virtual Repair Repair { get; set; }

        public virtual Building Building { get; set; }
        
        public virtual TypeItem TypeItem { get; set; }

        public virtual Node Node { get; set; }
    }
}