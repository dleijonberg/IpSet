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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbNics = new System.Windows.Forms.ComboBox();
            this.tbIpAddress = new IPAddressControlLib.IPAddressControl();
            this.tbSubnetMask = new IPAddressControlLib.IPAddressControl();
            this.tbGateway = new IPAddressControlLib.IPAddressControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPriDNS = new IPAddressControlLib.IPAddressControl();
            this.tbSecDNS = new IPAddressControlLib.IPAddressControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbGateway = new System.Windows.Forms.Label();
            this.lbSubnetMask = new System.Windows.Forms.Label();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPriDNS = new System.Windows.Forms.Label();
            this.lbSecDNS = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbNics);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 28);
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
            // tbIpAddress
            // 
            this.tbIpAddress.AllowInternalTab = false;
            this.tbIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbIpAddress.AutoHeight = true;
            this.tbIpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbIpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIpAddress.Location = new System.Drawing.Point(104, 19);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.ReadOnly = false;
            this.tbIpAddress.Size = new System.Drawing.Size(127, 22);
            this.tbIpAddress.TabIndex = 2;
            this.tbIpAddress.Text = "...";
            // 
            // tbSubnetMask
            // 
            this.tbSubnetMask.AllowInternalTab = false;
            this.tbSubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSubnetMask.AutoHeight = true;
            this.tbSubnetMask.BackColor = System.Drawing.SystemColors.Window;
            this.tbSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSubnetMask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSubnetMask.Location = new System.Drawing.Point(104, 47);
            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.ReadOnly = false;
            this.tbSubnetMask.Size = new System.Drawing.Size(127, 22);
            this.tbSubnetMask.TabIndex = 2;
            this.tbSubnetMask.Text = "...";
            // 
            // tbGateway
            // 
            this.tbGateway.AllowInternalTab = false;
            this.tbGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbGateway.AutoHeight = true;
            this.tbGateway.BackColor = System.Drawing.SystemColors.Window;
            this.tbGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbGateway.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGateway.Location = new System.Drawing.Point(104, 75);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.ReadOnly = false;
            this.tbGateway.Size = new System.Drawing.Size(127, 22);
            this.tbGateway.TabIndex = 2;
            this.tbGateway.Text = "...";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(224, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(245, 110);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIpAddress);
            this.groupBox1.Controls.Add(this.tbGateway);
            this.groupBox1.Controls.Add(this.tbSubnetMask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP settings";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gateway";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet mask";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-address";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupBox2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(224, 128);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(245, 84);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPriDNS);
            this.groupBox2.Controls.Add(this.tbSecDNS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DNS settings";
            // 
            // tbPriDNS
            // 
            this.tbPriDNS.AllowInternalTab = false;
            this.tbPriDNS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPriDNS.AutoHeight = true;
            this.tbPriDNS.BackColor = System.Drawing.SystemColors.Window;
            this.tbPriDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbPriDNS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPriDNS.Location = new System.Drawing.Point(104, 21);
            this.tbPriDNS.Name = "tbPriDNS";
            this.tbPriDNS.ReadOnly = false;
            this.tbPriDNS.Size = new System.Drawing.Size(127, 22);
            this.tbPriDNS.TabIndex = 2;
            this.tbPriDNS.Text = "...";
            // 
            // tbSecDNS
            // 
            this.tbSecDNS.AllowInternalTab = false;
            this.tbSecDNS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSecDNS.AutoHeight = true;
            this.tbSecDNS.BackColor = System.Drawing.SystemColors.Window;
            this.tbSecDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSecDNS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSecDNS.Location = new System.Drawing.Point(104, 47);
            this.tbSecDNS.Name = "tbSecDNS";
            this.tbSecDNS.ReadOnly = false;
            this.tbSecDNS.Size = new System.Drawing.Size(127, 22);
            this.tbSecDNS.TabIndex = 2;
            this.tbSecDNS.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Secondary DNS";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primary DNS";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.groupBox3);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(224, 218);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(245, 132);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbIpAddress);
            this.groupBox3.Controls.Add(this.lbSubnetMask);
            this.groupBox3.Controls.Add(this.lbSecDNS);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbPriDNS);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbGateway);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 125);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actual settings";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP-address";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Subnet mask";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Gateway";
            // 
            // lbGateway
            // 
            this.lbGateway.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGateway.AutoSize = true;
            this.lbGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGateway.Location = new System.Drawing.Point(101, 59);
            this.lbGateway.Name = "lbGateway";
            this.lbGateway.Size = new System.Drawing.Size(28, 13);
            this.lbGateway.TabIndex = 3;
            this.lbGateway.Text = "Text";
            // 
            // lbSubnetMask
            // 
            this.lbSubnetMask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSubnetMask.AutoSize = true;
            this.lbSubnetMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubnetMask.Location = new System.Drawing.Point(101, 46);
            this.lbSubnetMask.Name = "lbSubnetMask";
            this.lbSubnetMask.Size = new System.Drawing.Size(28, 13);
            this.lbSubnetMask.TabIndex = 3;
            this.lbSubnetMask.Text = "Text";
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpAddress.Location = new System.Drawing.Point(101, 33);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(28, 13);
            this.lbIpAddress.TabIndex = 3;
            this.lbIpAddress.Text = "Text";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Primary DNS";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 98);
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
            this.lbPriDNS.Location = new System.Drawing.Point(101, 85);
            this.lbPriDNS.Name = "lbPriDNS";
            this.lbPriDNS.Size = new System.Drawing.Size(28, 13);
            this.lbPriDNS.TabIndex = 3;
            this.lbPriDNS.Text = "Text";
            // 
            // lbSecDNS
            // 
            this.lbSecDNS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSecDNS.AutoSize = true;
            this.lbSecDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecDNS.Location = new System.Drawing.Point(101, 98);
            this.lbSecDNS.Name = "lbSecDNS";
            this.lbSecDNS.Size = new System.Drawing.Size(28, 13);
            this.lbSecDNS.TabIndex = 3;
            this.lbSecDNS.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 360);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbNics;
        private IPAddressControlLib.IPAddressControl tbIpAddress;
        private IPAddressControlLib.IPAddressControl tbSubnetMask;
        private IPAddressControlLib.IPAddressControl tbGateway;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private IPAddressControlLib.IPAddressControl tbPriDNS;
        private IPAddressControlLib.IPAddressControl tbSecDNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbIpAddress;
        private System.Windows.Forms.Label lbSubnetMask;
        private System.Windows.Forms.Label lbSecDNS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbPriDNS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbGateway;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

