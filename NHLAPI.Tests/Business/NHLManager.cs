using NHLAPI.Domain;
using NHLAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLAPI.Tests.Business
{
    public class NHLManager : INHLManager
    {
        private readonly INHLService _NHLService;

        public NHLManager(INHLService NHLService)
        {
            _NHLService = NHLService;
        }
        public Teams GetAllTeams()
        {
            return _NHLService.GetAllTeams();
        }
    }
}
