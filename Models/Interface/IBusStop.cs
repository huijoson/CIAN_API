using System;
using System.Collections.Generic;
using CIAN_API.ViewModels;

namespace CIAN_API.Models.Interface
{
    public interface IBusStop : IDisposable
    {
        DataClassesDataContext Entity { get; }
        List<ViewModels.BusStopCustom> GetBusStop(IEnumerable<BusStopDeserialize> busStopSource);
    }
}
