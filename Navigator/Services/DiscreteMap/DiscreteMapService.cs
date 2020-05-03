using System;
using System.Collections.Generic;
using System.Linq;
using Services.Interfaces;
using Services.Models;

namespace Services.DiscreteMap
{
    public class DiscreteMapService : IDiscreteMapService
    {
        public Tuple<DiscreteVector, DiscreteVector> FindMinMaxCoordinate(IDictionary<LevelSm, List<NodeSm>> nodesForLevel)
        {
            var firstNode = nodesForLevel.Values.First().First();

            var minX = firstNode.X;
            var minY = firstNode.Y;
            var maxX = firstNode.X;
            var maxY = firstNode.Y;

            var minL = nodesForLevel.Keys.Select(x => x.Number).Min();
            var maxL = nodesForLevel.Keys.Select(x => x.Number).Max();
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

            var minCoordinate = new DiscreteVector() {X = minX, Y = minY, Level = minL};
            var maxCoordinate = new DiscreteVector() {X = maxX, Y = maxY, Level = maxL};

            return new Tuple<DiscreteVector, DiscreteVector>(minCoordinate, maxCoordinate);
        }
    }
}
