using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace NetworkAdapter
{
    class Nics
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
            public string[] Ipv4Mask;
            public string[] Gateway;
            public string[] DNS;
        }
        public List<NicInfo> NicList = new List<NicInfo>();


        public void GetNicInfo()
        {
            NicInfo n = new NicInfo();

            foreach (ManagementObject a in NetworkCollection)
            {
                n.Name = a.GetPropertyValue("Description").ToString();
                n.ID = a.GetPropertyValue("SettingID").ToString();
                n.IpAddress = (string[])a.GetPropertyValue("IPAddress");
                n.Ipv4Mask = (string[])a.GetPropertyValue("IPSubnet");
                n.Gateway = (string[])a.GetPropertyValue("DefaultIPGateway");
                n.DNS = (string[])a.GetPropertyValue("DNSServerSearchOrder");
                NicList.Add(n);
            }
        }

        public Nics()
        {
            GetNicInfo();
        }

    }
}
