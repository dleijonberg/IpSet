﻿namespace IpSet
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
            this.radioStatic = new System.Windows.Forms.RadioButton();
            this.radioDynamic = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioAltStatic = new System.Windows.Forms.RadioButton();
            this.radioAltDynamic = new System.Windows.Forms.RadioButton();
            this.tbAltIpAddress = new IPAddressControlLib.IPAddressControl();
            this.tbAltSubnetMask = new IPAddressControlLib.IPAddressControl();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAltGateway = new IPAddressControlLib.IPAddressControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPriDNS = new IPAddressControlLib.IPAddressControl();
            this.tbSecDNS = new IPAddressControlLib.IPAddressControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbGateway = new System.Windows.Forms.Label();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.lbSecDNS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPriDNS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbIpAddressHeader = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSetButton = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbNics);
            this.flowLayoutPanel1.Controls.Add(this.lstSettingsList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 432);
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
            this.lstSettingsList.Size = new System.Drawing.Size(200, 396);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(264, 432);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(255, 142);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioStatic);
            this.tabPage1.Controls.Add(this.radioDynamic);
            this.tabPage1.Controls.Add(this.tbIpAddress);
            this.tabPage1.Controls.Add(this.tbSubnetMask);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbGateway);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pri";
            // 
            // radioStatic
            // 
            this.radioStatic.AutoSize = true;
            this.radioStatic.Location = new System.Drawing.Point(118, 6);
            this.radioStatic.Name = "radioStatic";
            this.radioStatic.Size = new System.Drawing.Size(52, 17);
            this.radioStatic.TabIndex = 4;
            this.radioStatic.Text = "Static";
            this.radioStatic.UseVisualStyleBackColor = true;
            // 
            // radioDynamic
            // 
            this.radioDynamic.AutoSize = true;
            this.radioDynamic.Checked = true;
            this.radioDynamic.Location = new System.Drawing.Point(9, 6);
            this.radioDynamic.Name = "radioDynamic";
            this.radioDynamic.Size = new System.Drawing.Size(66, 17);
            this.radioDynamic.TabIndex = 4;
            this.radioDynamic.TabStop = true;
            this.radioDynamic.Text = "Dynamic";
            this.radioDynamic.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioAltStatic);
            this.tabPage2.Controls.Add(this.radioAltDynamic);
            this.tabPage2.Controls.Add(this.tbAltIpAddress);
            this.tabPage2.Controls.Add(this.tbAltSubnetMask);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbAltGateway);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alt";
            // 
            // radioAltStatic
            // 
            this.radioAltStatic.AutoSize = true;
            this.radioAltStatic.Location = new System.Drawing.Point(118, 6);
            this.radioAltStatic.Name = "radioAltStatic";
            this.radioAltStatic.Size = new System.Drawing.Size(52, 17);
            this.radioAltStatic.TabIndex = 10;
            this.radioAltStatic.Text = "Static";
            this.radioAltStatic.UseVisualStyleBackColor = true;
            // 
            // radioAltDynamic
            // 
            this.radioAltDynamic.AutoSize = true;
            this.radioAltDynamic.Checked = true;
            this.radioAltDynamic.Location = new System.Drawing.Point(9, 6);
            this.radioAltDynamic.Name = "radioAltDynamic";
            this.radioAltDynamic.Size = new System.Drawing.Size(66, 17);
            this.radioAltDynamic.TabIndex = 11;
            this.radioAltDynamic.TabStop = true;
            this.radioAltDynamic.Text = "Dynamic";
            this.radioAltDynamic.UseVisualStyleBackColor = true;
            // 
            // tbAltIpAddress
            // 
            this.tbAltIpAddress.AllowInternalTab = false;
            this.tbAltIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAltIpAddress.AutoHeight = true;
            this.tbAltIpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAltIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbAltIpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAltIpAddress.Location = new System.Drawing.Point(118, 29);
            this.tbAltIpAddress.Name = "tbAltIpAddress";
            this.tbAltIpAddress.ReadOnly = false;
            this.tbAltIpAddress.Size = new System.Drawing.Size(123, 20);
            this.tbAltIpAddress.TabIndex = 4;
            this.tbAltIpAddress.Text = "...";
            // 
            // tbAltSubnetMask
            // 
            this.tbAltSubnetMask.AllowInternalTab = false;
            this.tbAltSubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAltSubnetMask.AutoHeight = true;
            this.tbAltSubnetMask.BackColor = System.Drawing.SystemColors.Window;
            this.tbAltSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbAltSubnetMask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAltSubnetMask.Location = new System.Drawing.Point(118, 55);
            this.tbAltSubnetMask.Name = "tbAltSubnetMask";
            this.tbAltSubnetMask.ReadOnly = false;
            this.tbAltSubnetMask.Size = new System.Drawing.Size(123, 20);
            this.tbAltSubnetMask.TabIndex = 5;
            this.tbAltSubnetMask.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alt Gateway";
            // 
            // tbAltGateway
            // 
            this.tbAltGateway.AllowInternalTab = false;
            this.tbAltGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAltGateway.AutoHeight = true;
            this.tbAltGateway.BackColor = System.Drawing.SystemColors.Window;
            this.tbAltGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbAltGateway.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAltGateway.Location = new System.Drawing.Point(118, 81);
            this.tbAltGateway.Name = "tbAltGateway";
            this.tbAltGateway.ReadOnly = false;
            this.tbAltGateway.Size = new System.Drawing.Size(123, 20);
            this.tbAltGateway.TabIndex = 6;
            this.tbAltGateway.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Alt IP-address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Alt Subnet mask";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPriDNS);
            this.groupBox2.Controls.Add(this.tbSecDNS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DNS settings";
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
            this.tbPriDNS.Location = new System.Drawing.Point(122, 21);
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
            this.tbSecDNS.Location = new System.Drawing.Point(122, 49);
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
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Secondary DNS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primary DNS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbGateway);
            this.groupBox3.Controls.Add(this.lbIpAddress);
            this.groupBox3.Controls.Add(this.lbSecDNS);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbPriDNS);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbIpAddressHeader);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 185);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actual settings";
            // 
            // lbGateway
            // 
            this.lbGateway.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGateway.AutoSize = true;
            this.lbGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGateway.Location = new System.Drawing.Point(101, 102);
            this.lbGateway.Name = "lbGateway";
            this.lbGateway.Size = new System.Drawing.Size(28, 13);
            this.lbGateway.TabIndex = 3;
            this.lbGateway.Text = "Text";
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpAddress.Location = new System.Drawing.Point(101, 18);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(28, 13);
            this.lbIpAddress.TabIndex = 3;
            this.lbIpAddress.Text = "Text";
            // 
            // lbSecDNS
            // 
            this.lbSecDNS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSecDNS.AutoSize = true;
            this.lbSecDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecDNS.Location = new System.Drawing.Point(101, 141);
            this.lbSecDNS.Name = "lbSecDNS";
            this.lbSecDNS.Size = new System.Drawing.Size(28, 13);
            this.lbSecDNS.TabIndex = 3;
            this.lbSecDNS.Text = "Text";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Secondary DNS";
            // 
            // lbPriDNS
            // 
            this.lbPriDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPriDNS.AutoSize = true;
            this.lbPriDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriDNS.Location = new System.Drawing.Point(101, 128);
            this.lbPriDNS.Name = "lbPriDNS";
            this.lbPriDNS.Size = new System.Drawing.Size(28, 13);
            this.lbPriDNS.TabIndex = 3;
            this.lbPriDNS.Text = "Text";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Primary DNS";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Default gateway";
            // 
            // lbIpAddressHeader
            // 
            this.lbIpAddressHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbIpAddressHeader.AutoSize = true;
            this.lbIpAddressHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpAddressHeader.Location = new System.Drawing.Point(6, 18);
            this.lbIpAddressHeader.Name = "lbIpAddressHeader";
            this.lbIpAddressHeader.Size = new System.Drawing.Size(57, 13);
            this.lbIpAddressHeader.TabIndex = 3;
            this.lbIpAddressHeader.Text = "IP-address";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveButton,
            this.toolStripNewButton,
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 475);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lbIpAddress;
        private System.Windows.Forms.Label lbSecDNS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbPriDNS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbIpAddressHeader;
        private System.Windows.Forms.Label lbGateway;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private IPAddressControlLib.IPAddressControl tbPriDNS;
        private IPAddressControlLib.IPAddressControl tbSecDNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ListView lstSettingsList;
        private System.Windows.Forms.ToolStripButton toolStripSetButton;
        private System.Windows.Forms.RadioButton radioStatic;
        private System.Windows.Forms.RadioButton radioDynamic;
        private IPAddressControlLib.IPAddressControl tbAltIpAddress;
        private IPAddressControlLib.IPAddressControl tbAltSubnetMask;
        private System.Windows.Forms.Label label4;
        private IPAddressControlLib.IPAddressControl tbAltGateway;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioAltStatic;
        private System.Windows.Forms.RadioButton radioAltDynamic;
    }
}

