using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 粘贴助手20170519
{
    public partial class ShowClipBoardForm : Form
    {
        private StringBuilder sb = new StringBuilder("");

        public ShowClipBoardForm()
        {
            InitializeComponent();
        }

        public StringBuilder Sb
        {
            get
            {
                return sb;
            }

            set
            {
                sb = value;
            }
        }

        private void ShowClipBoardForm_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = sb.ToString();
        }
    }
}
