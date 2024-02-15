using NetworkAdapter;
using System;
using System.Net;
using System.Windows.Forms;

namespace IpSet
{
    public partial class Form1 : Form
    {
        internal Nics NicObject = new Nics();
        internal Settings Settings = new Settings();
        internal int SelectedSetting = -1;

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
            NicObject.UpdateNicList();

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
                // Adapter reports not connected to a network
                this.lbInfoTextBox.Text = "No connection";
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

        // Save current settings to selected setting in settingslist
        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            //int index = lstSettingsList.SelectedIndices[0];

            // Create new Settings.Setting and apply data to it
            Settings.SettingsList[SelectedSetting] = new Settings.Setting
            {
                Name = lstSettingsList.SelectedItems[0].Text,
                DHCP = checkBox_DHCP.Checked,
                DynamicDNS = checkBox_DynamicDNS.Checked,
                Ipv4Address = tbIpAddress.Text,
                Ipv4Mask = tbSubnetMask.Text,
                Gateway = tbGateway.Text,
                DNS = new string[2] { tbPriDNS.Text, tbSecDNS.Text }
            };

            // Save the settings file
            Settings.SaveFile(Settings.SettingsList);
        }

        // Create new setting in settingslist
        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            Settings.Setting n = new Settings.Setting();

            n.Name = "New entry";
            //n.num = Settings.SettingsList.Count;
            n.DHCP = false;

            Settings.SettingsList.Add(n);

            UpdateSettingsList();
        }

        // Open settingsfile on load and update the settingslist
        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.OpenFile(Settings.SettingsList);
            UpdateSettingsList();

            // if DHCP is unchecked, Dynamic DNS should not be possible
            if (!checkBox_DHCP.Checked)
                checkBox_DynamicDNS.Enabled = false;
        }

        // Event trigger when user clicks on a setting in the list
        private void lstSettingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lstSender = (ListView)sender;

            // If a setting is selected
            if (lstSender.SelectedItems.Count > 0)
            {
                // Update the selected settings memory
                SelectedSetting = lstSender.SelectedItems[0].Index;

                // Enable the address boxes
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                toolStripButton_Set.Enabled = true;
                toolStripButton_Save.Enabled = true;
                toolStripButton_Delete.Enabled = true;

                // Create a temporary setting instance to load settings from list
                var newSetting = Settings.SettingsList[SelectedSetting];

                // Update the address boxes with the loaded settings
                checkBox_DHCP.Checked = newSetting.DHCP;
                checkBox_DynamicDNS.Checked = newSetting.DynamicDNS;
                tbIpAddress.Text = (newSetting.Ipv4Address != null) ? newSetting.Ipv4Address : "";
                tbSubnetMask.Text = (newSetting.Ipv4Mask != null) ? newSetting.Ipv4Mask : "";
                tbGateway.Text = (newSetting.Gateway != null) ? newSetting.Gateway : "";
                tbPriDNS.Text = (newSetting.DNS != null) ? newSetting.DNS[0] : "";
                tbSecDNS.Text = (newSetting.DNS != null && newSetting.DNS.Length > 1) ? newSetting.DNS[1] : "";
            }
            // If nothing is selected, we empty the address boxes and disable them
            else
            {
                SelectedSetting = -1;
                checkBox_DHCP.Checked = false;
                checkBox_DynamicDNS.Checked = false;
                tbIpAddress.Text = "";
                tbSubnetMask.Text = "";
                tbGateway.Text = "";
                tbPriDNS.Text = "";
                tbSecDNS.Text = "";

                // Disable groupboxes for IP and DNS if nothing is selected
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;

                toolStripButton_Set.Enabled = false;
                toolStripButton_Save.Enabled = false;
                toolStripButton_Delete.Enabled = false;
            }

        }

        // Event trigger when user changed name on a setting in the list
        private void lstSettingsList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListView lstSender = (ListView)sender;

            var newname = e.Label;

            Settings.Setting tempNic = Settings.SettingsList[SelectedSetting];
            tempNic.Name = newname;
            Settings.SettingsList[SelectedSetting] = tempNic;
        }

        // Apply the selected settings to the NIC
        private void toolStripSetButton_Click(object sender, EventArgs e)
        {
            // Create a settings instance for loading the settings from address boxes
            Settings.Setting n = new Settings.Setting();
            n.Init();

            // Apply settings from address boxes
            n.Gateway = "";
            n.DHCP = checkBox_DHCP.Checked;
            n.Ipv4Address = tbIpAddress.Text;
            n.Ipv4Mask = tbSubnetMask.Text;
            n.Gateway = tbGateway.Text;
            n.DynamicDNS = checkBox_DynamicDNS.Checked;
            n.DNS[0] = tbPriDNS.Text;
            n.DNS[1] = tbSecDNS.Text;

            n.valid = IPAddress.TryParse(n.Ipv4Address, out var ipAddress) || n.DHCP;

            // Apply settings to NIC
            try
            {
                var result = NicObject.SetNicInfo(NicObject.GetDeviceIDFromNum(cbNics.SelectedIndex), n);
                if (!result)
                    MessageBox.Show("Gick inte att sätta IP-adress!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            // Update the info box to show new settings
            NicObject.UpdateNicList();
            UpdateInfoText(cbNics.SelectedIndex);
        }

        // Re-inventory connected NICs
        private void toolStripReloadButton_Click(object sender, EventArgs e)
        {
            UpdateCbNicsList();
        }

        // Event trigger for when DHCP checkbox is changed
        private void checkBox_DHCP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;
            // Disable IP address boxes if DHCP is selected
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
                checkBox_DynamicDNS.Checked = false;
                checkBox_DynamicDNS.Enabled = false;
            }
        }

        // Event trigger for when dynamic DNS is changed
        private void checkBox_DynamicDNS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;

            // Disable DNS textboxes if Dynamic DNS is selected
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

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Settings.SettingsList.RemoveAt(SelectedSetting);
            
            // Save the settings file
            Settings.SaveFile(Settings.SettingsList);

            // Refresh list object
            UpdateSettingsList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NicObject.UpdateNicInfo(cbNics.SelectedIndex);
            UpdateInfoText(cbNics.SelectedIndex);
        }
    }
}
