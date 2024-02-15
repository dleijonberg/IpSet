using IpSet;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
        public void UpdateNicList()
        {
            NicInfo n = new NicInfo();
            NicList.Clear();

            foreach (ManagementObject a in AdapterCollection)
            {
                if ((bool)a.GetPropertyValue("PhysicalAdapter"))
                {
                    // Get info from AdapterCollection
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

        public void UpdateNicInfo(int index)
        {
            NicInfo info = NicList[index];

            foreach(ManagementObject a in AdapterCollection)
            {
                if ((string)a.GetPropertyValue("DeviceID") == info.DeviceID)
                {
                    info.NetEnabled = (bool)a.GetPropertyValue("NetEnabled");
                    break;
                }
            }


            // Get the management object from Windows
            ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + info.DeviceID);

            // Get IP info
            info.DHCP = (bool)mo.GetPropertyValue("DHCPEnabled");
            info.IpAddress = (string[])mo.GetPropertyValue("IPAddress");
            info.SubnetMask = (string[])mo.GetPropertyValue("IPSubnet");
            info.Gateway = (string[])mo.GetPropertyValue("DefaultIPGateway");
            info.DNS = (string[])mo.GetPropertyValue("DNSServerSearchOrder");

            NicList[index] = info;

            // Dispose of the management object when done
            mo.Dispose();
        }

        //  Sets adapter configuration on the specified network adapter by DeviceID
        public bool SetNicInfo(string DeviceID, IpSet.Settings.Setting setting)
        {
            if (setting.valid)
            {
                try
                {
                    // Fetch the adapter component we want to change
                    ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + DeviceID);

                    string[] addr, mask;
                    object[] args;

                    // Check if DHCP is off, if so set static IP
                    if (!setting.DHCP)
                    {
                        // EnableStatic sets ip address and subnet mask
                        addr = new string[] { setting.Ipv4Address };
                        mask = new string[] { setting.Ipv4Mask };
                        args = new object[] { addr, mask };
                        mo.InvokeMethod("EnableStatic", args);

                        // Set gateway address if entered
                        if (setting.Gateway != "...")
                        {
                            addr = new string[] { setting.Gateway };
                            args = new object[] { addr };
                            mo.InvokeMethod("SetGateways", args);
                        }
                        else
                        {
                            addr = new string[] { setting.Ipv4Address };
                            args = new object[] { addr };
                            mo.InvokeMethod("SetGateways", args);
                        }

                    }
                    else
                    {
                        mo.InvokeMethod("EnableDHCP", null);
                    }

                    // Set static DNS if dynamic DNS is unchecked and addresses contains something
                    if (!setting.DynamicDNS && (setting.DNS[0] != "..." || setting.DNS[1] != "..."))
                    {
                        var dnsAddr = new List<string>();

                        if (setting.DNS[0] != "...")
                            dnsAddr.Add(setting.DNS[0]);

                        if (setting.DNS[1] != "...")
                            dnsAddr.Add(setting.DNS[1]);

                        args = new object[1];
                        args[0] = dnsAddr.ToArray();
                        mo.InvokeMethod("SetDNSServerSearchOrder", args);
                    }
                    else
                    {
                        // SetDNSServerSearchOrder with empty input deletes all entries
                        args = new object[1];
                        mo.InvokeMethod("SetDNSServerSearchOrder", args);
                    }
                    //System.Threading.Thread.Sleep(1000);

                    // Finally, release the adapter component
                    mo.Dispose();
                }

                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            return true;
        }

        public Nics()
        {
            UpdateNicList();
        }

    }
}
