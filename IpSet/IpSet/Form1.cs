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
        internal Nics NicObject = new Nics();
        private List<Nics.NicInfo> SettingsList = new List<Nics.NicInfo>();

        public Form1()
        {
            InitializeComponent();

            // Populate controls
            // ComboBox for network adapters
            UpdateCbNicsList();
            cbNics.SelectedIndexChanged += new EventHandler(cbNics_OnSelectedIndexChanged);

        }


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
            lstSettingsList.BeginUpdate();
            lstSettingsList.Items.Clear();

            foreach (var nic in SettingsList)
                lstSettingsList.Items.Add(nic.Name);

            lstSettingsList.EndUpdate();
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            if (tbIpAddress.Text != "")
                SettingsList[lstSettingsList.SelectedIndices[0]].IpAddress[0] = tbIpAddress.Text;
            if (tbSubnetMask.Text != "")
                SettingsList[lstSettingsList.SelectedIndices[0]].Ipv4Mask[0] = tbSubnetMask.Text;
            if (tbGateway.Text != "")
                SettingsList[lstSettingsList.SelectedIndices[0]].Gateway[0] = tbGateway.Text;
            if (tbPriDNS.Text != "")
                SettingsList[lstSettingsList.SelectedIndices[0]].DNS[0] = tbPriDNS.Text;
            if (tbSecDNS.Text != "")
                SettingsList[lstSettingsList.SelectedIndices[0]].DNS[1] = tbSecDNS.Text;

            Settings.SaveFile(SettingsList);
        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            Nics.NicInfo n = new Nics.NicInfo();

            n.Init();
            n.Name = "New entry";
            n.num = SettingsList.Count;

            SettingsList.Add(n);

            UpdateSettingsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.OpenFile(SettingsList);

            UpdateSettingsList();
        }

        private void lstSettingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lstSender = (ListView)sender;

            if (lstSender.SelectedIndices.Count > 0)
            {
                var newSetting = SettingsList.Find(x => x.num == lstSender.SelectedIndices[0]);

                tbIpAddress.Text = (newSetting.IpAddress != null) ? newSetting.IpAddress[0] : "";
                tbSubnetMask.Text = (newSetting.Ipv4Mask != null) ? newSetting.Ipv4Mask[0] : "";
                tbGateway.Text = (newSetting.Gateway != null) ? newSetting.Gateway[0] : "";
                tbPriDNS.Text = (newSetting.DNS != null) ? newSetting.DNS[0] : "";
                tbSecDNS.Text = (newSetting.DNS != null && newSetting.DNS.Length > 1) ? newSetting.DNS[1] : "";
            }
        }

        private void lstSettingsList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListView lstSender = (ListView)sender;

            var newname = e.Label;
            int index = SettingsList.FindIndex(x => x.num == lstSender.SelectedIndices[0]);

            Nics.NicInfo tempNic = SettingsList[index];
            tempNic.Name = newname;
            SettingsList[index] = tempNic;
        }

        private void lstSettingsList_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {

        }
    }
}
