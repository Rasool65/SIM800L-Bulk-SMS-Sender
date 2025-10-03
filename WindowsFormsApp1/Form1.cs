
using ClosedXML.Excel;
using System;
using System.Data;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly SerialPort _serialPort1 = new SerialPort();
        private string SMSNum;
        private bool _sendFlag = false;
        private bool _simStatusFlag = false;
        private CancellationTokenSource _cts;
        private string _inData = "";
        private string _moduleType = "sim800c";
        private DataTable dt; // جدول دیتا در سطح فرم

        #region Form1
        public Form1()
        {
            InitializeComponent();

            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            foreach (var s in SerialPort.GetPortNames())
            {
                cmbPortList.Items.Add(s);
            }
            _serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }
        #endregion

        #region buttonConnectToPort_Click
        private void buttonConnectToPort_Click(object sender, EventArgs e)
        {
            if (btnConnectToPort.Text == "اتصال")
            {
                if (cmbPortList.Text != string.Empty)
                {

                    _serialPort1.PortName = cmbPortList.Text;
                    _serialPort1.BaudRate = 9600;

                    if (!_serialPort1.IsOpen)
                        try
                        {
                            _inData = "";
                            _serialPort1.Open();
                            _serialPort1.NewLine = "\r";

                            _serialPort1.WriteLine("AT");
                            Thread.Sleep(200);

                            int t = 10000;
                            bool Connect = false;

                            while (t > 0)
                            {
                                Thread.Sleep(1);
                                if (_inData.Contains("OK"))
                                {
                                    Connect = true;
                                    break;
                                }
                                t--;
                            }

                            //bool Connect = true;
                            if (Connect)
                            {

                                _serialPort1.WriteLine("AT+GOI");
                                Thread.Sleep(500);

                                if (_inData.ToUpper().Contains("R800"))
                                {
                                    _moduleType = "R800C";
                                    lblModuleType.Text = "R800C";
                                }
                                else if (_inData.ToUpper().Contains("SIM800"))
                                {
                                    _moduleType = "SIM800C";
                                    lblModuleType.Text = "SIM800C";
                                }
                                grpMultiSend.Enabled = true;
                                btnRefreshPorts.Enabled = false;
                                cmbPortList.Enabled = false;
                                btnConnectToPort.Text = "قطع";
                                groupBoxSMS.Enabled = true;
                                grpBoxRecive.Enabled = true;
                                grpStatus.Enabled = true;

                                _serialPort1.WriteLine("AT+CMGD=1,4"); // Delete All SMS from SIM
                                Thread.Sleep(500);

                                //Enable Recive SMS
                                _serialPort1.WriteLine("AT+CNMI=2,1,0,1,0");
                                Thread.Sleep(150);

                                //Sim Status - وضعیت سیمکارت
                                lblSimStatus.ForeColor = Color.Green;
                                lblSimStatus.Text = "متصل";
                                _simStatusFlag = true;
                                _serialPort1.WriteLine("AT+CIMI");
                                Thread.Sleep(150);


                                //Anten Status - وضعیت آنتن
                                _serialPort1.WriteLine("AT+CSQ");
                                Thread.Sleep(150);

                                //Network Status - وضعیت شبکه
                                _serialPort1.WriteLine("AT+CREG?");
                                Thread.Sleep(150);

                                timer1.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("اتصال بر قرار نشد");
                                if (_serialPort1.IsOpen)
                                    _serialPort1.Close();
                                _inData = "";
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
                _serialPort1.Close();
                _inData = "";
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
                _serialPort1.WriteLine("AT+CMGF=1");
                Thread.Sleep(100);
                _serialPort1.WriteLine("AT+CSCS=\"HEX\"");
                Thread.Sleep(100);
                _serialPort1.WriteLine("AT+CSMP=17,167,0,8");
                Thread.Sleep(100);
                this.Cursor = Cursors.WaitCursor;
                _sendFlag = true;
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
        private void SendSMSFunction(string phoneNo, string message)
        {
            _serialPort1.WriteLine("AT+CMGS=\"" + phoneNo + "\"");
            Thread.Sleep(100);
            _serialPort1.Write(StringToHex(message) + '\x001a');
        }
        #endregion

        #region StringToHex
        private string StringToHex(string hexString)
        {
            var sb = new StringBuilder();
            foreach (var t in hexString)
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

        #region DataReceivedHandler
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var sp = (SerialPort)sender;
                _inData = sp.ReadExisting();

                if (_inData.Contains("+CMGS:"))
                {
                    lblResultMessage.ForeColor = Color.Green;
                    lblResultMessage.Text = "ارسال شد";
                    _sendFlag = false;
                }
                else if (_inData.Contains("ERROR") && _sendFlag)
                {
                    lblResultMessage.ForeColor = Color.Red;
                    lblResultMessage.Text = "ارسال نشد";
                    _sendFlag = false;
                    if (_cts != null && !_cts.IsCancellationRequested)
                    {
                        _cts.Cancel();
                        btnCancelAll.Visible = false;
                    }

                }
                else if (_inData.Contains("+CMTI:")) //دریافت پیامک مرحله اول
                {

                    _inData = _inData.Replace("\r\n", "");
                    var c = _inData.Split(',');
                    SMSNum = c[1];

                    _serialPort1.WriteLine("AT+CMGF=1");
                    Thread.Sleep(150);
                    _serialPort1.WriteLine("AT+CSCS=\"UCS2\"");
                    Thread.Sleep(150);
                    _serialPort1.WriteLine("AT+CSMP=17,167,0,0");
                    Thread.Sleep(150);
                    //serialPort1.WriteLine("AT+CMGR=" + SMSNum + ",1");
                    _serialPort1.WriteLine("AT+CMGR=" + SMSNum);
                    Thread.Sleep(1000);
                }
                else if (_inData.Contains("+CMGR:"))// دریافت پیامک مرحله دوم
                {
                    var temp = _inData.Substring(_inData.IndexOf("+CMGR:"));
                    var rData = temp.Split(',');
                    var phone = rData[1].Replace("\"", "");
                    var sb = new StringBuilder();
                    for (var j = 0; j < phone.Length; j += 4)
                        sb.AppendFormat("\\u{0:x4}", phone.Substring(j, 4));
                    phone = System.Text.RegularExpressions.Regex.Unescape(sb.ToString());
                    phone = "0" + phone.Substring(3);

                    temp = rData[4].Substring(rData[4].IndexOf("\r\n") + 2);
                    temp = temp.Remove(temp.IndexOf("\r\n"));
                    sb.Remove(0, sb.Length);
                    for (var j = 0; j < temp.Length; j += 4)
                        sb.AppendFormat("\\u{0:x4}", temp.Substring(j, 4));
                    var msg = System.Text.RegularExpressions.Regex.Unescape(sb.ToString());

                    try
                    {
                        dgvRecivedSMS.Rows.Add();
                        dgvRecivedSMS[0, dgvRecivedSMS.Rows.Count - 1].Value = DateTime.Now;
                        dgvRecivedSMS[1, dgvRecivedSMS.Rows.Count - 1].Value = phone;
                        dgvRecivedSMS[2, dgvRecivedSMS.Rows.Count - 1].Value = msg;
                        dgvRecivedSMS.Sort(dgvRecivedSMS.Columns[0], System.ComponentModel.ListSortDirection.Descending);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    _serialPort1.WriteLine("AT+CMGD=" + SMSNum); // Delete SMS from SIM
                    Thread.Sleep(150);
                }
                else if (_inData.Contains("+CSQ:")) //درصد آنتن
                {
                    var p = Convert.ToInt32(Regex.Match(_inData, @"\d+").ToString());
                    p = (p * 827) + 127;
                    p = p >> 8;
                    p = (p > 100) ? 100 : p;
                    lblAntenStatus.Text = p.ToString() + "%";
                }
                else if (_inData.Contains("+CREG:"))//وضعیت شبکه
                {
                    string[] RData = _inData.Substring(_inData.IndexOf("+CREG:") + 6).Split(',');
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
                            lblNetworkStatus.Text = _inData.Substring(_inData.IndexOf("+CREG:") + 6);
                            break;
                    }
                    //labelNetworkStatus.Text = indata.Substring(indata.IndexOf("+CREG:")+6);

                }
                else if (_inData.Contains("ERROR") && _simStatusFlag)//وضعیت سیمکارت
                {
                    lblSimStatus.ForeColor = Color.Red;
                    lblSimStatus.Text = "سیمکارت وارد نشده است";
                    _simStatusFlag = false;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dataGridViewReceivedSMS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(dgvRecivedSMS.CurrentRow.Cells[2].Value.ToString(), "متن پیامک");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region timer1_Tick For Update Status
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Sim Status - وضعیت سیمکارت
            lblSimStatus.ForeColor = Color.Green;
            lblSimStatus.Text = "متصل";
            _simStatusFlag = true;
            _serialPort1.WriteLine("AT+CIMI");
            Thread.Sleep(150);


            //Anten Status - وضعیت آنتن
            _serialPort1.WriteLine("AT+CSQ");
            Thread.Sleep(150);

            //Network Status - وضعیت شبکه
            _serialPort1.WriteLine("AT+CREG?");
            Thread.Sleep(150);
        }
        #endregion

        private DataTable ReadExcelFile(string filePath)
        {
            var dt = new DataTable();

            dt.Columns.Add("MobileNumber", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Record", typeof(int));

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // شیت اول
                var rows = worksheet.RangeUsed().RowsUsed();

                var isFirstRow = true;
                var index = 1; // شماره ردیف دیتا تیبل از 1 شروع میشه


                foreach (var row in rows)
                {
                    if (isFirstRow)
                    {
                        isFirstRow = false; // هدر رد بشه
                        continue;
                    }

                    var mobile = row.Cell(1).GetValue<string>();
                    var fullname = row.Cell(2).GetValue<string>();

                    dt.Rows.Add(mobile, fullname, index);

                    index++; // برای ردیف بعدی
                }
            }
            return dt;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "فایل اکسل شماره ها را انتخاب کنید";
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
                    dgvCustomerList.Columns["Record"].DataPropertyName = "Record";

                    dgvCustomerList.DataSource = dt;
                }
            }
        }

        private async void btnSendAll_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList == null || dgvCustomerList.Rows.Count == 1)
            {
                MessageBox.Show("هیچ شماره‌ای برای ارسال وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // اگر یک عملیات قبلی هنوز در حال انجام است، آن را لغو یا نادیده بگیرید
            _cts?.Dispose();
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            timer1.Enabled = false;
            // آماده‌سازی مودم
            try
            {
                _serialPort1.WriteLine("AT+CMGF=1");
                await Task.Delay(100, token);
                _serialPort1.WriteLine("AT+CSCS=\"HEX\"");
                await Task.Delay(100, token);
                _serialPort1.WriteLine("AT+CSMP=17,167,0,8");
                await Task.Delay(100, token);
            }
            catch (OperationCanceledException)
            {
                // اگر کاربر بین آماده‌سازی لغو کرد
                MessageBox.Show("عملیات لغو شد.", "لغو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMultiSend.Visible = true;
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            _sendFlag = true;

            var total = dgvCustomerList.Rows.Count - 1;
            var sent = 0;
            btnCancelAll.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = total;
            lblProgress.Text = $"ارسال 0 از {total}";

            try
            {
                foreach (DataGridViewRow row in dgvCustomerList.Rows)
                {
                    if (row.IsNewRow) continue;

                    // بررسی لغو درخواست شده قبل از هر ارسال
                    token.ThrowIfCancellationRequested();

                    var phoneNumber = row.Cells["MobileNumber"].Value?.ToString() ?? string.Empty;
                    var fullName = row.Cells["FullName"].Value?.ToString() ?? string.Empty;

                    var message = txtMultiMessage.Text.ToLower().Replace("[name]", fullName);

                    // اگر SendSMSFunction نیاز به پشتیبانی لغو دارد، آن را تغییر دهید تا توکن را قبول کند.
                    SendSMSFunction(phoneNumber, message);

                    sent++;
                    progressBar1.Value = sent;
                    lblProgress.Text = $"ارسال {sent} از {total}";

                    // تأخیر قابل لغو
                    await Task.Delay(8000, token);
                }

                MessageBox.Show("ارسال گروهی تمام شد ✅", "پایان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMultiSend.Visible = true;
                btnCancelAll.Visible = false;
                timer1.Enabled = true;
            }
            catch (OperationCanceledException)
            {
                timer1.Enabled = true;
                MessageBox.Show("ارسال متوقف شد.", "لغو", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                _sendFlag = false;
                _cts?.Dispose();
                _cts = null;
                timer1.Enabled = true;
            }
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                timer1.Enabled = true;
                _cts.Cancel();
                progressBar1.Value = 0;
                btnCancelAll.Visible = false;
            }
        }
    }
}
