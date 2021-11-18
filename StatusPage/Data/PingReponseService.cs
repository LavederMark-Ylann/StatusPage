using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;

namespace StatusPage.Data
{
    public class PingReponseService
    {
        private static readonly string[] Adresses = new[] { "www.google.com", "www.facebook.com", "www.apple.com", "www.microsoft.com" };

        public async Task<List<PingReponse>> GetPing()
        {
            int timeout = 1500;
            List<PingReponse> listOfPing = new();
            foreach (var url in Adresses)
            {
                PingReponse ping = new PingReponse(url, await new Ping().SendPingAsync(url, timeout));
                listOfPing.Add(ping);
            }
            return listOfPing;
        }

    }
}
