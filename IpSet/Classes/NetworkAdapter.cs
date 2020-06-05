using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

namespace NetworkAdapter
{
    class Nics
    {
        private ManagementClass _adapterClass;
        private ManagementClass _adapterConfigClass;
        private ManagementObjectCollection _adapterCollection;
        private ManagementObjectCollection _settingsCollection;

        public ManagementClass Adapters
        {
            get
            {
                _adapterClass = new ManagementClass("Win32_NetworkAdapter");
                return _adapterClass;
            }
        }

        public ManagementClass AdapterConfig
        {
            get
            {
                _adapterConfigClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
                return _adapterConfigClass;
            }
        }

        public ManagementObjectCollection AdapterCollection
        {
            get
            {
                _adapterCollection = Adapters.GetInstances();
                return _adapterCollection;
            }
        }

        public ManagementObjectCollection SettingsCollection
        {
            get
            {
                _settingsCollection = AdapterConfig.GetInstances();
                return _settingsCollection;
            }
        }


        public struct NicInfo
        {
            public int num;
            public string DeviceID;
            public string Name;
            public string Description;
            public bool DHCP;
            public string[] IpAddress;
            public string[] Ipv4Mask;
            public string[] Gateway;
            public string[] DNS;
        }
        public List<NicInfo> NicList = new List<NicInfo>();

        public string GetDeviceIDFromNum(int num)
        {
            var adapter = NicList[num];
            return adapter.DeviceID;
        }

        public void GetNicInfo()
        {
            NicInfo n = new NicInfo();

            foreach (ManagementObject a in AdapterCollection)
            {
                if ((bool)a.GetPropertyValue("PhysicalAdapter"))
                {
                    // Get info from AdapterColection
                    n.DeviceID = (string)a.GetPropertyValue("DeviceID");
                    n.Name = (string)a.GetPropertyValue("NetConnectionID");
                    n.Description = (string)a.GetPropertyValue("Description");

                    // Fetch one specific adapter configuration based on DeviceID
                    ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + Convert.ToUInt32(n.DeviceID));

                    // Get IP info from that configuration
                    n.DHCP = (bool)mo.GetPropertyValue("DHCPEnabled");
                    n.IpAddress = (string[])mo.GetPropertyValue("IPAddress");
                    n.Ipv4Mask = (string[])mo.GetPropertyValue("IPSubnet");
                    n.Gateway = (string[])mo.GetPropertyValue("DefaultIPGateway");
                    n.DNS = (string[])mo.GetPropertyValue("DNSServerSearchOrder");

                    NicList.Add(n);
                }
            }
        }

        public void SetNicInfo(string DeviceID, IpSet.Settings.Setting setting)
        {
            ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + Convert.ToUInt32(DeviceID));
            if (!setting.DHCP[0])
            {
                if (setting.IpAddress != null)
                {
                    Object[] args = new object[2] { setting.IpAddress, setting.Ipv4Mask };
                    var result = mo.InvokeMethod("EnableStatic", args);
                }
                if (setting.Gateway != null)
                {
                    Object[] args = new object[1] { setting.Gateway };
                    mo.InvokeMethod("SetGateways", args);
                }
                if (setting.DNS != null)
                {
                    Object[] args = new object[1] { setting.DNS };
                    mo.InvokeMethod("SetDNSServerSearchOrder", args);
                }
            }
            else
            {
                mo.InvokeMethod("EnableDHCP", null);
            }
        }

        public Nics()
        {
            GetNicInfo();
        }

    }
}
