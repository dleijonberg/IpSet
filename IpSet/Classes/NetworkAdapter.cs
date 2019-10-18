using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Management;

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
            public string Gateway;
            public string PriDNS;
            public string SecDNS;
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

                UnicastIPAddressInformationCollection ipAddresses = Adapters[i].GetIPProperties().UnicastAddresses;
                foreach (var a in ipAddresses)
                {
                    if (!a.Address.IsIPv6LinkLocal)
                    {
                        n.Ipv4Mask = a.IPv4Mask.ToString();
                        n.IpAddress = a.Address.ToString();
                        
                    }
                }

                GatewayIPAddressInformationCollection Gateways = Adapters[i].GetIPProperties().GatewayAddresses;
                foreach (var a in Gateways)
                {
                    if (!a.Address.IsIPv6LinkLocal)
                    {
                        n.Gateway = a.Address.ToString();
                    }
                }



                NicList.Add(n);
            }
        }

        public void SetNicInfo(int adapterNum, string ipAddress, string ipv4Mask, string gateway)
        {
            // Set IP address, Subnet mask, gateway etc.
        }
    }

    class Nics2
    {
        private ManagementClass _adapterConfig;
        private ManagementObjectCollection _networkCollection;

        public ManagementClass AdapterConfig
        {
            get
            {
                _adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
                return _adapterConfig;
            }
        }

        public ManagementObjectCollection NetworkCollection
        {
            get
            {
                _networkCollection = AdapterConfig.GetInstances();
                return _networkCollection;
            }
        }

        public struct NicInfo
        {
            public int num;
            public string Name;
            public string ID;
            public string[] IpAddress;
            public string Ipv4Mask;
            public string Gateway;
            public string PriDNS;
            public string SecDNS;
        }
        public List<NicInfo> NicList = new List<NicInfo>();


        public void GetNicInfo()
        {
            NicInfo n = new NicInfo();

            foreach (ManagementObject a in NetworkCollection)
            {
                n.Name = a.GetPropertyValue("Description").ToString();
                n.ID = a.GetPropertyValue("SettingID").ToString();
                n.IpAddress = (string[]) a.GetPropertyValue("IPAddress");
                NicList.Add(n);
            }
        }

        public Nics2()
        {
            GetNicInfo();
        }

    }
}
