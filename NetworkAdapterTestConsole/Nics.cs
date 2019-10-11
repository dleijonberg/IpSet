using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace NetworkAdapter
{
    class Nics
    {
        private NetworkInterface[] _adapters;
        
        public NetworkInterface[] Adapters 
        {
            get 
            {
                _adapters = NetworkInterface.GetAllNetworkInterfaces();
                return _adapters;
            }
        }
        public struct NicInfo
        {
            public string Name;
            public string ID;
            public string[] IpAddress;
            public string[] Ipv4Mask;
        }

        public List<NicInfo> NicList = new List<NicInfo>();

        public void UpdateNics()
        {
            var a = Adapters;
            NicInfo n = new NicInfo();
            int i = 0;
            NicList.Clear();

            foreach (var nic in a)
            {
                n.Name = nic.Name;
                n.ID = nic.Id;
                NicList.Add(n);
            }
        }

        public NicInfo GetNicInfo(string NicName)
        {
            NicInfo n = new NicInfo();
            UpdateNics();
            var a = Adapters;

            foreach (var nic in a)
            {
                if (NicName == nic.Name)
                {
                    var ipAddresses = nic.GetIPProperties().UnicastAddresses;
                    for (int i = 0; i < ipAddresses.Count; i++)
                    {
                        if (!ipAddresses[i].Address.IsIPv6LinkLocal && !ipAddresses[i].Address.IsIPv6SiteLocal)
                        {
                            n.Ipv4Mask[i] = ipAddresses[i].IPv4Mask.ToString();
                            n.IpAddress[i] = ipAddresses[i].Address.ToString();
                        }
                    }
                }
            }
            return n;
        }


    }
}
