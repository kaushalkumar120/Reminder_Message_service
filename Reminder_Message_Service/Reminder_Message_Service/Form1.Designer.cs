namespace ReminderMessageService
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reminder Message Service";

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.lblStatus.Location = new System.Drawing.Point(32, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 19);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Stopped";

            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(160, 110);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 40);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(35, 175);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(600, 199);
            this.lstLog.TabIndex = 4;

            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Message Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(
                this.Form1_FormClosing
            );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}