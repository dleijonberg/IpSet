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

namespace IpSet
{
    public partial class Form1 : Form
    {
        internal Nics NicObject = new Nics();
        internal Settings Settings = new Settings();

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
            if (NicObject.NicList[cbSender.SelectedIndex].IpAddress != null)
            {
                for (int i = 0; i < NicObject.NicList[cbSender.SelectedIndex].IpAddress.Length; i++)
                {
                    this.lbIpAddress.Text += NicObject.NicList[cbSender.SelectedIndex].IpAddress[i] + "\n\r"
                    + NicObject.NicList[cbSender.SelectedIndex].Ipv4Mask[i] + "\n\r\n\r";

                    this.lbIpAddressHeader.Text += "IP-address " + (i + 1) + "\n\rSubnet mask " + (i + 1) + "\n\r\n\r";
                }
            }

            if (NicObject.NicList[cbSender.SelectedIndex].Gateway != null)
            {
                for (int i = 0; i < NicObject.NicList[cbSender.SelectedIndex].Gateway.Length; i++)
                {
                    this.lbGateway.Text += NicObject.NicList[cbSender.SelectedIndex].Gateway[i] + "\r\n";
                }
            }
            if (NicObject.NicList[cbSender.SelectedIndex].DNS != null)
            {
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

        private void UpdateSettingsList()
        {
            lstSettingsList.BeginUpdate();
            lstSettingsList.Items.Clear();

            foreach (var s in Settings.SettingsList)
                lstSettingsList.Items.Add(s.Name);

            lstSettingsList.EndUpdate();
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            int index = lstSettingsList.SelectedIndices[0];
            if (radioDynamic.Checked)
                Settings.SettingsList[index].DHCP[0] = radioDynamic.Checked;
            if (tbIpAddress.Text != "")
                Settings.SettingsList[index].IpAddress[0] = tbIpAddress.Text;
            if (tbSubnetMask.Text != "")
                Settings.SettingsList[index].Ipv4Mask[0] = tbSubnetMask.Text;
            if (tbGateway.Text != "")
                Settings.SettingsList[index].Gateway[0] = tbGateway.Text;
            if (tbPriDNS.Text != "")
                Settings.SettingsList[index].DNS[0] = tbPriDNS.Text;
            if (tbSecDNS.Text != "")
                Settings.SettingsList[index].DNS[1] = tbSecDNS.Text;

            Settings.SaveFile(Settings.SettingsList);
        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            Settings.Setting n = new Settings.Setting();

            n.Init();
            n.Name = "New entry";
            n.num = Settings.SettingsList.Count;
            n.DHCP[0] = false;

            Settings.SettingsList.Add(n);

            UpdateSettingsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.OpenFile(Settings.SettingsList);
            UpdateSettingsList();
        }

        private void lstSettingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lstSender = (ListView)sender;

            if (lstSender.SelectedIndices.Count > 0)
            {
                var newSetting = Settings.SettingsList.Find(x => x.num == lstSender.SelectedIndices[0]);

                radioStatic.Checked = !newSetting.DHCP[0];
                radioDynamic.Checked = newSetting.DHCP[0];
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

            Settings.Setting tempNic = Settings.SettingsList[lstSender.SelectedIndices[0]];
            tempNic.Name = newname;
            Settings.SettingsList[lstSender.SelectedIndices[0]] = tempNic;
        }

        private void toolStripSetButton_Click(object sender, EventArgs e)
        {
            //System.Management.ManagementBaseObject result;
            Settings.Setting n = new Settings.Setting();
            n.Init();

            n.IpAddress = new string[1];
            n.Ipv4Mask = new string[1];
            n.Gateway = new string[1];
             
            n.DHCP[0] = radioDynamic.Checked;
            n.IpAddress[0] = tbIpAddress.Text;
            n.Ipv4Mask[0] = tbSubnetMask.Text;
            n.Gateway[0] = tbGateway.Text;


            n.DNS[0] = tbPriDNS.Text;
            n.DNS[1] = tbSecDNS.Text;



            try
            {
                NicObject.SetNicInfo(NicObject.GetDeviceIDFromNum(cbNics.SelectedIndex), n);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


//            MessageBox.Show((string) result["IPAddress"]);
        }
    }
}
