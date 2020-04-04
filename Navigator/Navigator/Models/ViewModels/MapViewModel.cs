using System.Collections.Generic;

namespace Navigator.Models.ViewModels
{
    public class MapViewModel
    {
        public string LevelName { get; set; }
        public string BuildingName { get; set; }
        public List<ItemsLevel> ItemsLevel { get; set; }
    }
}