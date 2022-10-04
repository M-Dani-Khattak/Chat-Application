namespace TCP_CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IP_TxtBox = new System.Windows.Forms.TextBox();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.Info_TxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Send_Btn = new System.Windows.Forms.Button();
            this.Msg_TxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP_TxtBox
            // 
            this.IP_TxtBox.BackColor = System.Drawing.Color.White;
            this.IP_TxtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_TxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IP_TxtBox.Location = new System.Drawing.Point(78, 19);
            this.IP_TxtBox.Multiline = true;
            this.IP_TxtBox.Name = "IP_TxtBox";
            this.IP_TxtBox.Size = new System.Drawing.Size(383, 23);
            this.IP_TxtBox.TabIndex = 1;
            this.IP_TxtBox.Text = "Enter server IP";
            this.IP_TxtBox.TextChanged += new System.EventHandler(this.IP_TxtBox_TextChanged);
            this.IP_TxtBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IP_TxtBox_MouseDown);
            this.IP_TxtBox.MouseLeave += new System.EventHandler(this.IP_TxtBox_MouseLeave);
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(386, 304);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Btn.TabIndex = 2;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // Info_TxtBox
            // 
            this.Info_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Info_TxtBox.Location = new System.Drawing.Point(78, 48);
            this.Info_TxtBox.Multiline = true;
            this.Info_TxtBox.Name = "Info_TxtBox";
            this.Info_TxtBox.ReadOnly = true;
            this.Info_TxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Info_TxtBox.Size = new System.Drawing.Size(383, 217);
            this.Info_TxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(305, 304);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(75, 23);
            this.Send_Btn.TabIndex = 2;
            this.Send_Btn.Text = "Send";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // Msg_TxtBox
            // 
            this.Msg_TxtBox.Location = new System.Drawing.Point(78, 271);
            this.Msg_TxtBox.Multiline = true;
            this.Msg_TxtBox.Name = "Msg_TxtBox";
            this.Msg_TxtBox.Size = new System.Drawing.Size(383, 27);
            this.Msg_TxtBox.TabIndex = 5;
            this.Msg_TxtBox.TextChanged += new System.EventHandler(this.Msg_TxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(529, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Msg_TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Info_TxtBox);
            this.Controls.Add(this.Send_Btn);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.IP_TxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP CLIENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IP_TxtBox;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.TextBox Info_TxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.TextBox Msg_TxtBox;
        private System.Windows.Forms.Label label4;
    }
}

