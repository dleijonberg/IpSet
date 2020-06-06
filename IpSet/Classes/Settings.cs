using System.Collections.Generic;
using System.IO;

namespace IpSet
{
    class Settings
    {
        private static readonly string SettingsFile = ".\\settings.txt";

        public struct Setting
        {
            public int num;
            public string Name;
            public bool DHCP;
            public bool DynamicDNS;
            public string[] IpAddress;
            public string[] Ipv4Mask;
            public string[] Gateway;
            public string[] DNS;

            public void Init()
            {
                Name = "";
                //DHCP = new bool[1];
                //DynamicDNS = new bool[1];
                IpAddress = new string[1];
                Ipv4Mask = new string[1];
                Gateway = new string[2];
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
                if (s.IpAddress != null)
                {
                    for (int i = 0; i < s.IpAddress.Length; i++)
                    {
                        data += "IP-address " + (i + 1) + "=" + s.IpAddress[i] + "\r\n";
                        data += "Subnet " + (i + 1) + "=" + s.Ipv4Mask[i] + "\r\n";
                    }
                }
                if (s.Gateway != null)
                {
                    for (int i = 0; i < s.Gateway.Length; i++)
                        data += "Gateway " + (i + 1) + "=" + s.Gateway[i] + "\r\n";
                }
                if (s.DNS != null)
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
            int index = 0;

            Setting n = new Setting();
            StreamReader file = new StreamReader(SettingsFile);

            n.Init();

            settings.Clear();

            while (!file.EndOfStream)
            {
                string data = file.ReadLine();

                if (data.StartsWith("["))
                {
                    if (data == "[End]")
                    {
                        settings.Add(n);

                        n.Init();
                        index++;
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

                if (data.StartsWith("IP-address 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.IpAddress[0] = data;
                }

                /*                if (data.StartsWith("IP-address 2"))
                                {
                                    data = data.Substring(data.LastIndexOf("=") + 1);
                                    n.IpAddress[1] = data;
                                }
                */
                if (data.StartsWith("Subnet 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4Mask[0] = data;
                }
                /*
                                if (data.StartsWith("Subnet 2"))
                                {
                                    data = data.Substring(data.LastIndexOf("=") + 1);
                                    n.Ipv4Mask[1] = data;
                                }
                */
                if (data.StartsWith("Gateway 1"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Gateway[0] = data;
                }

                if (data.StartsWith("Gateway 2"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Gateway[1] = data;
                }

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
