namespace 粘贴助手20170519
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_ClipBoard = new System.Windows.Forms.RadioButton();
            this.btn_ShowClipBoard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_customize = new System.Windows.Forms.RadioButton();
            this.radio_comma = new System.Windows.Forms.RadioButton();
            this.radio_tab = new System.Windows.Forms.RadioButton();
            this.radio_enter = new System.Windows.Forms.RadioButton();
            this.txt_split = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radio_file = new System.Windows.Forms.RadioButton();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.radio_file);
            this.groupBox1.Controls.Add(this.radio_ClipBoard);
            this.groupBox1.Controls.Add(this.btn_ShowClipBoard);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据来源";
            // 
            // radio_ClipBoard
            // 
            this.radio_ClipBoard.AutoSize = true;
            this.radio_ClipBoard.Checked = true;
            this.radio_ClipBoard.Location = new System.Drawing.Point(17, 24);
            this.radio_ClipBoard.Name = "radio_ClipBoard";
            this.radio_ClipBoard.Size = new System.Drawing.Size(59, 16);
            this.radio_ClipBoard.TabIndex = 1;
            this.radio_ClipBoard.TabStop = true;
            this.radio_ClipBoard.Text = "剪贴板";
            this.radio_ClipBoard.UseVisualStyleBackColor = true;
            this.radio_ClipBoard.CheckedChanged += new System.EventHandler(this.radio_ClipBoard_CheckedChanged);
            // 
            // btn_ShowClipBoard
            // 
            this.btn_ShowClipBoard.Location = new System.Drawing.Point(91, 20);
            this.btn_ShowClipBoard.Name = "btn_ShowClipBoard";
            this.btn_ShowClipBoard.Size = new System.Drawing.Size(121, 23);
            this.btn_ShowClipBoard.TabIndex = 0;
            this.btn_ShowClipBoard.Text = "查看剪贴板内容";
            this.btn_ShowClipBoard.UseVisualStyleBackColor = true;
            this.btn_ShowClipBoard.Click += new System.EventHandler(this.btn_ShowClipBoard_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_customize);
            this.groupBox2.Controls.Add(this.radio_comma);
            this.groupBox2.Controls.Add(this.radio_tab);
            this.groupBox2.Controls.Add(this.radio_enter);
            this.groupBox2.Controls.Add(this.txt_split);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分割符";
            // 
            // radio_customize
            // 
            this.radio_customize.AutoSize = true;
            this.radio_customize.Location = new System.Drawing.Point(267, 34);
            this.radio_customize.Name = "radio_customize";
            this.radio_customize.Size = new System.Drawing.Size(59, 16);
            this.radio_customize.TabIndex = 8;
            this.radio_customize.Text = "自定义";
            this.radio_customize.UseVisualStyleBackColor = true;
            // 
            // radio_comma
            // 
            this.radio_comma.AutoSize = true;
            this.radio_comma.Location = new System.Drawing.Point(184, 34);
            this.radio_comma.Name = "radio_comma";
            this.radio_comma.Size = new System.Drawing.Size(47, 16);
            this.radio_comma.TabIndex = 7;
            this.radio_comma.Text = "逗号";
            this.radio_comma.UseVisualStyleBackColor = true;
            // 
            // radio_tab
            // 
            this.radio_tab.AutoSize = true;
            this.radio_tab.Location = new System.Drawing.Point(107, 34);
            this.radio_tab.Name = "radio_tab";
            this.radio_tab.Size = new System.Drawing.Size(41, 16);
            this.radio_tab.TabIndex = 6;
            this.radio_tab.Text = "TAB";
            this.radio_tab.UseVisualStyleBackColor = true;
            // 
            // radio_enter
            // 
            this.radio_enter.AutoSize = true;
            this.radio_enter.Checked = true;
            this.radio_enter.Location = new System.Drawing.Point(24, 34);
            this.radio_enter.Name = "radio_enter";
            this.radio_enter.Size = new System.Drawing.Size(47, 16);
            this.radio_enter.TabIndex = 5;
            this.radio_enter.TabStop = true;
            this.radio_enter.Text = "换行";
            this.radio_enter.UseVisualStyleBackColor = true;
            // 
            // txt_split
            // 
            this.txt_split.Location = new System.Drawing.Point(334, 32);
            this.txt_split.Name = "txt_split";
            this.txt_split.Size = new System.Drawing.Size(184, 21);
            this.txt_split.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_start);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "快捷键";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(540, 25);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始启用";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前使用固定快捷键：F6";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 244);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "已拆分数据";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(636, 224);
            this.checkedListBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem1});
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.注册ToolStripMenuItem.Text = "系统";
            // 
            // 注册ToolStripMenuItem1
            // 
            this.注册ToolStripMenuItem1.Name = "注册ToolStripMenuItem1";
            this.注册ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.注册ToolStripMenuItem1.Text = "注册";
            this.注册ToolStripMenuItem1.Click += new System.EventHandler(this.注册ToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // radio_file
            // 
            this.radio_file.AutoSize = true;
            this.radio_file.Location = new System.Drawing.Point(17, 61);
            this.radio_file.Name = "radio_file";
            this.radio_file.Size = new System.Drawing.Size(47, 16);
            this.radio_file.TabIndex = 2;
            this.radio_file.TabStop = true;
            this.radio_file.Text = "文件";
            this.radio_file.UseVisualStyleBackColor = true;
            this.radio_file.CheckedChanged += new System.EventHandler(this.radio_file_CheckedChanged);
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(91, 59);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(368, 21);
            this.txtFile.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(465, 57);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "浏览…";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "粘贴助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ShowClipBoard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_split;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radio_ClipBoard;
        private System.Windows.Forms.RadioButton radio_customize;
        private System.Windows.Forms.RadioButton radio_comma;
        private System.Windows.Forms.RadioButton radio_tab;
        private System.Windows.Forms.RadioButton radio_enter;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton radio_file;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFile;
    }
}

