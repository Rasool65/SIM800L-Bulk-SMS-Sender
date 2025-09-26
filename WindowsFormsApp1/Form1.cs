
using ClosedXML.Excel;
using System;
using System.Data;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        string SMSNum;
        bool SendFlag = false;
        bool SimStatusFlag = false;
        string indata = "";
        string ModuleType = "sim800c";
        private DataTable dt; // جدول دیتا در سطح فرم

        #region Form1
        public Form1()
        {
            InitializeComponent();

            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbPortList.Items.Add(s);
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }
        #endregion

        #region buttonConnectToPort_Click
        private void buttonConnectToPort_Click(object sender, EventArgs e)
        {
            if (btnConnectToPort.Text == "اتصال")
            {
                if (cmbPortList.Text != string.Empty)
                {
                    serialPort1.PortName = cmbPortList.Text;
                    serialPort1.BaudRate = 9600;

                    if (!serialPort1.IsOpen)
                        try
                        {
                            indata = "";
                            serialPort1.Open();
                            serialPort1.NewLine = "\r";

                            serialPort1.WriteLine("AT");
                            Thread.Sleep(200);

                            int t = 10000;
                            bool Connect = false;

                            while (t > 0)
                            {
                                Thread.Sleep(1);
                                if (indata.Contains("OK"))
                                {
                                    Connect = true;
                                    break;
                                }
                                t--;
                            }

                            //bool Connect = true;
                            if (Connect)
                            {

                                serialPort1.WriteLine("AT+GOI");
                                Thread.Sleep(500);

                                if (indata.ToUpper().Contains("R800"))
                                {
                                    ModuleType = "R800C";
                                    lblModuleType.Text = "R800C";
                                }
                                else if (indata.ToUpper().Contains("SIM800"))
                                {
                                    ModuleType = "SIM800C";
                                    lblModuleType.Text = "SIM800C";
                                }
                                grpMultiSend.Enabled = true;
                                btnRefreshPorts.Enabled = false;
                                cmbPortList.Enabled = false;
                                btnConnectToPort.Text = "قطع";
                                groupBoxSMS.Enabled = true;
                                grpBoxRecive.Enabled = true;
                                grpStatus.Enabled = true;

                                serialPort1.WriteLine("AT+CMGD=1,4"); // Delete All SMS from SIM
                                Thread.Sleep(500);

                                //Enable Recive SMS
                                serialPort1.WriteLine("AT+CNMI=2,1,0,1,0");
                                Thread.Sleep(150);

                                //Sim Status - وضعیت سیمکارت
                                lblSimStatus.ForeColor = Color.Green;
                                lblSimStatus.Text = "متصل";
                                SimStatusFlag = true;
                                serialPort1.WriteLine("AT+CIMI");
                                Thread.Sleep(150);


                                //Anten Status - وضعیت آنتن
                                serialPort1.WriteLine("AT+CSQ");
                                Thread.Sleep(150);

                                //Network Status - وضعیت شبکه
                                serialPort1.WriteLine("AT+CREG?");
                                Thread.Sleep(150);

                                // timer1.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("اتصال بر قرار نشد");
                                if (serialPort1.IsOpen)
                                    serialPort1.Close();
                                indata = "";
                            }
                        }
                        catch
                        {
                            MessageBox.Show("اتصال بر قرار نشد");
                        }
                }
                else
                {
                    MessageBox.Show("لطفاً پورت مورد نظر را انتخاب فرمایید");
                    cmbPortList.Select();
                }
            }
            else
            {
                serialPort1.Close();
                indata = "";
                cmbPortList.Enabled = true;
                btnConnectToPort.Text = "اتصال";
                groupBoxSMS.Enabled = false;
                grpBoxRecive.Enabled = false;
                grpStatus.Enabled = false;

                lblModuleType.Text = "";
                lblSimStatus.Text = "";
                lblAntenStatus.Text = "";
                lblNetworkStatus.Text = "";
                btnRefreshPorts.Enabled = true;

                timer1.Enabled = false;
            }
        }
        #endregion

        #region buttonSend_Click
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                serialPort1.WriteLine("AT+CMGF=1");
                Thread.Sleep(100);
                serialPort1.WriteLine("AT+CSCS=\"HEX\"");
                Thread.Sleep(100);
                serialPort1.WriteLine("AT+CSMP=17,167,0,8");
                Thread.Sleep(100);
                this.Cursor = Cursors.WaitCursor;
                SendFlag = true;
                SendSMSFunction(txtPhoneNo.Text, txtSingleMessage.Text);
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Validation
        private bool Validation()
        {
            if (txtPhoneNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("لطفا شماره موبایل را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Select();
                return false;
            }

            if (txtPhoneNo.Text.Trim().Length != 13)
            {
                MessageBox.Show("شماره وارد شده صحیح نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Select();
                return false;
            }

            if (txtSingleMessage.Text.Trim() == string.Empty)
            {
                if (MessageBox.Show("متن پیامک خالی می باشد.آیا ارسال شود؟", "هشدر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    txtSingleMessage.Select();
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region SendSMSFunction
        private void SendSMSFunction(string PhoneNo, string Message)
        {
            serialPort1.WriteLine("AT+CMGS=\"" + PhoneNo + "\"");
            Thread.Sleep(100);
            serialPort1.Write(StringToHex(Message) + '\x001a');
        }
        #endregion

        #region StringToHex
        private string StringToHex(string hexstring)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in hexstring)
            {
                if (Convert.ToInt32(t).ToString("X").Length == 1)
                    sb.Append("000" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 2)
                    sb.Append("00" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 3)
                    sb.Append("0" + Convert.ToInt32(t).ToString("X"));
            }
            return sb.ToString();
        }
        #endregion

        #region StringToHex2
        private string StringToHex2(string hexstring)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in hexstring)
            {
                if (Convert.ToInt32(t).ToString("X").Length == 1)
                    sb.Append("000" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 2)
                    sb.Append(Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 3)
                    sb.Append("0" + Convert.ToInt32(t).ToString("X"));
            }
            return sb.ToString();
        }
        #endregion

        #region DataReceivedHandler
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                indata = sp.ReadExisting();

                if (indata.Contains("+CMGS:"))
                {
                    lblResultMessage.ForeColor = Color.Green;
                    lblResultMessage.Text = "ارسال شد";
                    SendFlag = false;
                }
                else if (indata.Contains("ERROR") && SendFlag)
                {
                    lblResultMessage.ForeColor = Color.Red;
                    lblResultMessage.Text = "ارسال نشد";
                    SendFlag = false;
                }
                else if (indata.Contains("+CMTI:")) //دریافت پیامک مرحله اول
                {

                    indata = indata.Replace("\r\n", "");
                    string[] c = indata.Split(',');
                    SMSNum = c[1];

                    serialPort1.WriteLine("AT+CMGF=1");
                    Thread.Sleep(150);
                    serialPort1.WriteLine("AT+CSCS=\"UCS2\"");
                    Thread.Sleep(150);
                    serialPort1.WriteLine("AT+CSMP=17,167,0,0");
                    Thread.Sleep(150);
                    //serialPort1.WriteLine("AT+CMGR=" + SMSNum + ",1");
                    serialPort1.WriteLine("AT+CMGR=" + SMSNum);
                    Thread.Sleep(1000);
                }
                else if (indata.Contains("+CMGR:"))// دریافت پیامک مرحله دوم
                {
                    string temp = indata.Substring(indata.IndexOf("+CMGR:"));
                    string[] RData = temp.Split(',');
                    string Phone = RData[1].Replace("\"", "");
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < Phone.Length; j += 4)
                        sb.AppendFormat("\\u{0:x4}", Phone.Substring(j, 4));
                    Phone = System.Text.RegularExpressions.Regex.Unescape(sb.ToString());
                    Phone = "0" + Phone.Substring(3);

                    temp = RData[4].Substring(RData[4].IndexOf("\r\n") + 2);
                    temp = temp.Remove(temp.IndexOf("\r\n"));
                    sb.Remove(0, sb.Length);
                    for (int j = 0; j < temp.Length; j += 4)
                        sb.AppendFormat("\\u{0:x4}", temp.Substring(j, 4));
                    string Msg = System.Text.RegularExpressions.Regex.Unescape(sb.ToString());

                    try
                    {
                        dgvRecivedSMS.Rows.Add();
                        dgvRecivedSMS[0, dgvRecivedSMS.Rows.Count - 1].Value = DateTime.Now;
                        dgvRecivedSMS[1, dgvRecivedSMS.Rows.Count - 1].Value = Phone;
                        dgvRecivedSMS[2, dgvRecivedSMS.Rows.Count - 1].Value = Msg;
                        dgvRecivedSMS.Sort(dgvRecivedSMS.Columns[0], System.ComponentModel.ListSortDirection.Descending);
                    }
                    catch (Exception exp)
                    {

                    }
                    serialPort1.WriteLine("AT+CMGD=" + SMSNum); // Delete SMS from SIM
                    Thread.Sleep(150);
                }
                else if (indata.Contains("+CSQ:")) //درصد آنتن
                {
                    int p = Convert.ToInt32(Regex.Match(indata, @"\d+").ToString());
                    p = (p * 827) + 127;
                    p = p >> 8;
                    p = (p > 100) ? 100 : p;
                    lblAntenStatus.Text = p.ToString() + "%";
                }
                else if (indata.Contains("+CREG:"))//وضعیت شبکه
                {
                    string[] RData = indata.Substring(indata.IndexOf("+CREG:") + 6).Split(',');
                    switch (int.Parse(RData[1].Substring(0, 1)))
                    {
                        case 0:
                            lblNetworkStatus.Text = "Not registered, Not searching";
                            break;
                        case 1:
                            lblNetworkStatus.Text = "Registered, home network";
                            break;
                        case 2:
                            lblNetworkStatus.Text = "Not registered, searching...";
                            break;
                        case 3:
                            lblNetworkStatus.Text = "Registration denied";
                            break;
                        case 4:
                            lblNetworkStatus.Text = "Unknown";
                            break;
                        case 5:
                            lblNetworkStatus.Text = "Registered, roaming";
                            break;
                        default:
                            lblNetworkStatus.Text = indata.Substring(indata.IndexOf("+CREG:") + 6);
                            break;
                    }
                    //labelNetworkStatus.Text = indata.Substring(indata.IndexOf("+CREG:")+6);

                }
                else if (indata.Contains("ERROR") && SimStatusFlag)//وضعیت سیمکارت
                {
                    lblSimStatus.ForeColor = Color.Red;
                    lblSimStatus.Text = "سیمکارت وارد نشده است";
                    SimStatusFlag = false;
                }
            }
            catch
            {

            }
        }
        #endregion


        #region buttonRefreshPorts_Click
        private void buttonRefreshPorts_Click(object sender, EventArgs e)
        {
            cmbPortList.Items.Clear();
            cmbPortList.Text = String.Empty;

            if (SerialPort.GetPortNames().Length == 0)
            {
                return;
            }

            foreach (var portName in SerialPort.GetPortNames())
            {
                cmbPortList.Items.Add(portName);
            }
            cmbPortList.SelectedIndex = 0;

        }
        #endregion

        #region dataGridViewRecivedSMS_CellDoubleClick
        private void dataGridViewRecivedSMS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(dgvRecivedSMS.CurrentRow.Cells[2].Value.ToString(), "متن پیامک");
            }
            catch (Exception exp)
            {

            }
        }
        #endregion

        #region timer1_Tick For Update Status
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Sim Status - وضعیت سیمکارت
            lblSimStatus.ForeColor = Color.Green;
            lblSimStatus.Text = "متصل";
            SimStatusFlag = true;
            serialPort1.WriteLine("AT+CIMI");
            Thread.Sleep(150);


            //Anten Status - وضعیت آنتن
            serialPort1.WriteLine("AT+CSQ");
            Thread.Sleep(150);

            //Network Status - وضعیت شبکه
            serialPort1.WriteLine("AT+CREG?");
            Thread.Sleep(150);
        }
        #endregion

        private DataTable ReadExcelFile(string filePath)
        {
            DataTable dt = new DataTable();

            // ستونی که توی DataGridView داری باید همین اسامی رو داشته باشه
            dt.Columns.Add("MobileNumber");
            dt.Columns.Add("FullName");

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // شیت اول
                var rows = worksheet.RangeUsed().RowsUsed();

                bool isFirstRow = true;
                foreach (var row in rows)
                {
                    if (isFirstRow)
                    {
                        isFirstRow = false; // هدر رد بشه
                        continue;
                    }

                    string mobile = row.Cell(1).GetValue<string>(); // ستون اول → شماره
                    string fullname = row.Cell(2).GetValue<string>(); // ستون دوم → نام

                    dt.Rows.Add(mobile, fullname);
                }
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "یک فایل اکسل انتخاب کنید";
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    dt = ReadExcelFile(filePath);

                    // ستون‌ها رو دستی طراحی کردی، پس AutoGenerateColumns = false
                    dgvCustomerList.AutoGenerateColumns = false;

                    // اتصال ستون‌های طراحی‌شده به DataTable
                    dgvCustomerList.Columns["MobileNumber"].DataPropertyName = "MobileNumber";
                    dgvCustomerList.Columns["FullName"].DataPropertyName = "FullName";

                    dgvCustomerList.DataSource = dt;
                }
            }
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("AT+CMGF=1");
            Thread.Sleep(100);
            serialPort1.WriteLine("AT+CSCS=\"HEX\"");
            Thread.Sleep(100);
            serialPort1.WriteLine("AT+CSMP=17,167,0,8");
            Thread.Sleep(100);
            this.Cursor = Cursors.WaitCursor;
            SendFlag = true;
            foreach (DataGridViewRow row in dgvCustomerList.Rows)
            {
                if (!row.IsNewRow) // برای ردیف خالی آخر
                {
                    var phoneNumber = row.Cells["MobileNumber"].Value;
                    var fullName = row.Cells["FullName"].Value;
                    SendSMSFunction(phoneNumber.ToString(), txtMultiMessage.Text.Replace("[Name]", fullName.ToString()));
                }
                Thread.Sleep(8000);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
