using NHLAPI.Domain;
using NHLAPI.Domain.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLAPI.Service
{
    public class NHLService : INHLService
    {
        readonly RestClient _client;

        public NHLService()
        {
            _client = new RestClient("https://statsapi.web.nhl.com/");

        }
        public async Task<Teams> GetAllTeams()
        {
            return await _client.GetAsync<Teams>(_client);
        }
    }
}
