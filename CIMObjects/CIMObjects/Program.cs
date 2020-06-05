using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace CIMObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Nics NicObject = new Nics();
            int input=0;

            while (input != 3)
            {
                Console.WriteLine("1: List, 2: Set IP");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        foreach (ManagementObject a in NicObject.AdapterCollection)
                        {
                            if ((bool)a.GetPropertyValue("PhysicalAdapter"))
                            {
                                Console.WriteLine("DeviceID: " + a.GetPropertyValue("DeviceID"));
                                Nics.nicSettings aSettings = NicObject.getNicSettings((string)a.GetPropertyValue("DeviceID"));
                                Console.WriteLine("Name: " + a.GetPropertyValue("NetConnectionID"));
                                Console.WriteLine("Desc: " + a.GetPropertyValue("Description"));
                                Console.WriteLine("Enabled: " + a.GetPropertyValue("NetEnabled"));
                                /*if (aSettings.IpAddress != null)
                                {
                                    Console.WriteLine("IpAddress 1: " + aSettings.IpAddress[0]);
                                    Console.WriteLine("IpAddress 2: " + aSettings.IpAddress[1]);
                                }*/
                                Console.WriteLine("Address: " + a.GetPropertyValue("PermanentAddress"));

                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        
                        Nics.nicSettings settings = new Nics.nicSettings();
                        settings.IpAddress = new string[1];
                        settings.SubnetMask = new string[1];

                        Console.WriteLine();
                        Console.WriteLine("DeviceID: ");
                        string DeviceID = Console.ReadLine();
                        Console.WriteLine("New IP: ");
                        string ipaddr = Console.ReadLine();
                        settings.IpAddress[0] = ipaddr;
                        //settings.IpAddress[1] = null;
                        settings.SubnetMask[0] = "255.255.255.0";
                        //settings.SubnetMask[1] = null;
                        NicObject.setNicSettings(DeviceID, settings);
                        break;
                    case 3:
                        return;
                }
            }

        }
    }

    class Nics
    {
        public struct nicSettings
        {
            public string[] IpAddress;
            public string[] SubnetMask;
        }

        List<nicSettings> settingsList = new List<nicSettings>();

        private ManagementClass adapterClass = new ManagementClass("Win32_NetworkAdapter");

        public ManagementObjectCollection AdapterCollection
        {
            get
            {
                ManagementObjectCollection collection = adapterClass.GetInstances();
                return collection;
            }
        }

        private ManagementClass configClass = new ManagementClass("Win32_NetworkAdapterConfiguration");

        public ManagementObjectCollection SettingsCollection
        {
            get
            {
                ManagementObjectCollection collection = configClass.GetInstances();
                return collection;
            }
        }

        public ManagementObject getMO(string DeviceID)
        {
            ManagementObject source = new ManagementObject();
            foreach(ManagementObject obj in SettingsCollection)
            {
                if ((string)obj.GetPropertyValue("DeviceID") == DeviceID)
                {
                    source = obj;
                    break;
                }
            }
            return source;
        }

        public nicSettings getNicSettings(string DeviceID)
        {
            nicSettings result;
            //            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Index=" + DeviceID);
            //            ManagementObjectCollection settingsCollection = searcher.Get();
            //            ManagementObjectCollection.ManagementObjectEnumerator Enumerator = settingsCollection.GetEnumerator();
            //            Enumerator.MoveNext();
            //            ManagementBaseObject Object1 = Enumerator.Current;
            ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + Convert.ToUInt32(DeviceID));

            result.IpAddress = (string[])mo.GetPropertyValue("IPAddress");
            result.SubnetMask = (string[])mo.GetPropertyValue("IPSubnet");
            return result;
        }

        public void setNicSettings(string DeviceID, nicSettings settings)
        {
            Object[] args = new Object[2] { settings.IpAddress, settings.SubnetMask };
            //            args[0] = new string[2] { settings.IpAddress[0], settings.IpAddress[1] };
            //            args[1] = new string[2] { settings.SubnetMask[0], settings.SubnetMask[1] };
            ManagementObject mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + Convert.ToUInt32(DeviceID));
            mo.InvokeMethod("EnableStatic", args);
        }
        
        public Nics()
        {
            //Adapters = _adapterCollection;
        }
    }
}
