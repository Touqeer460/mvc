using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busist.Domains
{
    public class IDbSource
    {
        IQueryable<Users> User { get; set; }
        IQueryable<History> Histories { get; set; }
    }
}
