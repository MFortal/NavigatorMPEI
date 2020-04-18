using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models.DataModels
{
    public class TypeItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }



        public virtual ICollection<Item> Items { get; set; }
    }
}