using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMaps.Core.Domain
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        public DateTime CreateAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public Entity()
        {
            CreateAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
