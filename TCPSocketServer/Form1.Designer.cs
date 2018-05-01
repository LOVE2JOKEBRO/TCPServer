namespace TCPSocketServer
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
            this.serverControlsBox = new System.Windows.Forms.GroupBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP4 = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.rtConsole = new System.Windows.Forms.RichTextBox();
            this.serverControlsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverControlsBox
            // 
            this.serverControlsBox.Controls.Add(this.btnHost);
            this.serverControlsBox.Controls.Add(this.txtPort);
            this.serverControlsBox.Controls.Add(this.txtLocalIP4);
            this.serverControlsBox.Controls.Add(this.lblPort);
            this.serverControlsBox.Controls.Add(this.lblServerIP);
            this.serverControlsBox.Location = new System.Drawing.Point(12, 12);
            this.serverControlsBox.Name = "serverControlsBox";
            this.serverControlsBox.Size = new System.Drawing.Size(566, 128);
            this.serverControlsBox.TabIndex = 1;
            this.serverControlsBox.TabStop = false;
            this.serverControlsBox.Text = "Server Controls";
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(226, 68);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(75, 23);
            this.btnHost.TabIndex = 4;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(325, 25);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtLocalIP4
            // 
            this.txtLocalIP4.Location = new System.Drawing.Point(103, 25);
            this.txtLocalIP4.Name = "txtLocalIP4";
            this.txtLocalIP4.Size = new System.Drawing.Size(161, 20);
            this.txtLocalIP4.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(290, 28);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port:";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(37, 28);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(60, 13);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "Server IP4:";
            // 
            // rtConsole
            // 
            this.rtConsole.Location = new System.Drawing.Point(12, 146);
            this.rtConsole.Name = "rtConsole";
            this.rtConsole.Size = new System.Drawing.Size(566, 297);
            this.rtConsole.TabIndex = 2;
            this.rtConsole.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 506);
            this.Controls.Add(this.rtConsole);
            this.Controls.Add(this.serverControlsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.serverControlsBox.ResumeLayout(false);
            this.serverControlsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox serverControlsBox;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLocalIP4;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.RichTextBox rtConsole;
    }
}

