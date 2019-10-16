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
        public Form1()
        {
            InitializeComponent();
            Nics NicObject = new Nics();

            ComboBox cbNics = new ComboBox
            {
                Name = "cbNics",
                Location = new System.Drawing.Point(20, 20),
                Width = 200,
                TabIndex = 1
            };

            // Add form controls
            Controls.Add(cbNics);

            InitGlobalControls();

            cbNics.SelectedIndexChanged += new EventHandler(cbNics_SelectedIndexChanged);


            // Populate controls
            // ComboBox for network adapters
            foreach (var nic in NicObject.NicList)
            {
                cbNics.Items.Add(nic.Name);
            }
            cbNics.SelectedIndex = 0;
            
        }

        internal TextBox tbIpAddress = new TextBox();
        internal TextBox tbSubnetMask = new TextBox();
        internal TextBox tbGateway = new TextBox();
        internal Nics NicObject = new Nics();

        private void InitGlobalControls()
        {
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Location = new System.Drawing.Point(300, 20);
            this.tbIpAddress.Width = 100;
            //this.tbIpAddress.Height = 60;
            //this.tbIpAddress.Multiline = true;
            this.tbIpAddress.ReadOnly = true;
            this.tbIpAddress.TabIndex = 2;
            this.Controls.Add(this.tbIpAddress);

            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.Location = new System.Drawing.Point(300, 42);
            this.tbSubnetMask.Width = 100;
            this.tbSubnetMask.ReadOnly = true;
            this.tbSubnetMask.TabIndex = 3;
            this.Controls.Add(this.tbSubnetMask);

            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Location = new System.Drawing.Point(300, 64);
            this.tbGateway.Width = 100;
            this.tbGateway.ReadOnly = true;
            this.tbGateway.TabIndex = 4;
            this.Controls.Add(this.tbGateway);
        }

        public void cbNics_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox cbSender = (ComboBox) sender;
            this.tbIpAddress.Text = NicObject.NicList[cbSender.SelectedIndex].IpAddress;
            this.tbSubnetMask.Text = NicObject.NicList[cbSender.SelectedIndex].Ipv4Mask;
            this.tbGateway.Text = NicObject.NicList[cbSender.SelectedIndex].Gateway;

        }
    }
}
