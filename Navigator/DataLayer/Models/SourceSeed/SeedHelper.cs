using DataLayer.Models.DataModels;

namespace DataLayer.Models.SourceSeed
{
    public static class SeedHelper
    {
        public static Node GetCenterItems(Node[] item)
        {
            var x = 0;
            var y = 0;
            foreach (var i in item)
            {
                x += i.X;
                y += i.Y;
            }
            var averageX = x / item.Length;
            var averageY = y / item.Length;

            return new Node() {X = averageX, Y = averageY};
        }
    }
}
