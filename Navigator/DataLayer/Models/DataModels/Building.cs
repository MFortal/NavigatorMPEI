using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models.DataModels
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}