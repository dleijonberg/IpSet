using System.Collections.Generic;
using System.IO;

namespace IpSet
{
    class Settings
    {
        private static readonly string SettingsFile = ".\\settings.txt";

        public struct IpStruct
        {
            public string Address;
            public string Mask;
            public string Gateway;
        }

        public struct Setting
        {
            public int num;
            public string Name;
            public bool DHCP;
            public IpStruct[] Ipv4;
            public IpStruct[] Ipv6;
            public bool DynamicDNS;
            public string[] DNS;

            public void Init()
            {
                Name = "";
                DHCP = false;
                DynamicDNS = false;
                Ipv4 = new IpStruct[2];
                Ipv6 = new IpStruct[2];
                DNS = new string[2];
            }

            public void InitArrays()
            {
                Ipv4 = new IpStruct[2];
                Ipv6 = new IpStruct[2];
                DNS = new string[2];
            }
        }

        public List<Setting> SettingsList = new List<Setting>();

        public static void SaveFile(List<Setting> settings)
        {
            string data = "";
            StreamWriter file = new StreamWriter(SettingsFile);

            foreach (var s in settings)
            {
                data += "[" + s.Name + "]\r\n";

                data += "DHCP=" + s.DHCP + "\r\n";
                data += "DynamicDNS=" + s.DynamicDNS + "\r\n";
                if (s.Ipv4[0].Address != "")
                {
                    data += "Ipv4-address 1=" + s.Ipv4[0].Address + "\r\n";
                    data += "Ipv4-subnet 1=" + s.Ipv4[0].Mask + "\r\n";
                    data += "Ipv4-gateway 1=" + s.Ipv4[0].Gateway + "\r\n";
                }
                if (s.Ipv4[1].Address != "")
                {
                    data += "Ipv4-address 2=" + s.Ipv4[1].Address + "\r\n";
                    data += "Ipv4-subnet 2=" + s.Ipv4[1].Mask + "\r\n";
                    data += "Ipv4-gateway 2=" + s.Ipv4[1].Gateway + "\r\n";
                }
                if (s.Ipv6[0].Address != "")
                {
                    data += "Ipv6-address 1=" + s.Ipv6[0].Address + "\r\n";
                    data += "Ipv6-subnet 1=" + s.Ipv6[0].Mask + "\r\n";
                    data += "Ipv6-gateway 1=" + s.Ipv6[0].Gateway + "\r\n";
                }
                if (s.Ipv6[1].Address != "")
                {
                    data += "Ipv6-address 2=" + s.Ipv6[1].Address + "\r\n";
                    data += "Ipv6-subnet 2=" + s.Ipv6[1].Mask + "\r\n";
                    data += "Ipv6-gateway 2=" + s.Ipv6[1].Gateway + "\r\n";
                }

                if (s.DNS[0] != "")
                {
                    for (int i = 0; i < s.DNS.Length; i++)
                        data += "DNS " + (i + 1) + "=" + s.DNS[i] + "\r\n";
                }

                data += "[End]\r\n";
            }

            file.Write(data);
            file.Close();
        }

        public static void OpenFile(List<Setting> settings)
        {
            // NIC index for ListView object
            int index = 0;

            // Check if file exists. If not, create it and close it
            if (!File.Exists(SettingsFile))
                File.Create(SettingsFile).Close();

            // Open the file as a stream
            StreamReader file = new StreamReader(SettingsFile);

            // Create an instance for NIC settings to fill from loaded file
            Setting n = new Setting();
            n.Init();

            settings.Clear();

            while (!file.EndOfStream)
            {
                string data = file.ReadLine();

                // Line has [] markers (either [End] or [NIC name])
                // Each NIC setting begins with [Name] and ends with [End]
                if (data.StartsWith("["))
                {
                    if (data == "[End]")
                    {
                        settings.Add(n);
                        index++;

                        n.Init();
                    }
                    else
                    { 
                        data = data.Replace("[", "");
                        data = data.Replace("]", "");

                        n.Name = data;
                        n.num = index;
                        data = "";
                    }
                }

                // Load settings from settings file
                if (data.StartsWith("DHCP"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.DHCP = bool.Parse(data);
                }

                if (data.StartsWith("DynamicDNS"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.DynamicDNS = bool.Parse(data);
                }

                if (data.StartsWith("Ipv4-address 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4[0].Address = data;
                }
                if (data.StartsWith("Ipv4-address 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4[1].Address = data;
                }
                if (data.StartsWith("Ipv4-subnet 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4[0].Mask = data;
                }
                if (data.StartsWith("Ipv4-subnet 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4[1].Mask = data;
                }
                if (data.StartsWith("Ipv4-gateway 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4[0].Gateway = data;
                }
                if (data.StartsWith("Ipv4-gateway 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4[1].Gateway = data;
                }


                if (data.StartsWith("Ipv6-address 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv6[0].Address = data;
                }
                if (data.StartsWith("Ipv6-address 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv6[1].Address = data;
                }
                if (data.StartsWith("Ipv6-subnet 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv6[0].Mask = data;
                }
                if (data.StartsWith("Ipv6-subnet 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv6[1].Mask = data;
                }
                if (data.StartsWith("Ipv6-gateway 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv6[0].Gateway = data;
                }
                if (data.StartsWith("Ipv6-gateway 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv6[1].Gateway = data;
                }


                // DNS
                if (data.StartsWith("DNS 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.DNS[0] = data;
                }
                if (data.StartsWith("DNS 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.DNS[1] = data;
                }
            }

            file.Close();
        }
    }
}
