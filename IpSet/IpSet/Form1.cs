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
                Width = 200
            };
            TextBox tbIpAddress = new TextBox
            {
                Name = "tbIpAddress",
                Location = new System.Drawing.Point(20, 50),
                Width = 100
            };
            // Add form controls
            Controls.Add(cbNics);
            Controls.Add(tbIpAddress);

            // Populate controls
            // ComboBox for network adapters
            foreach (var nic in NicObject.NicList)
            {
                cbNics.Items.Add(nic.Name);
            }
            cbNics.SelectedIndex = 0;

            if (cbNics.SelectedIndex >= 0 && cbNics.SelectedIndex < cbNics.Items.Count)
                tbIpAddress.Text = NicObject.NicList[cbNics.SelectedIndex].IpAddress;

        }
    }
}
