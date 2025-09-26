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
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMSG = new System.Windows.Forms.RichTextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefreshPorts = new System.Windows.Forms.Button();
            this.buttonConnectToPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPortList = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxRecive = new System.Windows.Forms.GroupBox();
            this.dataGridViewRecivedSMS = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelModuleType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNetworkStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAntenStatus = new System.Windows.Forms.Label();
            this.labelSimStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SMStxtBox = new System.Windows.Forms.RichTextBox();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRecive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecivedSMS)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSMS
            // 
            this.groupBoxSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSMS.Controls.Add(this.checkBoxHex);
            this.groupBoxSMS.Controls.Add(this.label2);
            this.groupBoxSMS.Controls.Add(this.richTextBoxMSG);
            this.groupBoxSMS.Controls.Add(this.textBoxPhone);
            this.groupBoxSMS.Controls.Add(this.buttonSend);
            this.groupBoxSMS.Controls.Add(this.label1);
            this.groupBoxSMS.Controls.Add(this.label4);
            this.groupBoxSMS.Enabled = false;
            this.groupBoxSMS.Location = new System.Drawing.Point(420, 12);
            this.groupBoxSMS.Name = "groupBoxSMS";
            this.groupBoxSMS.Size = new System.Drawing.Size(315, 215);
            this.groupBoxSMS.TabIndex = 36;
            this.groupBoxSMS.TabStop = false;
            this.groupBoxSMS.Text = " ارسال تکی";
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.AutoSize = true;
            this.checkBoxHex.Location = new System.Drawing.Point(171, 18);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(54, 18);
            this.checkBoxHex.TabIndex = 34;
            this.checkBoxHex.Text = "متد 2";
            this.checkBoxHex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(231, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 33;
            // 
            // richTextBoxMSG
            // 
            this.richTextBoxMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMSG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMSG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBoxMSG.Location = new System.Drawing.Point(12, 73);
            this.richTextBoxMSG.Name = "richTextBoxMSG";
            this.richTextBoxMSG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxMSG.Size = new System.Drawing.Size(211, 97);
            this.richTextBoxMSG.TabIndex = 31;
            this.richTextBoxMSG.Text = "";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Location = new System.Drawing.Point(12, 42);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPhone.Size = new System.Drawing.Size(211, 22);
            this.textBoxPhone.TabIndex = 27;
            this.textBoxPhone.Text = "+98";
            this.toolTip1.SetToolTip(this.textBoxPhone, "+98912619XXXX");
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(12, 177);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(211, 25);
            this.buttonSend.TabIndex = 32;
            this.buttonSend.Text = "ارسال";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "شماره تلفن :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 30;
            this.label4.Text = "متن پیام :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonRefreshPorts);
            this.groupBox1.Controls.Add(this.buttonConnectToPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxPortList);
            this.groupBox1.Location = new System.Drawing.Point(741, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 64);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // buttonRefreshPorts
            // 
            this.buttonRefreshPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshPorts.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Refresh_24x24;
            this.buttonRefreshPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshPorts.Location = new System.Drawing.Point(71, 22);
            this.buttonRefreshPorts.Name = "buttonRefreshPorts";
            this.buttonRefreshPorts.Size = new System.Drawing.Size(28, 25);
            this.buttonRefreshPorts.TabIndex = 27;
            this.buttonRefreshPorts.UseVisualStyleBackColor = true;
            this.buttonRefreshPorts.Click += new System.EventHandler(this.buttonRefreshPorts_Click);
            // 
            // buttonConnectToPort
            // 
            this.buttonConnectToPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnectToPort.Location = new System.Drawing.Point(14, 22);
            this.buttonConnectToPort.Name = "buttonConnectToPort";
            this.buttonConnectToPort.Size = new System.Drawing.Size(55, 25);
            this.buttonConnectToPort.TabIndex = 26;
            this.buttonConnectToPort.Text = "اتصال";
            this.buttonConnectToPort.UseVisualStyleBackColor = true;
            this.buttonConnectToPort.Click += new System.EventHandler(this.buttonConnectToPort_Click);
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
            // comboBoxPortList
            // 
            this.comboBoxPortList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPortList.FormattingEnabled = true;
            this.comboBoxPortList.Location = new System.Drawing.Point(103, 23);
            this.comboBoxPortList.Name = "comboBoxPortList";
            this.comboBoxPortList.Size = new System.Drawing.Size(119, 22);
            this.comboBoxPortList.TabIndex = 24;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipTitle = "مثال";
            // 
            // groupBoxRecive
            // 
            this.groupBoxRecive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRecive.Controls.Add(this.dataGridViewRecivedSMS);
            this.groupBoxRecive.Enabled = false;
            this.groupBoxRecive.Location = new System.Drawing.Point(420, 229);
            this.groupBoxRecive.Name = "groupBoxRecive";
            this.groupBoxRecive.Size = new System.Drawing.Size(638, 250);
            this.groupBoxRecive.TabIndex = 37;
            this.groupBoxRecive.TabStop = false;
            this.groupBoxRecive.Text = " پیامک های دریافتی ";
            // 
            // dataGridViewRecivedSMS
            // 
            this.dataGridViewRecivedSMS.AllowUserToAddRows = false;
            this.dataGridViewRecivedSMS.AllowUserToDeleteRows = false;
            this.dataGridViewRecivedSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecivedSMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridViewRecivedSMS.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewRecivedSMS.MultiSelect = false;
            this.dataGridViewRecivedSMS.Name = "dataGridViewRecivedSMS";
            this.dataGridViewRecivedSMS.ReadOnly = true;
            this.dataGridViewRecivedSMS.RowHeadersVisible = false;
            this.dataGridViewRecivedSMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecivedSMS.Size = new System.Drawing.Size(620, 214);
            this.dataGridViewRecivedSMS.TabIndex = 0;
            this.dataGridViewRecivedSMS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecivedSMS_CellDoubleClick);
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
            // groupBoxStatus
            // 
            this.groupBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatus.Controls.Add(this.labelModuleType);
            this.groupBoxStatus.Controls.Add(this.label8);
            this.groupBoxStatus.Controls.Add(this.labelNetworkStatus);
            this.groupBoxStatus.Controls.Add(this.label9);
            this.groupBoxStatus.Controls.Add(this.labelAntenStatus);
            this.groupBoxStatus.Controls.Add(this.labelSimStatus);
            this.groupBoxStatus.Controls.Add(this.label6);
            this.groupBoxStatus.Controls.Add(this.label5);
            this.groupBoxStatus.Enabled = false;
            this.groupBoxStatus.Location = new System.Drawing.Point(741, 78);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(317, 145);
            this.groupBoxStatus.TabIndex = 38;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = " وضعیت ";
            // 
            // labelModuleType
            // 
            this.labelModuleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModuleType.Location = new System.Drawing.Point(14, 110);
            this.labelModuleType.Name = "labelModuleType";
            this.labelModuleType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelModuleType.Size = new System.Drawing.Size(215, 14);
            this.labelModuleType.TabIndex = 38;
            this.labelModuleType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 37;
            this.label8.Text = "نوع ماژول :";
            // 
            // labelNetworkStatus
            // 
            this.labelNetworkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNetworkStatus.Location = new System.Drawing.Point(14, 82);
            this.labelNetworkStatus.Name = "labelNetworkStatus";
            this.labelNetworkStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNetworkStatus.Size = new System.Drawing.Size(191, 14);
            this.labelNetworkStatus.TabIndex = 36;
            this.labelNetworkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 14);
            this.label9.TabIndex = 35;
            this.label9.Text = "وضعیت شبکه :";
            // 
            // labelAntenStatus
            // 
            this.labelAntenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAntenStatus.Location = new System.Drawing.Point(17, 52);
            this.labelAntenStatus.Name = "labelAntenStatus";
            this.labelAntenStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAntenStatus.Size = new System.Drawing.Size(212, 14);
            this.labelAntenStatus.TabIndex = 34;
            this.labelAntenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimStatus
            // 
            this.labelSimStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSimStatus.ForeColor = System.Drawing.Color.Green;
            this.labelSimStatus.Location = new System.Drawing.Point(17, 22);
            this.labelSimStatus.Name = "labelSimStatus";
            this.labelSimStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSimStatus.Size = new System.Drawing.Size(212, 14);
            this.labelSimStatus.TabIndex = 33;
            this.labelSimStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 32;
            this.label6.Text = "آنتن دهی :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "سیمکارت :";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnUploadExcel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SMStxtBox);
            this.groupBox2.Controls.Add(this.btnSendAll);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(80, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 467);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ارسال گروهی";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(7, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 244);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست مشتریان";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.MobileNumber});
            this.dataGridView1.Location = new System.Drawing.Point(10, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 214);
            this.dataGridView1.TabIndex = 36;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.Width = 140;
            // 
            // MobileNumber
            // 
            this.MobileNumber.HeaderText = "شماره همراه";
            this.MobileNumber.Name = "MobileNumber";
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Location = new System.Drawing.Point(17, 20);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(306, 23);
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
            // SMStxtBox
            // 
            this.SMStxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMStxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SMStxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SMStxtBox.Location = new System.Drawing.Point(12, 73);
            this.SMStxtBox.Name = "SMStxtBox";
            this.SMStxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SMStxtBox.Size = new System.Drawing.Size(316, 97);
            this.SMStxtBox.TabIndex = 31;
            this.SMStxtBox.Text = "";
            this.toolTip2.SetToolTip(this.SMStxtBox, "[name] عزیز");
            // 
            // btnSendAll
            // 
            this.btnSendAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendAll.Location = new System.Drawing.Point(17, 176);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(131, 25);
            this.btnSendAll.TabIndex = 32;
            this.btnSendAll.Text = "ارسال";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 30;
            this.label11.Text = "متن پیام :";
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 2000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.ReshowDelay = 10;
            this.toolTip2.ToolTipTitle = "مثال";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxRecive);
            this.Controls.Add(this.groupBoxSMS);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ارسال و دریافت پیامک (مهرپویان)";
            this.groupBoxSMS.ResumeLayout(false);
            this.groupBoxSMS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRecive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecivedSMS)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSMS;
        private System.Windows.Forms.RichTextBox richTextBoxMSG;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPortList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnectToPort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRecive;
        private System.Windows.Forms.DataGridView dataGridViewRecivedSMS;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNetworkStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAntenStatus;
        private System.Windows.Forms.Label labelSimStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buttonRefreshPorts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelModuleType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxHex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox SMStxtBox;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUploadExcel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

