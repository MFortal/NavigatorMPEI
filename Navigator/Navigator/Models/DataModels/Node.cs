using System.Collections.Generic;

namespace Navigator.Models.DataModels
{
    public class Node
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? NextId { get; set; }

        
        public virtual Node Nodes { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}