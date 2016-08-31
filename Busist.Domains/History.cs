using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busist.Domains
{
    public class History
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatenTime { get; set; }
        public virtual GeoCoordinate GeoCoordinate { get; set; }
    
        
    }
}
