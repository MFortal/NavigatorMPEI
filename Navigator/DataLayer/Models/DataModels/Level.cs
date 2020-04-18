using System.Collections.Generic;

namespace DataLayer.Models.DataModels
{
    public class Level
    {
        public int Id { get; set; }

        public int Name { get; set; }



        public virtual ICollection<Item> Items { get; set; }
    }
}