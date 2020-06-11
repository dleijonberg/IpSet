using NetworkAdapter;
using System;
using System.Windows.Forms;

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

            // Update info textbox
            UpdateInfoText(cbNics.SelectedIndex);

            // Create event handler for when user changes adapter in combobox
            cbNics.SelectedIndexChanged += new EventHandler(cbNics_OnSelectedIndexChanged);
        }

        //  Updates the NicInfo struct in class Nics as
        //  updates the combobox with adapters
        public void UpdateCbNicsList()
        {
            // Clear the existing list
            cbNics.Items.Clear();
            // Update the Niclist in class Nics
            NicObject.UpdateNicInfo();

            // Add all adapters from NicList to the combo box
            foreach (var nic in NicObject.NicList)
            {
                cbNics.Items.Add(nic.Name);
            }

            if (cbNics.Items.Count > 0)
                cbNics.SelectedIndex = 0;

        }

        //  Update Info textbox in UI
        public void UpdateInfoText(int index)
        {
            // Clear text object first
            this.lbInfoTextBox.Text = "";

            // Check if adapter is connected
            if (NicObject.NicList[index].NetEnabled)
            {
                // Add Ip-address(es) to textbox
                if (NicObject.NicList[index].IpAddress != null)
                {
                    for (int i = 0; i < NicObject.NicList[index].IpAddress.Length; i++)
                    {
                        this.lbInfoTextBox.Text += "IP-address " + (i + 1) + ": " + NicObject.NicList[index].IpAddress[i] + "\n\r"
                        + "Subnet mask " + (i + 1) + ": " + NicObject.NicList[index].SubnetMask[i] + "\n\r\n\r";
                    }
                }

                // Add gateway(s) to textbox
                if (NicObject.NicList[index].Gateway != null)
                {
                    for (int i = 0; i < NicObject.NicList[index].Gateway.Length; i++)
                    {
                        this.lbInfoTextBox.Text += "Gateway " + (i + 1) + ": " + NicObject.NicList[index].Gateway[i] + "\r\n";
                    }
                    this.lbInfoTextBox.Text += "\r\n";
                }

                // Add DNS to textbox
                if (NicObject.NicList[index].DNS != null)
                {
                    if (NicObject.NicList[index].DNS.Length > 0)
                    {
                        this.lbInfoTextBox.Text += "Primary DNS: " + NicObject.NicList[index].DNS[0] + "\r\n";
                    }

                    if (NicObject.NicList[index].DNS.Length > 1)
                    {
                        this.lbInfoTextBox.Text += "Secondary DNS: " + NicObject.NicList[index].DNS[1] + "\r\n";
                    }
                }
            }
            else
            {
                // Adapter not connected
                this.lbInfoTextBox.Text = "Adapter not connected";
            }
        }

        // Event trigger when user changes adapter in combo box
        public void cbNics_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;
            UpdateInfoText(cbSender.SelectedIndex);
        }

        // Update the list of settings
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

            Settings.SettingsList[index] = new Settings.Setting
            {
                Name = lstSettingsList.SelectedItems[index].Text,
                DHCP = checkBox_DHCP.Checked,
                DynamicDNS = checkBox_DynamicDNS.Checked,
                Ipv4Address = tbIpAddress.Text,
                Ipv4Mask = tbSubnetMask.Text,
                Gateway = new string[1] { tbGateway.Text },
                DNS = new string[2] { tbPriDNS.Text, tbSecDNS.Text }
            };

            Settings.SaveFile(Settings.SettingsList);
        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            Settings.Setting n = new Settings.Setting();

            n.Name = "New entry";
            n.num = Settings.SettingsList.Count;
            n.DHCP = false;

            Settings.SettingsList.Add(n);

            UpdateSettingsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.OpenFile(Settings.SettingsList);
            UpdateSettingsList();
        }

        // Event trigger when user clicks on a setting in the list
        private void lstSettingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lstSender = (ListView)sender;

            if (lstSender.SelectedIndices.Count > 0)
            {
                var newSetting = Settings.SettingsList.Find(x => x.num == lstSender.SelectedIndices[0]);

                checkBox_DHCP.Checked = newSetting.DHCP;
                checkBox_DynamicDNS.Checked = newSetting.DynamicDNS;
                tbIpAddress.Text = (newSetting.Ipv4Address != null) ? newSetting.Ipv4Address : "";
                tbSubnetMask.Text = (newSetting.Ipv4Mask != null) ? newSetting.Ipv4Mask : "";
                tbGateway.Text = (newSetting.Gateway != null) ? newSetting.Gateway[0] : "";
                tbPriDNS.Text = (newSetting.DNS != null) ? newSetting.DNS[0] : "";
                tbSecDNS.Text = (newSetting.DNS != null && newSetting.DNS.Length > 1) ? newSetting.DNS[1] : "";
            }
        }

        // Event trigger when user changed name on a setting in the list
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

            n.Gateway = new string[1];

            n.DHCP = checkBox_DHCP.Checked;
            n.Ipv4Address = tbIpAddress.Text;
            n.Ipv4Mask = tbSubnetMask.Text;
            n.Gateway[0] = tbGateway.Text;

            n.DynamicDNS = checkBox_DynamicDNS.Checked;
            n.DNS[0] = tbPriDNS.Text;
            n.DNS[1] = tbSecDNS.Text;

            try
            {
                NicObject.SetNicInfo(NicObject.GetDeviceIDFromNum(cbNics.SelectedIndex), n);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            NicObject.UpdateNicInfo();
            UpdateInfoText(cbNics.SelectedIndex);
            //            MessageBox.Show((string) result["IPAddress"]);
        }

        private void toolStripReloadButton_Click(object sender, EventArgs e)
        {
            UpdateCbNicsList();
        }

         private void checkBox_DHCP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;
            if (s.Checked)
            {
                tbIpAddress.Enabled = false;
                tbSubnetMask.Enabled = false;
                tbGateway.Enabled = false;
                checkBox_DynamicDNS.Enabled = true;
            }
            if (!s.Checked)
            {
                tbIpAddress.Enabled = true;
                tbSubnetMask.Enabled = true;
                tbGateway.Enabled = true;
                checkBox_DynamicDNS.Enabled = false;
            }
        }

        private void checkBox_DynamicDNS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;
            if (s.Checked)
            {
                tbPriDNS.Enabled = false;
                tbSecDNS.Enabled = false;
            }
            if (!s.Checked)
            {
                tbPriDNS.Enabled = true;
                tbSecDNS.Enabled = true;
            }
        }
    }
}
