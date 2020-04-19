using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models.DataModels
{
    public class TypeItem : BaseTableModel
    {
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}