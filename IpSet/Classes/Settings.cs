using System.Collections.Generic;
using System.IO;
using System.Net;

namespace IpSet
{
    class Settings
    {
        private static readonly string SettingsFile = ".\\settings.txt";

        public struct Setting
        {
            public string Name;
            public bool DHCP;
            public bool DynamicDNS;
            public string Ipv4Address;
            public string Ipv4Mask;
            public string Gateway;
            public string[] DNS;
            public bool valid;

            public void Init()
            {
                Name = "";
                DHCP = false;
                DynamicDNS = false;
                Ipv4Address = "";
                Ipv4Mask = "";
                Gateway = "";
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
                if (s.Ipv4Address != null)
                {
                    data += "Ipv4-address=" + s.Ipv4Address + "\r\n";
                    data += "Ipv4-subnet=" + s.Ipv4Mask + "\r\n";
                }
                if (s.Gateway != null)
                {
                    data += "Gateway=" + s.Gateway + "\r\n";
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

            if (!File.Exists(SettingsFile))
            {
                File.Create(SettingsFile).Close();
            }

            StreamReader file = new StreamReader(SettingsFile);

            Setting n = new Setting();
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
                        index++;

                        n.Init();
                    }
                    else
                    {
                        data = data.Replace("[", "");
                        data = data.Replace("]", "");

                        n.Name = data;
                        //n.num = index;
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

                if (data.StartsWith("Ipv4-address"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4Address = data;
                }

                if (data.StartsWith("Ipv4-subnet"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Ipv4Mask = data;
                }

                if (data.StartsWith("Gateway"))
                {
                    data = data.Substring(data.LastIndexOf("=") + 1);
                    n.Gateway = data;
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
