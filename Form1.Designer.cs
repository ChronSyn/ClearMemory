namespace UpdateOrchestratorStop
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_disclaimer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_MonitorWake = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmr_monitorWakeup = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ClearMemory";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 268);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/ChronSyn/ClearMemory";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_disclaimer
            // 
            this.btn_disclaimer.Location = new System.Drawing.Point(15, 146);
            this.btn_disclaimer.Name = "btn_disclaimer";
            this.btn_disclaimer.Size = new System.Drawing.Size(271, 108);
            this.btn_disclaimer.TabIndex = 9;
            this.btn_disclaimer.Text = "Disclaimer\r\n\r\n(You agree to this if using, downloading, installing, compiling, de" +
    "compiling, reverse engineering, modifying, editing, copying or transferring this" +
    " software)";
            this.btn_disclaimer.UseVisualStyleBackColor = true;
            this.btn_disclaimer.Click += new System.EventHandler(this.btn_disclaimer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "If this checkbox is checked, we\'ll try to clear working sets,\r\nmodified page list" +
    ", priority 0 standby list and standby list\r\nevery 4 hours\r\n";
            // 
            // cb_MonitorWake
            // 
            this.cb_MonitorWake.AutoSize = true;
            this.cb_MonitorWake.Checked = true;
            this.cb_MonitorWake.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MonitorWake.Location = new System.Drawing.Point(15, 18);
            this.cb_MonitorWake.Name = "cb_MonitorWake";
            this.cb_MonitorWake.Size = new System.Drawing.Size(106, 17);
            this.cb_MonitorWake.TabIndex = 15;
            this.cb_MonitorWake.Text = "Clear Periodically";
            this.cb_MonitorWake.UseVisualStyleBackColor = true;
            this.cb_MonitorWake.CheckedChanged += new System.EventHandler(this.cb_MonitorWake_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // tmr_monitorWakeup
            // 
            this.tmr_monitorWakeup.Enabled = true;
            this.tmr_monitorWakeup.Interval = 14400000;
            this.tmr_monitorWakeup.Tick += new System.EventHandler(this.tmr_monitorWakeup_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_MonitorWake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_disclaimer);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ClearMemory";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_disclaimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_MonitorWake;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmr_monitorWakeup;
    }
}

