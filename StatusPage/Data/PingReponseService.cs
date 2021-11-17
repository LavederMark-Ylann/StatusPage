using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Text;

namespace StatusPage.Data
{
    public class PingReponseService
    {
        private static readonly string[] Adresses = new[] { "www.google.com", "www.facebook.com", "92.123.109.47", "2a02:26f0:129:389::1aca" };

        public async Task<List<PingReply>> GetAllPingAsync()
        {
            int timeout = 1500;
            var tasks = Adresses.Select(ip => new Ping().SendPingAsync(ip, timeout));
            var results = await Task.WhenAll(tasks);

            return results.ToList();
        }

        public async Task<List<PingReponse>> GetPing()
        {
            var pingResults = await GetAllPingAsync();
            List<PingReponse> solvedNames = new();
            foreach (var ping in pingResults)
            {
                PingReponse reponse = new(ping);
                solvedNames.Add(reponse);
            }
            return solvedNames;
        }
    }
}
