using System;
using System.Collections.Generic;
using System.Linq;
using Services.Models;

namespace Services.DiscreteMap
{
    public class DiscreteMapService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodesForLevel">Списки точек, сгруппированых по этажам</param>
        /// <returns>Минимальную точку текущего запроса (радиус-вектор) и максимальную</returns>
        Tuple<Coordinate, Coordinate> FindMinMaxCoordinate(IDictionary<int, IList<NodeSm>> nodesForLevel)
        {
            var firstNode = nodesForLevel.Values.First().First();

            var minX = firstNode.X;
            var minY = firstNode.Y;
            var maxX = firstNode.X;
            var maxY = firstNode.Y;

            var minL = nodesForLevel.Keys.Min();
            var maxL = nodesForLevel.Keys.Max();
            foreach (var node in nodesForLevel.SelectMany(x => x.Value))
            {
                if (node.X > maxX)
                    maxX = node.X;
                if (node.Y > maxY)
                    maxY = node.Y;
                if (node.X < minX)
                    minX = node.X;
                if (node.Y < minY)
                    minY = node.Y;
            }

            var minCoordinate = new Coordinate() {X = minX, Y = minY, Level = minL};
            var maxCoordinate = new Coordinate() {X = maxX, Y = maxY, Level = maxL};

            return new Tuple<Coordinate, Coordinate>(minCoordinate, maxCoordinate);
        }
    }
}
