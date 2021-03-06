﻿using CorvallisBusCoreNetCore.Models;
using CorvallisBusCoreNetCore.Models.Connexionz;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CorvallisBusCoreNetCore.WebClients
{
    using ServerBusSchedule = Dictionary<int, IEnumerable<BusStopRouteSchedule>>;

    public interface ITransitClient
    {
        Task<List<BusStop>> CreateStopsAsync();
        Task<List<BusRoute>> CreateRoutesAsync();
        Task<BusStaticData> CreateStaticDataAsync();
        Task<Dictionary<int, int>> CreatePlatformTagsAsync();
        Task<ConnexionzPlatformET> GetEtaAsync(int platformTag);
        Task<ServerBusSchedule> CreateScheduleAsync();
    }
}
