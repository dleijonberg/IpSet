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
            this.lbIpAddress.Text = NicObject.NicList[cbSender.SelectedIndex].IpAddress[0];
            this.lbSubnetMask.Text = NicObject.NicList[cbSender.SelectedIndex].Ipv4Mask[0];
            this.lbGateway.Text = NicObject.NicList[cbSender.SelectedIndex].Gateway;

        }


    }
}
