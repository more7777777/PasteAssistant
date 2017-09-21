using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace 粘贴助手20170519
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll ")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private string prev = string.Empty;
        private string now = string.Empty;
        private string next = string.Empty;

        IntPtr hwnd = IntPtr.Zero;

        public string Prev
        {
            get
            {
                return prev;
            }

            set
            {
                prev = value;
            }
        }

        public string Now
        {
            get
            {
                return now;
            }

            set
            {
                now = value;
            }
        }

        public string Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public IntPtr Hwnd
        {
            get
            {
                return hwnd;
            }

            set
            {
                hwnd = value;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //for(int i = 0; i < this.Height; i++ )
            //{
            //    Point p = new Point(this.Location.X, this.Location.Y + i);
            //    this.PointToScreen(p);
            //    this.Location = p;

            //    Thread.Sleep(30);
            //}
            Thread.Sleep(2000);
            this.Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.label_prev.Text = this.prev;
            this.label_now.Text = this.now;
            this.label_next.Text = this.next;
        }

        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetForegroundWindow(hwnd);
        }
    }
}
