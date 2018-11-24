using AutoMapper;
using Bing.Spatial;
using BingMaps.Web.Models;

namespace BingMaps.Web.Config
{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {
            CreateMap<EuropeanPointOfInterest, PointViewModel>();
        }
    }
}