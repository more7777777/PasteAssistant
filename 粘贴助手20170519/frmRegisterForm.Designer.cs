namespace RegForm
{
    partial class frmRegisterForm
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
            this.txtRNum = new System.Windows.Forms.TextBox();
            this.txtMNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRNum
            // 
            this.txtRNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRNum.Location = new System.Drawing.Point(3, 17);
            this.txtRNum.Multiline = true;
            this.txtRNum.Name = "txtRNum";
            this.txtRNum.Size = new System.Drawing.Size(455, 68);
            this.txtRNum.TabIndex = 0;
            // 
            // txtMNum
            // 
            this.txtMNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMNum.Location = new System.Drawing.Point(3, 17);
            this.txtMNum.Multiline = true;
            this.txtMNum.Name = "txtMNum";
            this.txtMNum.ReadOnly = true;
            this.txtMNum.Size = new System.Drawing.Size(455, 50);
            this.txtMNum.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMNum);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本机机器码";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 39);
            this.panel1.TabIndex = 3;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(367, 9);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRNum);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "注册码";
            // 
            // frmRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 197);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "软件注册";
            this.Load += new System.EventHandler(this.frmRegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRNum;
        private System.Windows.Forms.TextBox txtMNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}