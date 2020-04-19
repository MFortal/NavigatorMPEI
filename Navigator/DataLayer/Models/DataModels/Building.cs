using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models.DataModels
{
    public class Building : BaseTableModel
    {
        [Required]
        public string Name { get; set; }
    }
}