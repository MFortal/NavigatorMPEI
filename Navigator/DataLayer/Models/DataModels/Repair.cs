using System.Collections.Generic;

namespace Navigator.Models.DataModels
{
    public class Repair
    {
        public int Id { get; set; }

        public int Name { get; set; }



        public virtual ICollection<Item> Items { get; set; }
    }
}