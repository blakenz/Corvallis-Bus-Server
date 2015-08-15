﻿using API.Models;
using API.Models.Connexionz;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.DataAccess
{
    public class CacheManager
    {
        private string _connectionString;
        private string _routesKey;
        private string _stopsKey;
        private string _staticDataKey;
        private string _platformsKey;
        private string _scheduleKey;

        private ConnectionMultiplexer _conn;

        /// <summary>
        /// Connection to the Redis cache.
        /// </summary>
        private ConnectionMultiplexer Connection
        {
            get
            {
                if (_conn == null)
                {
                    _conn = ConnectionMultiplexer.Connect(_connectionString);
                }

                return _conn;
            }
        }

        public CacheManager(AppSettings appSettings)
        {
            _connectionString = appSettings.RedisConnectionString;
            _routesKey = appSettings.RoutesKey;
            _stopsKey = appSettings.StopsKey;
            _staticDataKey = appSettings.StaticDataKey;
            _platformsKey = appSettings.PlatformsKey;
            _scheduleKey = appSettings.SchedulesKey;
        }

        internal void ClearCache()
        {
            var cache = Connection.GetDatabase();

            cache.StringSet(_routesKey, string.Empty);
            cache.StringSet(_stopsKey, string.Empty);
            cache.StringSet(_staticDataKey, string.Empty);
            cache.StringSet(_platformsKey, string.Empty);
            cache.StringSet(_scheduleKey, string.Empty);
        }

        internal void SetRoutes(string routesJson) => Connection.GetDatabase().StringSet(_routesKey, routesJson);

        internal void SetStops(string stopsJson) => Connection.GetDatabase().StringSet(_stopsKey, stopsJson);

        internal void SetStaticData(string staticDataJson) => Connection.GetDatabase().StringSet(_staticDataKey, staticDataJson);

        internal void SetPlatformTags(string platformTagsJson) => Connection.GetDatabase().StringSet(_platformsKey, platformTagsJson);

        internal void SetSchedule(string scheduleJson) => Connection.GetDatabase().StringSet(_scheduleKey, scheduleJson);

        /// <summary>
        /// Gets static routes from the cache. May return an empty string if the cache expires.
        /// </summary>
        public async Task<string> GetRoutesAsync()
        {
            var cache = Connection.GetDatabase();
            var json = await cache.StringGetAsync(_routesKey);
            return json;
        }

        /// <summary>
        /// Gets static bus stop data from the cache. May return an empty string if the cache expires.
        /// </summary>
        public async Task<string> GetStopsAsync()
        {
            var cache = Connection.GetDatabase();
            var json = await cache.StringGetAsync(_stopsKey);
            return json;
        }

        /// <summary>
        /// Gets static data from the cache. May return an empty string if the cache expires.
        /// </summary>
        public async Task<string> GetStaticDataAsync()
        {
            var cache = Connection.GetDatabase();
            var json = await cache.StringGetAsync(_staticDataKey);
            return json;
        }

        /// <summary>
        /// Gets the platform tag dictionary from the cache. May return an empty string if the cache expires.
        /// </summary>
        public async Task<string> GetPlatformTagsAsync()
        {
            //Dictionary<string, string>
            var cache = Connection.GetDatabase();

            var json = await cache.StringGetAsync(_platformsKey);
            return json;
        }

        /// <summary>
        /// Gets schedule data from the cache. May return an empty string if the cache expires.
        /// </summary>
        public async Task<string> GetScheduleAsync()
        {
            var cache = Connection.GetDatabase();
            var json = await cache.StringGetAsync(_scheduleKey);
            return json;
        }
    }
}