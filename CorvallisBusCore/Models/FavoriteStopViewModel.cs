﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// A view model intended for consumption by the Corvallis Bus iOS app.
    /// </summary>
    public class FavoriteStopViewModel
    {
        [JsonProperty("stopName")]
        public string StopName { get; set; }

        [JsonProperty("stopID")]
        public int StopId { get; set; }

        [JsonProperty("distanceFromUser")]
        public string DistanceFromUser { get; set; }

        /// <summary>
        /// Indicates whether this stop is not a favorite but is
        /// being displayed because it's the nearest stop in town.
        /// </summary>
        [JsonProperty("isNearestStop")]
        public bool IsNearestStop { get; set; }

        [JsonProperty("firstRouteColor")]
        public string FirstRouteColor { get; set; }

        [JsonProperty("firstRouteName")]
        public string FirstRouteName { get; set; }

        [JsonProperty("firstRouteArrivals")]
        public string FirstRouteArrivals { get; set; }

        [JsonProperty("secondRouteColor")]
        public string SecondRouteColor { get; set; }

        [JsonProperty("secondRouteName")]
        public string SecondRouteName { get; set; }

        [JsonProperty("secondRouteArrivals")]
        public string SecondRouteArrivals { get; set; }
    }
}
