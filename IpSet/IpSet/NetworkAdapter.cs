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
 
        public Nics()
        {
            UpdateNics();
        }
        public struct NicInfo
        {
            public int num;
            public string Name;
            public string ID;
            public string IpAddress;
            public string Ipv4Mask;
        }

        public List<NicInfo> NicList = new List<NicInfo>();

        private void UpdateNics()
        {
            NicInfo n = new NicInfo();

            NicList.Clear();

            for(int i = 0; i < Adapters.Length; i++)
            {
                n.num = i;
                n.Name = Adapters[i].Name;
                n.ID = Adapters[i].Id;

                var ipAddresses = Adapters[i].GetIPProperties().UnicastAddresses;
                foreach (var a in ipAddresses)
                {
                    if (!a.Address.IsIPv6LinkLocal)
                    {
                        n.Ipv4Mask = a.IPv4Mask.ToString();
                        n.IpAddress = a.Address.ToString();
                    }
                }

                NicList.Add(n);
            }
        }

        public NicInfo GetNicInfo(string NicName)
        {
            NicInfo n = new NicInfo();
//            NetworkInterface[] a = Adapters;

            UpdateNics();

            foreach (var nic in Adapters)
            {
                if (NicName == nic.Name)
                {

                }
            }
            return n;
        }


    }
}
