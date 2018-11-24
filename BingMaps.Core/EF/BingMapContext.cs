using BingMaps.Core.Domain;
using System.Data.Entity;

namespace BingMaps.Core.EF
{
    public class BingMapContext : DbContext
    {
        public DbSet<Point> Point { get; set; }

        public BingMapContext()
        : base("name=BingMapContext")
        {
        }

    }
}
