using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NetworkAdapter;
using Microsoft.Win32.SafeHandles;

namespace IpSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Populate controls
            // ComboBox for network adapters
            UpdateCbNicsList();
            cbNics.SelectedIndexChanged += new EventHandler(cbNics_OnSelectedIndexChanged);

        }

        internal Nics NicObject = new Nics();
        private List<Nics.NicInfo> SettingsList = new List<Nics.NicInfo>();


        public void UpdateCbNicsList()
        {
            cbNics.Items.Clear();

            foreach (var nic in NicObject.NicList)
            {
                cbNics.Items.Add(nic.Name);
            }
            cbNics.SelectedIndex = 0;
        }

        public void cbNics_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;

            this.lbIpAddress.Text = "";
            this.lbIpAddressHeader.Text = "";

            for (int i = 0; i < NicObject.NicList[cbSender.SelectedIndex].IpAddress.Length; i++)
            { 
                this.lbIpAddress.Text += NicObject.NicList[cbSender.SelectedIndex].IpAddress[i] + "\n\r"
                + NicObject.NicList[cbSender.SelectedIndex].Ipv4Mask[i] + "\n\r\n\r";

                this.lbIpAddressHeader.Text += "IP-address " + (i + 1) + "\n\rSubnet mask " + (i + 1) + "\n\r\n\r";
            }

            this.lbGateway.Text = NicObject.NicList[cbSender.SelectedIndex].Gateway[0];

            if (NicObject.NicList[cbSender.SelectedIndex].DNS.Length > 0)
                this.lbPriDNS.Text = NicObject.NicList[cbSender.SelectedIndex].DNS[0];
            else
                this.lbPriDNS.Text = "";

            if (NicObject.NicList[cbSender.SelectedIndex].DNS.Length > 1)
                this.lbSecDNS.Text = NicObject.NicList[cbSender.SelectedIndex].DNS[1];
            else
                this.lbSecDNS.Text = "";
        }

        private void UpdateSettingsList()
        {
            lstSettingsList.Items.Clear();

            foreach (var nic in SettingsList)
                lstSettingsList.Items.Add(nic.Name);
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            string data;
            StreamWriter file = new StreamWriter("testfile.txt");

            data = "[Settings list]";

            foreach(var s in SettingsList)
            {
                data += "Name=" + s.Name + "\r\n";
                foreach (var ip in s.IpAddress)
                    data += "IP-address=" + ip + "\r\n";
                foreach (var sn in s.Ipv4Mask)
                    data += "Subnet=" + sn + "\r\n";
                foreach (var gw in s.Gateway)
                    data += "Gateway=" + gw + "\r\n";
                foreach (var dns in s.DNS)
                    data += "DNS=" + dns + "\r\n";
            }

            file.Write(data);
            file.Close();

        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            Nics.NicInfo n = new Nics.NicInfo();

            n.Name = "New entry";

            SettingsList.Add(n);

            UpdateSettingsList();
        }
    }
}
