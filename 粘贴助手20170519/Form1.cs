using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SoftReg;

namespace 粘贴助手20170519
{
    public partial class Form1 : Form
    {
        #region  win32 api
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, uint lParam);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("user32.dll")]
        private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
            IntPtr hWnd,
            int id,
            KeyModifiers fsModifiers,
            Keys vk
            );

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,
            int id
            );

        [Flags]
        public enum KeyModifiers
        {
            None = 0, Alt = 1, Ctrl = 2, Shift = 4, WindowsKey = 8
        }

        private string[] tmpdata = null;

        private delegate void ListBoxChk(string _type, string _val,int _index = 0, bool _chk = false);
        private void setListBox(string _type, string _val, int _index = 0, bool _chk = false)
        {
            if(this.checkedListBox1.InvokeRequired)
            {
                ListBoxChk lbc = new ListBoxChk(setListBox);
                checkedListBox1.BeginInvoke(lbc, new object[] { _type, _val, _index, _chk });
            }else
            {
                switch(_type)
                {
                    case "clear":
                        checkedListBox1.Items.Clear();
                        break;

                    case "add":
                        checkedListBox1.Items.Add(_val);
                        checkedListBox1.SetItemChecked(_index, _chk);
                        break;

                    case "unchk":
                        checkedListBox1.SetItemChecked(_index, _chk);
                        break;
                }
            }
        }

        private delegate void SetListBoxChk(int _index, bool _chk);

        private void setListBoxCheck(int _index, bool _chk)
        {
            if(this.checkedListBox1.InvokeRequired)
            {
                SetListBoxChk slbc = new SetListBoxChk(setListBoxCheck);
                checkedListBox1.BeginInvoke(slbc, new object[] { _index, _chk });
            }else
            {
                checkedListBox1.SetItemChecked(_index, _chk);
            }
        }
        

        public static void RegKey(IntPtr hwnd, int hotkey_id, KeyModifiers keyModifiers, Keys key)
        {
            try
            {
                if (!RegisterHotKey(hwnd, hotkey_id, keyModifiers, key))
                {
                    if (Marshal.GetLastWin32Error() == 1409)
                    {
                        MessageBox.Show("热键被占用！");
                    }
                    else
                    {
                        MessageBox.Show("注册热键失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private const int WM_HOTKEY = 0x312;
        private const int WM_CREATE = 0x1;
        private const int WM_DESTORY = 0x2;
        private const int Space = 0x3572;
        private const int WM_SETTEXT = 0x000C;

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        public static void UnRegKey(IntPtr hwnd, int hotKey_id)
        {
            UnregisterHotKey(hwnd, hotKey_id);
        }
        #endregion

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case Space:
                            //Console.WriteLine("按了热键");
                            SendText();
                            break;

                        default:
                            break;
                    }
                    break;

                case WM_CREATE:
                    RegKey(Handle, Space, KeyModifiers.None, Keys.F6);
                    break;

                case WM_DESTORY:
                    UnRegKey(Handle, Space);
                    break;

                default:
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private bool chkClipBoard(IDataObject _data)
        {
            if (_data.GetFormats().Length == 0)
            {
                MessageBox.Show("系统剪贴板为空!");
                return false;
            }

            //判断内容类型
            if (!_data.GetDataPresent(DataFormats.Text))
            {
                MessageBox.Show("系统剪贴板内容非文本，无法分割操作！");
                return false;
            }

            return true;
        }

        
        private void btn_ShowClipBoard_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();
            if (!chkClipBoard(data))
                return;

            StringBuilder sb = new StringBuilder(data.GetData(DataFormats.Text).ToString());
            ShowClipBoardForm scbf = new ShowClipBoardForm();
            scbf.Sb = sb;
            scbf.ShowDialog();
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            string splittype = "";
            if (radio_enter.Checked == true)
                splittype = "\r\n";
            if (radio_tab.Checked == true)
                splittype = "\t";
            if (radio_comma.Checked == true)
                splittype = ",";
            if (radio_customize.Checked == true)
                splittype = txt_split.Text.Trim();
            
            if(radio_ClipBoard.Checked == true)
            {
                IDataObject data = Clipboard.GetDataObject();
                if (!chkClipBoard(data))
                    return;

                //拆分数据
                string[] separators = new string[] { splittype };
                string[] tmpd = data.GetData(DataFormats.Text).ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                this.tmpdata = tmpd;

                int num = tmpd.Length;
                this.toolStripStatusLabel1.Text = "共：" + num.ToString() + " 组数据！";

                Thread td = new Thread(new ThreadStart(splitdata));
                td.Start();
                //this.checkedListBox1.Items.Clear();

                //foreach ( string val in tmpdata )
                //{
                //    this.checkedListBox1.Items.Add(val);
                //}

                //for (int i = 0; i < checkedListBox1.Items.Count; i++)
                //    checkedListBox1.SetItemChecked(i, true);
            }
        }


        private void splitdata()
        {
            setListBox("clear", "");

            int i = 0;
            foreach( string val in tmpdata)
            {
                setListBox("add", val, i , true);
                i++;
            }

            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //    setListBoxCheck(i, true);
        }


        private void PopUpMessageBox(string _prev , string _now,  string _next, IntPtr _hwnd)
        {
            MessageForm mf = new MessageForm();
            mf.Prev = _prev;
            mf.Now = _now;
            mf.Next = _next;
            mf.Hwnd = _hwnd;

            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - mf.Width, Screen.PrimaryScreen.WorkingArea.Height);
            mf.PointToClient(p);
            mf.Location = p;
            mf.Show();
            for(int i = 0; i < mf.Height; i++ )
            {
                mf.Location = new Point(p.X, p.Y - i);
                Thread.Sleep(10);
            }
        }



        private void SendText()
        {
            if(tmpdata == null)
            {
                MessageBox.Show("请点击开始启用");
                return;
            }

            int chknum = this.checkedListBox1.CheckedItems.Count;
            int num = this.tmpdata.Length;
            string txt = string.Empty;

            if (chknum == 0)
            {
                MessageBox.Show("输出已结束！共输出：" + num.ToString() + "项数据");
                return;
            }

            IntPtr hwnd = IntPtr.Zero;
            for(int i = 0; i < num; i++ )
            {
                if(checkedListBox1.GetItemChecked(i))
                {
                    txt = tmpdata[i].ToString();
                    hwnd = GetForegroundWindow();
                    if (string.IsNullOrEmpty(txt))
                        return;

                    if (hwnd != IntPtr.Zero)
                    {
                        Clipboard.Clear();
                        Clipboard.SetDataObject(txt);
                        Clipboard.SetDataObject(txt);

                        keybd_event(17, 0, 0, 0);
                        keybd_event(86, 0, 0, 0);

                        Thread.Sleep(10);

                        keybd_event(86, 0, 2, 0);
                        keybd_event(17, 0, 2,  0);
                        //SendMessage(hwnd, WM_KEYDOWN, VK_V, 0);

                        //Thread.Sleep(10);
                        //SendMessage(hwnd, WM_KEYUP, VK_V, 0);
                        //keybd_event(17, 0, 2, 0);

                        //Console.WriteLine("粘贴：" + txt);

                    }
                        //SendKeys.Send(txt);

                    setListBox("unchk", "", i, false);
                    break;
                }
            }


            //int chknum = this.checkedListBox1.CheckedItems.Count;
            //if( chknum == 0 )
            //{
            //    MessageBox.Show("输出已结束！");
            //    return;
            //}

            //int num = this.checkedListBox1.Items.Count;

            //string prev = string.Empty;
            //string next = string.Empty;
            //string txt = string.Empty;

            //IntPtr hwnd = IntPtr.Zero;

            //for( int i = 0; i < num; i++ )
            //{
            //    if(checkedListBox1.GetItemChecked(i))
            //    {
            //        if( i == 0 )
            //            //属于第一条
            //            prev = string.Empty;
            //        else
            //            prev = checkedListBox1.GetItemText(checkedListBox1.Items[i - 1]);

            //        if( i == num - 1 )
            //            //属于最后一条
            //            next = string.Empty;
            //        else
            //            next = checkedListBox1.GetItemText(checkedListBox1.Items[i + 1]);

            //        //Console.WriteLine(checkedListBox1.GetItemText(checkedListBox1.Items[i]));
            //        txt = checkedListBox1.GetItemText(checkedListBox1.Items[i]);
            //        hwnd = GetForegroundWindow();
            //        if (string.IsNullOrEmpty(txt))
            //            return;

            //        if (hwnd != IntPtr.Zero)
            //        {
            //            SendKeys.SendWait(txt);
            //            showHwndClass(hwnd);
            //        }

            //        checkedListBox1.SetItemChecked(i, false);
            //        break;
            //    }
            //}
        }


        private void showHwndClass(IntPtr _hwnd)
        {
            StringBuilder sb = new StringBuilder(256);
            GetClassNameW(_hwnd, sb, sb.Capacity);

            Console.WriteLine(sb.ToString());
        }

        SoftReg.SoftReg softReg = new SoftReg.SoftReg();

        private void Form1_Load(object sender, EventArgs e)
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            try
            {
                bool isreg = checkReg();
                if (isreg)
                {
                    bool iskeyvalue = checkRegValue();

                    //判断软件是否注册
                    //RegistryKey retkey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey("InputAssistant");
                    string value = string.Empty;

                    //如果有键值
                    if (iskeyvalue)
                    {
                        RegistryKey retkey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true).OpenSubKey("HelpPaste");
                        value = retkey.GetValue("KeyValue").ToString();

                        if (value == softReg.GetRNum())
                        {
                            this.Text = "粘贴小助手 V" + version + " －已注册";
                        }
                        else
                        {
                            tryTimes();
                            this.Text = "粘贴小助手 V" + version + " －未注册";
                        }
                    }
                    else
                    {
                        //有键名无键值
                        tryTimes();
                        this.Text = "粘贴小助手 V" + version + " －未注册";
                    }
                }
                else
                {
                    tryTimes();
                    this.Text = "粘贴小助手 V" + version + " －未注册";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public bool checkReg()
        {
            bool result = false;

            string[] subkeyName;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE");
            subkeyName = software.GetSubKeyNames();
            foreach (string keyname in subkeyName)
            {
                if (keyname == "HelpPaste")
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool checkRegValue()
        {
            bool result = false;
            string[] keyvalues;

            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE\\HelpPaste");
            keyvalues = software.GetValueNames();

            foreach (string keyname in keyvalues)
            {
                if (keyname == "KeyValue")
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void tryTimes()
        {
            Int32 tLong;
            try
            {
                tLong = (Int32)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\HelpPaste", "UseTimes", 0);
                MessageBox.Show("你使用的是试用版，可以免费使用30次，已经使用了" + tLong + "次，", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\HelpPaste", "UseTimes", 0, RegistryValueKind.DWord);
            }

            tLong = (Int32)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\HelpPaste", "UseTimes", 0);
            if (tLong < 30)
            {
                int tTimes = tLong + 1;
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\HelpPaste", "UseTimes", tTimes);
            }
            else
            {
                this.Text = "粘贴小助手 V1.0 －过期";
                this.btn_start.Enabled = false;
            }
        }

        private void 注册ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegForm.frmRegisterForm regform = new RegForm.frmRegisterForm();
            regform.ShowDialog();
        }

        private void radio_file_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_file.Checked == true)
            {
                this.txtFile.Enabled = true;
                this.btnOpenFile.Enabled = true;

                this.btn_ShowClipBoard.Enabled = false;
            }
        }

        private void radio_ClipBoard_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_ClipBoard.Checked == true)
            {
                this.btn_ShowClipBoard.Enabled = true;

                this.txtFile.Enabled = false;
                this.btnOpenFile.Enabled = false;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "请选择文件";
            ofd.Filter = "文本(*.txt)|*.txt|Word(*.doc)|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
            }
        }
    }
}
