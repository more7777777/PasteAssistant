namespace 粘贴助手20170519
{
    partial class MessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_prev = new System.Windows.Forms.Label();
            this.label_now = new System.Windows.Forms.Label();
            this.label_next = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "上一条：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前填入：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(43, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "下一条：";
            // 
            // label_prev
            // 
            this.label_prev.AutoSize = true;
            this.label_prev.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_prev.Location = new System.Drawing.Point(124, 26);
            this.label_prev.Name = "label_prev";
            this.label_prev.Size = new System.Drawing.Size(75, 19);
            this.label_prev.TabIndex = 3;
            this.label_prev.Text = "label4";
            // 
            // label_now
            // 
            this.label_now.AutoSize = true;
            this.label_now.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_now.Location = new System.Drawing.Point(124, 57);
            this.label_now.Name = "label_now";
            this.label_now.Size = new System.Drawing.Size(75, 19);
            this.label_now.TabIndex = 4;
            this.label_now.Text = "label5";
            // 
            // label_next
            // 
            this.label_next.AutoSize = true;
            this.label_next.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_next.Location = new System.Drawing.Point(124, 88);
            this.label_next.Name = "label_next";
            this.label_next.Size = new System.Drawing.Size(75, 19);
            this.label_next.TabIndex = 5;
            this.label_next.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 126);
            this.Controls.Add(this.label_next);
            this.Controls.Add(this.label_now);
            this.Controls.Add(this.label_prev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.Text = "消息提示框";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageForm_FormClosed);
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_prev;
        private System.Windows.Forms.Label label_now;
        private System.Windows.Forms.Label label_next;
        private System.Windows.Forms.Timer timer1;
    }
}