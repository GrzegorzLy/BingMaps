using Bing;
using Bing.Spatial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMaps.Core.Services
{
    public class BingMapsService : IPointService
    {
        private const string _key = "Ailk8kczQ-_YrMMVqP50Jnn1CQ74MGsUm7L3yk077dkfwQXGHPfiz4L8QqPY62rc";
        private SpatialDataClient _client;
        private const double _radius = 1;
        private const string _dataSource = "EuropePOI";
        public BingMapsService() 
        {
            _client = new SpatialDataClient(_key);
        }

        public async Task<ICollection<EuropeanPointOfInterest>> GetListOfPointAsync(string addresses)
        {
            return await _client.Find<EuropeanPointOfInterest>(_dataSource, addresses, _radius);
        }

        public async Task GetPointById(string id) => await _client.GetById<EuropeanPointOfInterest>(_dataSource, id);

    }
}
