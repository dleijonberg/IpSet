using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

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
            if (!setting.DHCP)
            {
                string[] addr = new string[4];
                string[] mask = new string[4];
                string[] gate = new string[4];

                if (setting.Ipv4[0].Address != "")
                {
                    addr[0] = setting.Ipv4[0].Address;
                    mask[0] = setting.Ipv4[0].Mask;
                    gate[0] = setting.Ipv4[0].Gateway;
                
                    if (setting.Ipv4[1].Address != "")
                    {
                        addr[1] = setting.Ipv4[1].Address;
                        mask[1] = setting.Ipv4[1].Mask;
                        gate[1] = setting.Ipv4[1].Gateway;
                    }

                    if (setting.Ipv6[0].Address != "")
                    {
                        addr[2] = setting.Ipv6[0].Address;
                        mask[2] = setting.Ipv6[0].Mask;
                        gate[2] = setting.Ipv6[0].Gateway;
                    }

                    if (setting.Ipv6[1].Address != "")
                    {
                        addr[3] = setting.Ipv6[1].Address;
                        mask[3] = setting.Ipv6[1].Mask;
                        gate[3] = setting.Ipv6[1].Gateway;
                    }

                    object[] args = new object[2] { addr, mask };
                    var result = mo.InvokeMethod("EnableStatic", args);
                    if (result.ToString() != "0")
                    {
                        MessageBox.Show("WMI method 'EnableStatic' returned non-zero value: " + result);
                    }
    
                    object[] args2 = new object[1] { gate };
                    var result2 = mo.InvokeMethod("SetGateways", args2);
                    if (result2.ToString() != "0")
                    {
                        MessageBox.Show("WMI method 'SetGateways' returned non-zero value: " + result);
                    }
                }


            }
            else
            {
                mo.InvokeMethod("EnableDHCP", null);
            }

            // Set DNS to dynamic or static
            if (setting.DynamicDNS)
            {
                object[] args3 = new object[1] { false };
                mo.InvokeMethod("SetDynamicDNSRegistration", args3);
            }
            else
            {
                object[] args4 = new object[1] { setting.DNS };
                var result3 = mo.InvokeMethod("SetDNSServerSearchOrder", args4);
                if (result3.ToString() != "0")
                {
                    MessageBox.Show("WMI method 'SetDNSServerSearchOrder' returned non-zero value: " + result3);
                }
            }

            // Let adapters update before returning
            System.Threading.Thread.Sleep(1000);

            // Finally, release the adapter component
            mo.Dispose();
        }

        public Nics()
        {
            UpdateNicInfo();
        }

    }
}
