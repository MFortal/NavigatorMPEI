using System;
using System.Collections.Generic;
using Services.DiscreteMap;
using Services.Models;

namespace Services.Interfaces
{
    public interface IDiscreteMapService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodesForLevel">Списки точек, сгруппированых по этажам</param>
        /// <returns>Минимальную точку текущего запроса (радиус-вектор) и максимальную</returns>
        Tuple<DiscreteVector, DiscreteVector> FindMinMaxCoordinate(IDictionary<LevelSm, List<NodeSm>> nodesForLevel);
    }
}
