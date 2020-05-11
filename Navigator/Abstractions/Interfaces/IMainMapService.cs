using System;
using Abstractions.ViewModels;

namespace Abstractions.Interfaces
{
    public interface IMainMapService
    {
        MainMapVm GetMainMap(Guid? levelId = null);

        PathVm GetPath(string start, string finish);
    }
}
