using Bing.Spatial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMaps.Core.Services
{
    public interface IPointService
    {
        Task GetPointById(string id);
        Task<ICollection<EuropeanPointOfInterest>> GetListOfPointAsync(string addresses);
    }
}
