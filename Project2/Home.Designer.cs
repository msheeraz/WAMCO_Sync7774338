namespace WindowsFormsApplication1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtCommPort = new System.Windows.Forms.TextBox();
            this.txtCommKey = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAdd = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblCommPort = new System.Windows.Forms.Label();
            this.lblCommKey = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAdd = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rBtnUSB = new System.Windows.Forms.RadioButton();
            this.rBtnCOM = new System.Windows.Forms.RadioButton();
            this.rBtnIP = new System.Windows.Forms.RadioButton();
            this.List1 = new System.Windows.Forms.ListBox();
            this.axBioBridgeSDKv3lib1 = new AxBioBridgeSDKv3.AxBioBridgeSDKv3lib();
            this.List2 = new System.Windows.Forms.ListBox();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axBioBridgeSDKv3lib1)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.Controls.Add(this.button2);
            this.Frame1.Controls.Add(this.txtTimeOut);
            this.Frame1.Controls.Add(this.txtDelay);
            this.Frame1.Controls.Add(this.txtModel);
            this.Frame1.Controls.Add(this.txtBaudRate);
            this.Frame1.Controls.Add(this.txtCommPort);
            this.Frame1.Controls.Add(this.txtCommKey);
            this.Frame1.Controls.Add(this.txtPort);
            this.Frame1.Controls.Add(this.txtIPAdd);
            this.Frame1.Controls.Add(this.lblTimeOut);
            this.Frame1.Controls.Add(this.lblDelay);
            this.Frame1.Controls.Add(this.lblModel);
            this.Frame1.Controls.Add(this.lblBaudRate);
            this.Frame1.Controls.Add(this.lblCommPort);
            this.Frame1.Controls.Add(this.lblCommKey);
            this.Frame1.Controls.Add(this.lblPort);
            this.Frame1.Controls.Add(this.lblIPAdd);
            this.Frame1.Controls.Add(this.btnConnect);
            this.Frame1.Controls.Add(this.rBtnUSB);
            this.Frame1.Controls.Add(this.rBtnCOM);
            this.Frame1.Controls.Add(this.rBtnIP);
            this.Frame1.Location = new System.Drawing.Point(12, 12);
            this.Frame1.Name = "Frame1";
            this.Frame1.Size = new System.Drawing.Size(337, 237);
            this.Frame1.TabIndex = 13;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Device Connector";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(244, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 68);
            this.button2.TabIndex = 139;
            this.button2.Text = "Sync";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.AcceptsReturn = true;
            this.txtTimeOut.Location = new System.Drawing.Point(80, 213);
            this.txtTimeOut.MaxLength = 0;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(81, 20);
            this.txtTimeOut.TabIndex = 136;
            this.txtTimeOut.Text = "10";
            // 
            // txtDelay
            // 
            this.txtDelay.AcceptsReturn = true;
            this.txtDelay.Location = new System.Drawing.Point(80, 189);
            this.txtDelay.MaxLength = 0;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(81, 20);
            this.txtDelay.TabIndex = 16;
            this.txtDelay.Text = "1000";
            // 
            // txtModel
            // 
            this.txtModel.AcceptsReturn = true;
            this.txtModel.Location = new System.Drawing.Point(80, 165);
            this.txtModel.MaxLength = 0;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(81, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.AcceptsReturn = true;
            this.txtBaudRate.Location = new System.Drawing.Point(80, 141);
            this.txtBaudRate.MaxLength = 0;
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(81, 20);
            this.txtBaudRate.TabIndex = 5;
            this.txtBaudRate.Text = "115200";
            // 
            // txtCommPort
            // 
            this.txtCommPort.AcceptsReturn = true;
            this.txtCommPort.Location = new System.Drawing.Point(80, 117);
            this.txtCommPort.MaxLength = 0;
            this.txtCommPort.Name = "txtCommPort";
            this.txtCommPort.Size = new System.Drawing.Size(81, 20);
            this.txtCommPort.TabIndex = 0;
            this.txtCommPort.Text = "1";
            // 
            // txtCommKey
            // 
            this.txtCommKey.AcceptsReturn = true;
            this.txtCommKey.Location = new System.Drawing.Point(80, 93);
            this.txtCommKey.MaxLength = 0;
            this.txtCommKey.Name = "txtCommKey";
            this.txtCommKey.Size = new System.Drawing.Size(81, 20);
            this.txtCommKey.TabIndex = 4;
            this.txtCommKey.Text = "0";
            // 
            // txtPort
            // 
            this.txtPort.AcceptsReturn = true;
            this.txtPort.Location = new System.Drawing.Point(80, 69);
            this.txtPort.MaxLength = 0;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "4370";
            // 
            // txtIPAdd
            // 
            this.txtIPAdd.AcceptsReturn = true;
            this.txtIPAdd.Location = new System.Drawing.Point(80, 45);
            this.txtIPAdd.MaxLength = 0;
            this.txtIPAdd.Name = "txtIPAdd";
            this.txtIPAdd.Size = new System.Drawing.Size(81, 20);
            this.txtIPAdd.TabIndex = 7;
            this.txtIPAdd.Text = "192.168.2.118";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Location = new System.Drawing.Point(6, 214);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(65, 17);
            this.lblTimeOut.TabIndex = 135;
            this.lblTimeOut.Text = "Time Out (s)";
            // 
            // lblDelay
            // 
            this.lblDelay.Location = new System.Drawing.Point(6, 189);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(65, 17);
            this.lblDelay.TabIndex = 17;
            this.lblDelay.Text = "Delay (ms)";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(6, 165);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(65, 17);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "Model";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Location = new System.Drawing.Point(6, 141);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(65, 17);
            this.lblBaudRate.TabIndex = 21;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblCommPort
            // 
            this.lblCommPort.Location = new System.Drawing.Point(6, 117);
            this.lblCommPort.Name = "lblCommPort";
            this.lblCommPort.Size = new System.Drawing.Size(65, 17);
            this.lblCommPort.TabIndex = 24;
            this.lblCommPort.Text = "Comm Port";
            // 
            // lblCommKey
            // 
            this.lblCommKey.Location = new System.Drawing.Point(6, 93);
            this.lblCommKey.Name = "lblCommKey";
            this.lblCommKey.Size = new System.Drawing.Size(65, 17);
            this.lblCommKey.TabIndex = 20;
            this.lblCommKey.Text = "Comm Key";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(6, 69);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 17);
            this.lblPort.TabIndex = 22;
            this.lblPort.Text = "Port";
            // 
            // lblIPAdd
            // 
            this.lblIPAdd.Location = new System.Drawing.Point(6, 45);
            this.lblIPAdd.Name = "lblIPAdd";
            this.lblIPAdd.Size = new System.Drawing.Size(65, 17);
            this.lblIPAdd.TabIndex = 23;
            this.lblIPAdd.Text = "IP Address  ";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(244, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 25);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rBtnUSB
            // 
            this.rBtnUSB.AutoSize = true;
            this.rBtnUSB.Location = new System.Drawing.Point(126, 16);
            this.rBtnUSB.Name = "rBtnUSB";
            this.rBtnUSB.Size = new System.Drawing.Size(88, 17);
            this.rBtnUSB.TabIndex = 2;
            this.rBtnUSB.Text = "USB Client    ";
            this.rBtnUSB.UseVisualStyleBackColor = true;
            // 
            // rBtnCOM
            // 
            this.rBtnCOM.AutoSize = true;
            this.rBtnCOM.Location = new System.Drawing.Point(60, 16);
            this.rBtnCOM.Name = "rBtnCOM";
            this.rBtnCOM.Size = new System.Drawing.Size(58, 17);
            this.rBtnCOM.TabIndex = 1;
            this.rBtnCOM.Text = "COM   ";
            this.rBtnCOM.UseVisualStyleBackColor = true;
            // 
            // rBtnIP
            // 
            this.rBtnIP.AutoSize = true;
            this.rBtnIP.Checked = true;
            this.rBtnIP.Location = new System.Drawing.Point(8, 16);
            this.rBtnIP.Name = "rBtnIP";
            this.rBtnIP.Size = new System.Drawing.Size(74, 17);
            this.rBtnIP.TabIndex = 0;
            this.rBtnIP.TabStop = true;
            this.rBtnIP.Text = "IP             ";
            this.rBtnIP.UseVisualStyleBackColor = true;
            // 
            // List1
            // 
            this.List1.ForeColor = System.Drawing.Color.Red;
            this.List1.IntegralHeight = false;
            this.List1.Location = new System.Drawing.Point(376, 19);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(328, 91);
            this.List1.TabIndex = 26;
            this.List1.TabStop = false;
            // 
            // axBioBridgeSDKv3lib1
            // 
            this.axBioBridgeSDKv3lib1.Enabled = true;
            this.axBioBridgeSDKv3lib1.Location = new System.Drawing.Point(493, 276);
            this.axBioBridgeSDKv3lib1.Name = "axBioBridgeSDKv3lib1";
            this.axBioBridgeSDKv3lib1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axBioBridgeSDKv3lib1.OcxState")));
            this.axBioBridgeSDKv3lib1.Size = new System.Drawing.Size(137, 35);
            this.axBioBridgeSDKv3lib1.TabIndex = 101;
            this.axBioBridgeSDKv3lib1.Visible = false;
            // 
            // List2
            // 
            this.List2.ForeColor = System.Drawing.Color.Red;
            this.List2.IntegralHeight = false;
            this.List2.Location = new System.Drawing.Point(376, 116);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(328, 133);
            this.List2.TabIndex = 102;
            this.List2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 265);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.axBioBridgeSDKv3lib1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Sync";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axBioBridgeSDKv3lib1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Frame1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtTimeOut;
        public System.Windows.Forms.TextBox txtDelay;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtBaudRate;
        public System.Windows.Forms.TextBox txtCommPort;
        public System.Windows.Forms.TextBox txtCommKey;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtIPAdd;
        public System.Windows.Forms.Label lblTimeOut;
        public System.Windows.Forms.Label lblDelay;
        public System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.Label lblBaudRate;
        public System.Windows.Forms.Label lblCommPort;
        public System.Windows.Forms.Label lblCommKey;
        public System.Windows.Forms.Label lblPort;
        public System.Windows.Forms.Label lblIPAdd;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.RadioButton rBtnUSB;
        public System.Windows.Forms.RadioButton rBtnCOM;
        public System.Windows.Forms.RadioButton rBtnIP;
        public System.Windows.Forms.ListBox List1;
        private AxBioBridgeSDKv3.AxBioBridgeSDKv3lib axBioBridgeSDKv3lib1;
        public System.Windows.Forms.ListBox List2;
    }
}