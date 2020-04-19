using System;

namespace DataLayer.Models.DataModels
{
    public class BaseTableModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

    }
}
