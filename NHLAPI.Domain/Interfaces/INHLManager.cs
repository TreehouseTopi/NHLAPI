using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLAPI.Domain.Interfaces
{
    public interface INHLManager
    {
        Teams GetAllTeams();
    }
}
