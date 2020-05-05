using System;
using System.Collections.Generic;
using System.Linq;
using Services.Interfaces;
using Services.Models;

namespace Services.DiscreteMap
{
    public class DiscreteMapService : IDiscreteMapService
    {
        public Tuple<DiscreteVector, DiscreteVector> FindMinMaxCoordinate(IList<ItemSm> items)
        {
            var firstNode = items.First().Nodes.First();

            var minX = firstNode.X;
            var minY = firstNode.Y;
            var maxX = firstNode.X;
            var maxY = firstNode.Y;

            var levels = items.Select(x => x.Level).Distinct().ToList();

            var minL = levels.Select(x => x.Number).Min();
            var maxL = levels.Select(x => x.Number).Max();
            foreach (var node in items.SelectMany(x => x.Nodes))
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

            var minCoordinate = new DiscreteVector(minX, minY, minL);
            var maxCoordinate = new DiscreteVector(maxX, maxY, maxL);

            return new Tuple<DiscreteVector, DiscreteVector>(minCoordinate, maxCoordinate);
        }

        public void CreateWalls(DiscreteMapField field, IList<ItemSm> items)
        {
            foreach (var item in items)
            {
                var node = item.Nodes.First.Value;
                while (node?.NextNode != null)
                {
                    field.AddWall(node, node.NextNode, item.Level.Number);
                    node = node.NextNode;
                }
            }
        }
    }
}
