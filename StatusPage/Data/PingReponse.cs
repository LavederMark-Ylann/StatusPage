using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

namespace StatusPage.Data
{
    public class PingReponse
    {
        // Domaine ou IP
        public string Adresse { get; set; }
        public PingReply Reponse { get; set; }

        public PingReponse(string hostname, PingReply reply)
        {
            Adresse = hostname;
            Reponse = reply;
        }
    }
}
