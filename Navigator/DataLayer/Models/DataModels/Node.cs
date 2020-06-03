using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models.DataModels
{
    public class Node : BaseTableModel
    {
        public int X { get; set; }

        public int Y { get; set; }

        [ForeignKey("NextNode")] public Guid? NextNodeId { get; set; }
        public virtual Node NextNode { get; set; }
    }
}