namespace Timer
{
    partial class Form1
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
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimeStarted = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.txtTimeStarted = new System.Windows.Forms.TextBox();
            this.txtTimeElapsed = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(43, 162);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStartTimer.TabIndex = 0;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(242, 162);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTimeStarted
            // 
            this.lblTimeStarted.AutoSize = true;
            this.lblTimeStarted.Location = new System.Drawing.Point(40, 99);
            this.lblTimeStarted.Name = "lblTimeStarted";
            this.lblTimeStarted.Size = new System.Drawing.Size(67, 13);
            this.lblTimeStarted.TabIndex = 2;
            this.lblTimeStarted.Text = "Time Started";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(239, 99);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(71, 13);
            this.lblTimeElapsed.TabIndex = 3;
            this.lblTimeElapsed.Text = "Time Elapsed";
            this.lblTimeElapsed.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTimeStarted
            // 
            this.txtTimeStarted.Location = new System.Drawing.Point(43, 39);
            this.txtTimeStarted.Name = "txtTimeStarted";
            this.txtTimeStarted.Size = new System.Drawing.Size(28, 20);
            this.txtTimeStarted.TabIndex = 4;
            this.txtTimeStarted.Text = "12";
            // 
            // txtTimeElapsed
            // 
            this.txtTimeElapsed.Location = new System.Drawing.Point(242, 39);
            this.txtTimeElapsed.Name = "txtTimeElapsed";
            this.txtTimeElapsed.Size = new System.Drawing.Size(19, 20);
            this.txtTimeElapsed.TabIndex = 5;
            this.txtTimeElapsed.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeElapsed);
            this.Controls.Add(this.txtTimeStarted);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblTimeStarted);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTimeStarted;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.TextBox txtTimeStarted;
        private System.Windows.Forms.TextBox txtTimeElapsed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

