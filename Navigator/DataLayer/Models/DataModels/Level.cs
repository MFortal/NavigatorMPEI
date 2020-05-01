using System;

namespace DataLayer.Models.DataModels
{
    public class Level : BaseTableModel
    {
        public int Number { get; set; }

        public Guid BuildingId { get; set; }
        public virtual Building Building { get; set; }
    }
}