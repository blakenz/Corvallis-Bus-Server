﻿using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Represents the schedule for a particular route at a particular stop.
    /// </summary>
    public class BusStopRouteSchedule
    {
        public string RouteNo { get; set; }
        public List<BusStopRouteDaySchedule> DaySchedules { get; set; }
    }
}