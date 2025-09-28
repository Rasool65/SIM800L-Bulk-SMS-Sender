namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxSMS = new System.Windows.Forms.GroupBox();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.txtSingleMessage = new System.Windows.Forms.RichTextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.btnSingleSend = new System.Windows.Forms.Button();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblSingleText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.btnConnectToPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxRecive = new System.Windows.Forms.GroupBox();
            this.dgvRecivedSMS = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblModuleType = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblNetworkStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAntenStatus = new System.Windows.Forms.Label();
            this.lblSimStatus = new System.Windows.Forms.Label();
            this.lblAnten = new System.Windows.Forms.Label();
            this.lblSim = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpMultiSend = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpCustomerList = new System.Windows.Forms.GroupBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMultiMessage = new System.Windows.Forms.RichTextBox();
            this.btnMultiSend = new System.Windows.Forms.Button();
            this.lblMultiText = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxRecive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecivedSMS)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.grpMultiSend.SuspendLayout();
            this.grpCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSMS
            // 
            this.groupBoxSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSMS.Controls.Add(this.lblResultMessage);
            this.groupBoxSMS.Controls.Add(this.txtSingleMessage);
            this.groupBoxSMS.Controls.Add(this.txtPhoneNo);
            this.groupBoxSMS.Controls.Add(this.btnSingleSend);
            this.groupBoxSMS.Controls.Add(this.lblPhoneNo);
            this.groupBoxSMS.Controls.Add(this.lblSingleText);
            this.groupBoxSMS.Enabled = false;
            this.groupBoxSMS.Location = new System.Drawing.Point(335, 12);
            this.groupBoxSMS.Name = "groupBoxSMS";
            this.groupBoxSMS.Size = new System.Drawing.Size(315, 215);
            this.groupBoxSMS.TabIndex = 36;
            this.groupBoxSMS.TabStop = false;
            this.groupBoxSMS.Text = " ارسال تکی";
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.AutoSize = true;
            this.lblResultMessage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResultMessage.Location = new System.Drawing.Point(231, 129);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(0, 14);
            this.lblResultMessage.TabIndex = 33;
            // 
            // txtSingleMessage
            // 
            this.txtSingleMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSingleMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSingleMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSingleMessage.Location = new System.Drawing.Point(12, 52);
            this.txtSingleMessage.Name = "txtSingleMessage";
            this.txtSingleMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSingleMessage.Size = new System.Drawing.Size(211, 84);
            this.txtSingleMessage.TabIndex = 31;
            this.txtSingleMessage.Text = "";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNo.Location = new System.Drawing.Point(12, 22);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNo.Size = new System.Drawing.Size(211, 22);
            this.txtPhoneNo.TabIndex = 27;
            this.txtPhoneNo.Text = "+98";
            this.toolTip1.SetToolTip(this.txtPhoneNo, "+98912619XXXX");
            // 
            // btnSingleSend
            // 
            this.btnSingleSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSingleSend.Location = new System.Drawing.Point(12, 142);
            this.btnSingleSend.Name = "btnSingleSend";
            this.btnSingleSend.Size = new System.Drawing.Size(211, 25);
            this.btnSingleSend.TabIndex = 32;
            this.btnSingleSend.Text = "ارسال";
            this.btnSingleSend.UseVisualStyleBackColor = true;
            this.btnSingleSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(229, 26);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(74, 14);
            this.lblPhoneNo.TabIndex = 28;
            this.lblPhoneNo.Text = "شماره تلفن :";
            // 
            // lblSingleText
            // 
            this.lblSingleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSingleText.AutoSize = true;
            this.lblSingleText.Location = new System.Drawing.Point(243, 51);
            this.lblSingleText.Name = "lblSingleText";
            this.lblSingleText.Size = new System.Drawing.Size(56, 14);
            this.lblSingleText.TabIndex = 30;
            this.lblSingleText.Text = "متن پیام :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRefreshPorts);
            this.groupBox1.Controls.Add(this.btnConnectToPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPortList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 64);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshPorts.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Refresh_24x24;
            this.btnRefreshPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshPorts.Location = new System.Drawing.Point(71, 22);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(28, 25);
            this.btnRefreshPorts.TabIndex = 27;
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.buttonRefreshPorts_Click);
            // 
            // btnConnectToPort
            // 
            this.btnConnectToPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectToPort.Location = new System.Drawing.Point(14, 22);
            this.btnConnectToPort.Name = "btnConnectToPort";
            this.btnConnectToPort.Size = new System.Drawing.Size(55, 25);
            this.btnConnectToPort.TabIndex = 26;
            this.btnConnectToPort.Text = "اتصال";
            this.btnConnectToPort.UseVisualStyleBackColor = true;
            this.btnConnectToPort.Click += new System.EventHandler(this.buttonConnectToPort_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "انتخاب پورت :";
            // 
            // cmbPortList
            // 
            this.cmbPortList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(103, 23);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(119, 22);
            this.cmbPortList.TabIndex = 24;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipTitle = "مثال";
            // 
            // grpBoxRecive
            // 
            this.grpBoxRecive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxRecive.Controls.Add(this.dgvRecivedSMS);
            this.grpBoxRecive.Enabled = false;
            this.grpBoxRecive.Location = new System.Drawing.Point(12, 233);
            this.grpBoxRecive.Name = "grpBoxRecive";
            this.grpBoxRecive.Size = new System.Drawing.Size(638, 318);
            this.grpBoxRecive.TabIndex = 37;
            this.grpBoxRecive.TabStop = false;
            this.grpBoxRecive.Text = " پیامک های دریافتی ";
            // 
            // dgvRecivedSMS
            // 
            this.dgvRecivedSMS.AllowUserToAddRows = false;
            this.dgvRecivedSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecivedSMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dgvRecivedSMS.Location = new System.Drawing.Point(6, 21);
            this.dgvRecivedSMS.MultiSelect = false;
            this.dgvRecivedSMS.Name = "dgvRecivedSMS";
            this.dgvRecivedSMS.ReadOnly = true;
            this.dgvRecivedSMS.RowHeadersVisible = false;
            this.dgvRecivedSMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecivedSMS.Size = new System.Drawing.Size(626, 291);
            this.dgvRecivedSMS.TabIndex = 0;
            this.dgvRecivedSMS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceivedSMS_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "زمان";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شماره";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "متن";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // grpStatus
            // 
            this.grpStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStatus.Controls.Add(this.lblModuleType);
            this.grpStatus.Controls.Add(this.lblModule);
            this.grpStatus.Controls.Add(this.lblNetworkStatus);
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Controls.Add(this.lblAntenStatus);
            this.grpStatus.Controls.Add(this.lblSimStatus);
            this.grpStatus.Controls.Add(this.lblAnten);
            this.grpStatus.Controls.Add(this.lblSim);
            this.grpStatus.Enabled = false;
            this.grpStatus.Location = new System.Drawing.Point(12, 82);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(317, 145);
            this.grpStatus.TabIndex = 38;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = " وضعیت ";
            // 
            // lblModuleType
            // 
            this.lblModuleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModuleType.Location = new System.Drawing.Point(14, 110);
            this.lblModuleType.Name = "lblModuleType";
            this.lblModuleType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblModuleType.Size = new System.Drawing.Size(215, 14);
            this.lblModuleType.TabIndex = 38;
            this.lblModuleType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModule
            // 
            this.lblModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(233, 110);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(61, 14);
            this.lblModule.TabIndex = 37;
            this.lblModule.Text = "نوع ماژول :";
            // 
            // lblNetworkStatus
            // 
            this.lblNetworkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetworkStatus.Location = new System.Drawing.Point(14, 82);
            this.lblNetworkStatus.Name = "lblNetworkStatus";
            this.lblNetworkStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNetworkStatus.Size = new System.Drawing.Size(191, 14);
            this.lblNetworkStatus.TabIndex = 36;
            this.lblNetworkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(211, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 14);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "وضعیت شبکه :";
            // 
            // lblAntenStatus
            // 
            this.lblAntenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAntenStatus.Location = new System.Drawing.Point(17, 52);
            this.lblAntenStatus.Name = "lblAntenStatus";
            this.lblAntenStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAntenStatus.Size = new System.Drawing.Size(212, 14);
            this.lblAntenStatus.TabIndex = 34;
            this.lblAntenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSimStatus
            // 
            this.lblSimStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimStatus.ForeColor = System.Drawing.Color.Green;
            this.lblSimStatus.Location = new System.Drawing.Point(17, 22);
            this.lblSimStatus.Name = "lblSimStatus";
            this.lblSimStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSimStatus.Size = new System.Drawing.Size(212, 14);
            this.lblSimStatus.TabIndex = 33;
            this.lblSimStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnten
            // 
            this.lblAnten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnten.AutoSize = true;
            this.lblAnten.Location = new System.Drawing.Point(230, 52);
            this.lblAnten.Name = "lblAnten";
            this.lblAnten.Size = new System.Drawing.Size(64, 14);
            this.lblAnten.TabIndex = 32;
            this.lblAnten.Text = "آنتن دهی :";
            // 
            // lblSim
            // 
            this.lblSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSim.AutoSize = true;
            this.lblSim.Location = new System.Drawing.Point(232, 22);
            this.lblSim.Name = "lblSim";
            this.lblSim.Size = new System.Drawing.Size(62, 14);
            this.lblSim.TabIndex = 31;
            this.lblSim.Text = "سیمکارت :";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpMultiSend
            // 
            this.grpMultiSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMultiSend.Controls.Add(this.lblProgress);
            this.grpMultiSend.Controls.Add(this.progressBar1);
            this.grpMultiSend.Controls.Add(this.btnUploadExcel);
            this.grpMultiSend.Controls.Add(this.label7);
            this.grpMultiSend.Controls.Add(this.txtMultiMessage);
            this.grpMultiSend.Controls.Add(this.btnMultiSend);
            this.grpMultiSend.Controls.Add(this.lblMultiText);
            this.grpMultiSend.Enabled = false;
            this.grpMultiSend.Location = new System.Drawing.Point(656, 12);
            this.grpMultiSend.Name = "grpMultiSend";
            this.grpMultiSend.Size = new System.Drawing.Size(315, 215);
            this.grpMultiSend.TabIndex = 40;
            this.grpMultiSend.TabStop = false;
            this.grpMultiSend.Text = "ارسال گروهی";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(131, 175);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 14);
            this.lblProgress.TabIndex = 39;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(285, 23);
            this.progressBar1.TabIndex = 38;
            // 
            // grpCustomerList
            // 
            this.grpCustomerList.Controls.Add(this.dgvCustomerList);
            this.grpCustomerList.Location = new System.Drawing.Point(656, 238);
            this.grpCustomerList.Name = "grpCustomerList";
            this.grpCustomerList.Size = new System.Drawing.Size(315, 313);
            this.grpCustomerList.TabIndex = 37;
            this.grpCustomerList.TabStop = false;
            this.grpCustomerList.Text = "لیست مشتریان";
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToOrderColumns = true;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.MobileNumber});
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomerList.Location = new System.Drawing.Point(3, 18);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(309, 289);
            this.dgvCustomerList.TabIndex = 36;
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Location = new System.Drawing.Point(29, 21);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(211, 23);
            this.btnUploadExcel.TabIndex = 35;
            this.btnUploadExcel.Text = "انتخاب فایل اکسل";
            this.btnUploadExcel.UseVisualStyleBackColor = true;
            this.btnUploadExcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(158, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 14);
            this.label7.TabIndex = 33;
            // 
            // txtMultiMessage
            // 
            this.txtMultiMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultiMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMultiMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMultiMessage.Location = new System.Drawing.Point(29, 52);
            this.txtMultiMessage.Name = "txtMultiMessage";
            this.txtMultiMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMultiMessage.Size = new System.Drawing.Size(211, 84);
            this.txtMultiMessage.TabIndex = 31;
            this.txtMultiMessage.Text = "";
            this.toolTip2.SetToolTip(this.txtMultiMessage, "[name] عزیز");
            // 
            // btnMultiSend
            // 
            this.btnMultiSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiSend.Location = new System.Drawing.Point(29, 142);
            this.btnMultiSend.Name = "btnMultiSend";
            this.btnMultiSend.Size = new System.Drawing.Size(211, 25);
            this.btnMultiSend.TabIndex = 32;
            this.btnMultiSend.Text = "ارسال";
            this.btnMultiSend.UseVisualStyleBackColor = true;
            this.btnMultiSend.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // lblMultiText
            // 
            this.lblMultiText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMultiText.AutoSize = true;
            this.lblMultiText.Location = new System.Drawing.Point(246, 51);
            this.lblMultiText.Name = "lblMultiText";
            this.lblMultiText.Size = new System.Drawing.Size(56, 14);
            this.lblMultiText.TabIndex = 30;
            this.lblMultiText.Text = "متن پیام :";
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 2000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.ReshowDelay = 10;
            this.toolTip2.ToolTipTitle = "مثال";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.Width = 185;
            // 
            // MobileNumber
            // 
            this.MobileNumber.HeaderText = "شماره همراه";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Width = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 563);
            this.Controls.Add(this.grpCustomerList);
            this.Controls.Add(this.grpMultiSend);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.groupBoxSMS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxRecive);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ارسال و دریافت پیامک (مهرپویان)";
            this.groupBoxSMS.ResumeLayout(false);
            this.groupBoxSMS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxRecive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecivedSMS)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpMultiSend.ResumeLayout(false);
            this.grpMultiSend.PerformLayout();
            this.grpCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSMS;
        private System.Windows.Forms.RichTextBox txtSingleMessage;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Button btnSingleSend;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblSingleText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnectToPort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.GroupBox grpBoxRecive;
        private System.Windows.Forms.DataGridView dgvRecivedSMS;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblAnten;
        private System.Windows.Forms.Label lblSim;
        private System.Windows.Forms.Label lblNetworkStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAntenStatus;
        private System.Windows.Forms.Label lblSimStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblModuleType;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.GroupBox grpMultiSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtMultiMessage;
        private System.Windows.Forms.Button btnMultiSend;
        private System.Windows.Forms.Label lblMultiText;
        private System.Windows.Forms.Button btnUploadExcel;
        private System.Windows.Forms.GroupBox grpCustomerList;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
    }
}

