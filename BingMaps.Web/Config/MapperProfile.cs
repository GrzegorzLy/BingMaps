using AutoMapper;

namespace BingMaps.Web.Config
{
    public static class MappingProfile
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperConfig());
            });

            return config;
        }
    }
}