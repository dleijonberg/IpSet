using System.Collections.Generic;
using System.Management;

namespace NetworkAdapter
{
    class Nics
    {
        private ManagementClass _adapterClass;
        private ManagementObjectCollection _adapterCollection;

        public ManagementClass Adapters
        {
            get
            {
                _adapterClass = new ManagementClass("Win32_NetworkAdapter");
                return _adapterClass;
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

        public struct NicInfo
        {
            public string DeviceID;
            public string Name;
            public string Description;
            public bool NetEnabled;
            public bool DHCP;
            public string[] IpAddress;
            public string[] SubnetMask;
            public string[] Gateway;
            public string[] DNS;
        }
        public List<NicInfo> NicList = new List<NicInfo>();

        public string GetDeviceIDFromNum(int num)
        {
            var adapter = NicList[num];
            return adapter.DeviceID;
        }


        //  Updates the NicInfo struct
        //  Uses WMI to extract information about network adapters
        public void UpdateNicInfo()
        {
            NicInfo n = new NicInfo();
            NicList.Clear();

            foreach (ManagementObject a in AdapterCollection)
            {
                if ((bool)a.GetPropertyValue("PhysicalAdapter"))
                {
                    // Get info from AdapterColection
                    n.DeviceID = (string)a.GetPropertyValue("DeviceID");
                    n.Name = (string)a.GetPropertyValue("NetConnectionID");
                    n.Description = (string)a.GetPropertyValue("Description");
                    n.NetEnabled = (bool)a.GetPropertyValue("NetEnabled");

                    // Fetch one specific adapter configuration based on DeviceID
                    ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + n.DeviceID);

                    // Get IP info from that configuration
                    n.DHCP = (bool)mo.GetPropertyValue("DHCPEnabled");
                    n.IpAddress = (string[])mo.GetPropertyValue("IPAddress");
                    n.SubnetMask = (string[])mo.GetPropertyValue("IPSubnet");
                    n.Gateway = (string[])mo.GetPropertyValue("DefaultIPGateway");
                    n.DNS = (string[])mo.GetPropertyValue("DNSServerSearchOrder");

                    NicList.Add(n);
                    mo.Dispose();
                }
            }
        }

        //  Sets adapter configuration on the specified network adapter by DeviceID
        public void SetNicInfo(string DeviceID, IpSet.Settings.Setting setting)
        {
            // Fetch the adapter component we want to change
            ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + DeviceID);

            // Check if DHCP is off, if so set static IP
            if (!setting.DHCP && setting.Ipv4Address != "" && setting.Ipv4Mask != "")
            {
                string[] addr = new string[2] { setting.Ipv4Address, "" };
                string[] mask = new string[2] { setting.Ipv4Mask, "" };
                object[] args = new object[2] { addr, mask };
                mo.InvokeMethod("EnableStatic", args);

                if (setting.Gateway != "")
                {
                    addr = new string[1] { setting.Gateway };
                    args = new object[1] { addr };
                    mo.InvokeMethod("SetGateways", args);
                }
 
                if (setting.DNS[0] != "")
                {
                    args = new object[1] { setting.DNS };
                    mo.InvokeMethod("SetDNSServerSearchOrder", args);
                }
            }
            else
            {
                mo.InvokeMethod("EnableDHCP", null);
                if (setting.DynamicDNS)
                {
                    object[] args = new object[1] { false };
                    var result = mo.InvokeMethod("SetDynamicDNSRegistration", args);
                }
                else
                {
                    object[] args = new object[1] { setting.DNS };
                    mo.InvokeMethod("SetDNSServerSearchOrder", args);
                }
                System.Threading.Thread.Sleep(1000);
            }

            // Finally, release the adapter component
            mo.Dispose();
        }

        public Nics()
        {
            UpdateNicInfo();
        }

    }
}
