using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkAdapter;
using System.Net;

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
    }
}
