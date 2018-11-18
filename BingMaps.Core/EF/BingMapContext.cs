using BingMaps.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
