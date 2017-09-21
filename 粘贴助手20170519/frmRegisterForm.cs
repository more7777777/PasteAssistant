using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SoftReg;

namespace RegForm
{
    public partial class frmRegisterForm : Form
    {
        public frmRegisterForm()
        {
            InitializeComponent();
        }

        public static bool state = true;  //软件是否为可用状态
        SoftReg.SoftReg softReg = new SoftReg.SoftReg();
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void frmRegisterForm_Load(object sender, EventArgs e)
        {
            this.txtMNum.Text = softReg.GetMNum();
            //this.txtRNum.Text = softReg.GetRNum();
        }
        

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRNum.Text == softReg.GetRNum())
                {
                    MessageBox.Show("注册成功！重启软件后生效！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegistryKey retkey = Registry.LocalMachine.OpenSubKey("Software", true).CreateSubKey("HelpPaste");
                    retkey.SetValue("KeyValue", txtRNum.Text);
                    retkey.DeleteValue("UseTimes");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("注册码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRNum.SelectAll();
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}