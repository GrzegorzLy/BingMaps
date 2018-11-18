using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMaps.Core.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime Create { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
    }
}
