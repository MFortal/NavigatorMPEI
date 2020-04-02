using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Navigator.Models.DataModels
{
    public class Level
    {
        public int Id { get; set; }

        public int Name { get; set; }


        [Required]
        public virtual ICollection<Item> Items { get; set; }
    }
}