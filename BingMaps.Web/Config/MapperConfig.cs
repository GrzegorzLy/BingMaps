using AutoMapper;
using Bing.Spatial;
using BingMaps.Core.Domain;
using BingMaps.Web.Models;

namespace BingMaps.Web.Config
{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {
            CreateMap<EuropeanPointOfInterest, PointViewModel>();

            CreateMap<PointViewModel, Point>()
                .ForMember(d => d.Address, m => m.MapFrom(o => o.AddressLine));
        }
    }
}