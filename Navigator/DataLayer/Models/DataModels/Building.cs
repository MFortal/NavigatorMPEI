using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Navigator.Models.DataModels
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public virtual ICollection<Item> Items { get; set; }
    }
}