namespace IpSet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbNics = new System.Windows.Forms.ComboBox();
            this.lstSettingsList = new System.Windows.Forms.ListView();
            this.tbIpAddress = new IPAddressControlLib.IPAddressControl();
            this.tbSubnetMask = new IPAddressControlLib.IPAddressControl();
            this.tbGateway = new IPAddressControlLib.IPAddressControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_DHCP = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_DynamicDNS = new System.Windows.Forms.CheckBox();
            this.tbPriDNS = new IPAddressControlLib.IPAddressControl();
            this.tbSecDNS = new IPAddressControlLib.IPAddressControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbInfoTextBox = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReloadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSetButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.ipAddressControl2 = new IPAddressControlLib.IPAddressControl();
            this.label4 = new System.Windows.Forms.Label();
            this.ipAddressControl3 = new IPAddressControlLib.IPAddressControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbNics);
            this.flowLayoutPanel1.Controls.Add(this.lstSettingsList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 460);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbNics
            // 
            this.cbNics.FormattingEnabled = true;
            this.cbNics.Location = new System.Drawing.Point(3, 3);
            this.cbNics.Name = "cbNics";
            this.cbNics.Size = new System.Drawing.Size(200, 21);
            this.cbNics.TabIndex = 0;
            // 
            // lstSettingsList
            // 
            this.lstSettingsList.GridLines = true;
            this.lstSettingsList.HideSelection = false;
            this.lstSettingsList.LabelEdit = true;
            this.lstSettingsList.LabelWrap = false;
            this.lstSettingsList.Location = new System.Drawing.Point(3, 30);
            this.lstSettingsList.MultiSelect = false;
            this.lstSettingsList.Name = "lstSettingsList";
            this.lstSettingsList.Size = new System.Drawing.Size(200, 430);
            this.lstSettingsList.TabIndex = 1;
            this.lstSettingsList.UseCompatibleStateImageBehavior = false;
            this.lstSettingsList.View = System.Windows.Forms.View.List;
            this.lstSettingsList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstSettingsList_AfterLabelEdit);
            this.lstSettingsList.SelectedIndexChanged += new System.EventHandler(this.lstSettingsList_SelectedIndexChanged);
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.AllowInternalTab = false;
            this.tbIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIpAddress.AutoHeight = true;
            this.tbIpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbIpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIpAddress.Location = new System.Drawing.Point(118, 29);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.ReadOnly = false;
            this.tbIpAddress.Size = new System.Drawing.Size(123, 20);
            this.tbIpAddress.TabIndex = 2;
            this.tbIpAddress.Text = "...";
            // 
            // tbSubnetMask
            // 
            this.tbSubnetMask.AllowInternalTab = false;
            this.tbSubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubnetMask.AutoHeight = true;
            this.tbSubnetMask.BackColor = System.Drawing.SystemColors.Window;
            this.tbSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSubnetMask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSubnetMask.Location = new System.Drawing.Point(118, 55);
            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.ReadOnly = false;
            this.tbSubnetMask.Size = new System.Drawing.Size(123, 20);
            this.tbSubnetMask.TabIndex = 2;
            this.tbSubnetMask.Text = "...";
            // 
            // tbGateway
            // 
            this.tbGateway.AllowInternalTab = false;
            this.tbGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGateway.AutoHeight = true;
            this.tbGateway.BackColor = System.Drawing.SystemColors.Window;
            this.tbGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbGateway.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGateway.Location = new System.Drawing.Point(118, 81);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.ReadOnly = false;
            this.tbGateway.Size = new System.Drawing.Size(123, 20);
            this.tbGateway.TabIndex = 2;
            this.tbGateway.Text = "...";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tabControl1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(224, 28);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(264, 460);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(255, 134);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_DHCP);
            this.tabPage1.Controls.Add(this.tbIpAddress);
            this.tabPage1.Controls.Add(this.tbSubnetMask);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbGateway);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pri";
            // 
            // checkBox_DHCP
            // 
            this.checkBox_DHCP.AutoSize = true;
            this.checkBox_DHCP.Location = new System.Drawing.Point(9, 7);
            this.checkBox_DHCP.Name = "checkBox_DHCP";
            this.checkBox_DHCP.Size = new System.Drawing.Size(56, 17);
            this.checkBox_DHCP.TabIndex = 4;
            this.checkBox_DHCP.Text = "DHCP";
            this.checkBox_DHCP.UseVisualStyleBackColor = true;
            this.checkBox_DHCP.CheckedChanged += new System.EventHandler(this.checkBox_DHCP_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gateway";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet mask";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_DynamicDNS);
            this.groupBox2.Controls.Add(this.tbPriDNS);
            this.groupBox2.Controls.Add(this.tbSecDNS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DNS settings";
            // 
            // checkBox_DynamicDNS
            // 
            this.checkBox_DynamicDNS.AutoSize = true;
            this.checkBox_DynamicDNS.Location = new System.Drawing.Point(13, 21);
            this.checkBox_DynamicDNS.Name = "checkBox_DynamicDNS";
            this.checkBox_DynamicDNS.Size = new System.Drawing.Size(79, 20);
            this.checkBox_DynamicDNS.TabIndex = 4;
            this.checkBox_DynamicDNS.Text = "Dynamic";
            this.checkBox_DynamicDNS.UseVisualStyleBackColor = true;
            this.checkBox_DynamicDNS.CheckedChanged += new System.EventHandler(this.checkBox_DynamicDNS_CheckedChanged);
            // 
            // tbPriDNS
            // 
            this.tbPriDNS.AllowInternalTab = false;
            this.tbPriDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPriDNS.AutoHeight = true;
            this.tbPriDNS.BackColor = System.Drawing.SystemColors.Window;
            this.tbPriDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbPriDNS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPriDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriDNS.Location = new System.Drawing.Point(122, 41);
            this.tbPriDNS.Name = "tbPriDNS";
            this.tbPriDNS.ReadOnly = false;
            this.tbPriDNS.Size = new System.Drawing.Size(123, 20);
            this.tbPriDNS.TabIndex = 2;
            this.tbPriDNS.Text = "...";
            // 
            // tbSecDNS
            // 
            this.tbSecDNS.AllowInternalTab = false;
            this.tbSecDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSecDNS.AutoHeight = true;
            this.tbSecDNS.BackColor = System.Drawing.SystemColors.Window;
            this.tbSecDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSecDNS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSecDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbSecDNS.Location = new System.Drawing.Point(122, 69);
            this.tbSecDNS.Name = "tbSecDNS";
            this.tbSecDNS.ReadOnly = false;
            this.tbSecDNS.Size = new System.Drawing.Size(123, 20);
            this.tbSecDNS.TabIndex = 2;
            this.tbSecDNS.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Secondary DNS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primary DNS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbInfoTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 208);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actual settings";
            // 
            // lbInfoTextBox
            // 
            this.lbInfoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbInfoTextBox.AutoSize = true;
            this.lbInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoTextBox.Location = new System.Drawing.Point(6, 21);
            this.lbInfoTextBox.Name = "lbInfoTextBox";
            this.lbInfoTextBox.Size = new System.Drawing.Size(42, 13);
            this.lbInfoTextBox.TabIndex = 3;
            this.lbInfoTextBox.Text = "Infotext";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveButton,
            this.toolStripNewButton,
            this.toolStripSeparator1,
            this.toolStripReloadButton,
            this.toolStripSetButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSaveButton.Enabled = false;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(35, 22);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(35, 22);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.toolStripNewButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripReloadButton
            // 
            this.toolStripReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReloadButton.Image")));
            this.toolStripReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReloadButton.Name = "toolStripReloadButton";
            this.toolStripReloadButton.Size = new System.Drawing.Size(47, 22);
            this.toolStripReloadButton.Text = "Reload";
            this.toolStripReloadButton.Click += new System.EventHandler(this.toolStripReloadButton_Click);
            // 
            // toolStripSetButton
            // 
            this.toolStripSetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSetButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSetButton.Image")));
            this.toolStripSetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSetButton.Name = "toolStripSetButton";
            this.toolStripSetButton.Size = new System.Drawing.Size(27, 22);
            this.toolStripSetButton.Text = "Set";
            this.toolStripSetButton.Click += new System.EventHandler(this.toolStripSetButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.ipAddressControl1);
            this.tabPage2.Controls.Add(this.ipAddressControl2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ipAddressControl3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(247, 108);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sec";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "DHCP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(118, 29);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(123, 20);
            this.ipAddressControl1.TabIndex = 5;
            this.ipAddressControl1.Text = "...";
            // 
            // ipAddressControl2
            // 
            this.ipAddressControl2.AllowInternalTab = false;
            this.ipAddressControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddressControl2.AutoHeight = true;
            this.ipAddressControl2.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl2.Location = new System.Drawing.Point(118, 55);
            this.ipAddressControl2.Name = "ipAddressControl2";
            this.ipAddressControl2.ReadOnly = false;
            this.ipAddressControl2.Size = new System.Drawing.Size(123, 20);
            this.ipAddressControl2.TabIndex = 6;
            this.ipAddressControl2.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gateway";
            // 
            // ipAddressControl3
            // 
            this.ipAddressControl3.AllowInternalTab = false;
            this.ipAddressControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddressControl3.AutoHeight = true;
            this.ipAddressControl3.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl3.Location = new System.Drawing.Point(118, 81);
            this.ipAddressControl3.Name = "ipAddressControl3";
            this.ipAddressControl3.ReadOnly = false;
            this.ipAddressControl3.Size = new System.Drawing.Size(123, 20);
            this.ipAddressControl3.TabIndex = 7;
            this.ipAddressControl3.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "IP-address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subnet mask";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "IpSet v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbNics;
        private IPAddressControlLib.IPAddressControl tbIpAddress;
        private IPAddressControlLib.IPAddressControl tbSubnetMask;
        private IPAddressControlLib.IPAddressControl tbGateway;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbInfoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private IPAddressControlLib.IPAddressControl tbPriDNS;
        private IPAddressControlLib.IPAddressControl tbSecDNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ListView lstSettingsList;
        private System.Windows.Forms.ToolStripButton toolStripSetButton;
        private System.Windows.Forms.ToolStripButton toolStripReloadButton;
        private System.Windows.Forms.CheckBox checkBox_DHCP;
        private System.Windows.Forms.CheckBox checkBox_DynamicDNS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private IPAddressControlLib.IPAddressControl ipAddressControl2;
        private System.Windows.Forms.Label label4;
        private IPAddressControlLib.IPAddressControl ipAddressControl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

