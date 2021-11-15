using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatusPage.Data
{
    public class PingSenderService
    {
        public string[] Adresses = new[] { "https://www.google.com", "www.facebook.com", "92.123.109.47", "2a02:26f0:129:389::1aca" };

        public Task<PingSender[]> GetPingAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(0, Adresses.Length).Select(index => new PingSender
            {
                Adresse = Adresses[index]
            }).ToArray());
        }
    }
}
