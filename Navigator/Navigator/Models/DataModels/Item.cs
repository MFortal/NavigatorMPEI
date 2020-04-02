using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Navigator.Models.DataModels
{
    public class Item
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool? Repaired { get; set; }

        public string Number { get; set; }


        public virtual ICollection<Item> Items { get; set; }
        
        [Required]
        public virtual Level Level { get; set; }

        [Required]
        public virtual Building Building { get; set; }
        
        [Required]
        public virtual TypeItem TypeItem { get; set; }

        [Required]
        public virtual Node Node { get; set; }
    }
}