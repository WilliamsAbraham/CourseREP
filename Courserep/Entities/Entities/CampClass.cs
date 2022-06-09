using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
     public class CampClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CampClassType Type { get; set; } = CampClassType.Internal;

    }

    public enum CampClassType { Internal,External}
}
