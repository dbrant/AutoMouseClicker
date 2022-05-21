
namespace AutoMouseClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRightButton = new System.Windows.Forms.RadioButton();
            this.rbLeftButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkPauseOnMotion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(190, 139);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(124, 33);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "&Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRightButton);
            this.groupBox1.Controls.Add(this.rbLeftButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse button";
            // 
            // rbRightButton
            // 
            this.rbRightButton.AutoSize = true;
            this.rbRightButton.Location = new System.Drawing.Point(79, 22);
            this.rbRightButton.Name = "rbRightButton";
            this.rbRightButton.Size = new System.Drawing.Size(53, 19);
            this.rbRightButton.TabIndex = 1;
            this.rbRightButton.Text = "Right";
            this.rbRightButton.UseVisualStyleBackColor = true;
            // 
            // rbLeftButton
            // 
            this.rbLeftButton.AutoSize = true;
            this.rbLeftButton.Checked = true;
            this.rbLeftButton.Location = new System.Drawing.Point(15, 22);
            this.rbLeftButton.Name = "rbLeftButton";
            this.rbLeftButton.Size = new System.Drawing.Size(45, 19);
            this.rbLeftButton.TabIndex = 0;
            this.rbLeftButton.TabStop = true;
            this.rbLeftButton.Text = "Left";
            this.rbLeftButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "2000";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(12, 73);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(76, 15);
            this.lblInterval.TabIndex = 3;
            this.lblInterval.Text = "Interval (ms):";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // chkPauseOnMotion
            // 
            this.chkPauseOnMotion.AutoSize = true;
            this.chkPauseOnMotion.Checked = true;
            this.chkPauseOnMotion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPauseOnMotion.Location = new System.Drawing.Point(12, 99);
            this.chkPauseOnMotion.Name = "chkPauseOnMotion";
            this.chkPauseOnMotion.Size = new System.Drawing.Size(116, 19);
            this.chkPauseOnMotion.TabIndex = 5;
            this.chkPauseOnMotion.Text = "Pause on motion";
            this.chkPauseOnMotion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 206);
            this.Controls.Add(this.chkPauseOnMotion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRightButton;
        private System.Windows.Forms.RadioButton rbLeftButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox chkPauseOnMotion;
    }
}

