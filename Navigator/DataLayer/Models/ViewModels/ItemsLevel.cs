using Navigator.Models.DataModels;
using System.Collections.Generic;

namespace Navigator.Models.ViewModels
{
    public class ItemsLevel
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
        public string Repaired { get; set; }
        public string Number { get; set; }
        public List<Node> Nodes { get; set; }
    }
}