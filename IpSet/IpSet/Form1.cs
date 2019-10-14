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
            Label txtText = new Label
            {
                Name = "txtText",
                Location = new System.Drawing.Point(170, 20),
                Width = 100

            };

            InitTextBox();

            // Add form controls
            Controls.Add(cbNics);
            Controls.Add(txtText);

            cbNics.SelectedIndexChanged += new EventHandler(cbNics_SelectedIndexChanged);


            // Populate controls
            // ComboBox for network adapters
            foreach (var nic in NicObject.NicList)
            {
                cbNics.Items.Add(nic.Name);
            }
            cbNics.SelectedIndex = 0;

            txtText.Text = "Texttext"; // NicObject.NicList[cbNics.SelectedIndex].IpAddress;
            if (cbNics.SelectedIndex >= 0 && cbNics.SelectedIndex < cbNics.Items.Count)
                tbIpAddress.Text = NicObject.NicList[cbNics.SelectedIndex].IpAddress;
            else
                tbIpAddress.Text = cbNics.SelectedIndex.ToString();

            
        }

        internal TextBox tbIpAddress = new TextBox();
        internal Nics NicObject = new Nics();

        private void InitTextBox()
        {
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Location = new System.Drawing.Point(300, 20);
            this.tbIpAddress.Width = 100;
            this.tbIpAddress.ReadOnly = true;
            this.Controls.Add(tbIpAddress);

        }
        public void cbNics_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox cbSender = (ComboBox) sender;
            this.tbIpAddress.Text = NicObject.NicList[cbSender.SelectedIndex].IpAddress;
            
        }
    }
}
