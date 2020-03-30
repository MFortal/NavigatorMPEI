using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Navigator.Models.DataModels
{
    public class Node
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        
        public virtual ICollection<Node> Nodes { get; set; }

        [Required]
        public virtual ICollection<Object> Objects { get; set; }
    }
}