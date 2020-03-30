using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Navigator.Models.DataModels
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public virtual ICollection<Object> Objects { get; set; }
    }
}