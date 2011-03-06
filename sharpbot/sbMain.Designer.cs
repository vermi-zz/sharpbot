namespace sharpbot
{
    partial class sbMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sbMain));
            this.infoConn = new System.Windows.Forms.GroupBox();
            this.SSLBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.infoBot = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usermodeI = new System.Windows.Forms.RadioButton();
            this.usermodeIW = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NickBox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.consoleOut = new System.Windows.Forms.TextBox();
            this.infoChan = new System.Windows.Forms.GroupBox();
            this.autoAcceptInvites = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cbxTrigger = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.infoConn.SuspendLayout();
            this.infoBot.SuspendLayout();
            this.infoChan.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoConn
            // 
            this.infoConn.Controls.Add(this.SSLBox);
            this.infoConn.Controls.Add(this.label2);
            this.infoConn.Controls.Add(this.label1);
            this.infoConn.Controls.Add(this.PortBox);
            this.infoConn.Controls.Add(this.HostBox);
            this.infoConn.Location = new System.Drawing.Point(12, 361);
            this.infoConn.Name = "infoConn";
            this.infoConn.Size = new System.Drawing.Size(280, 100);
            this.infoConn.TabIndex = 0;
            this.infoConn.TabStop = false;
            this.infoConn.Text = "Connection Info";
            // 
            // SSLBox
            // 
            this.SSLBox.AutoSize = true;
            this.SSLBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SSLBox.Checked = true;
            this.SSLBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSLBox.Location = new System.Drawing.Point(185, 64);
            this.SSLBox.Name = "SSLBox";
            this.SSLBox.Size = new System.Drawing.Size(68, 17);
            this.SSLBox.TabIndex = 4;
            this.SSLBox.Text = "Use &SSL";
            this.SSLBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(193, 38);
            this.PortBox.MaxLength = 5;
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(60, 20);
            this.PortBox.TabIndex = 3;
            this.PortBox.Text = "6667";
            // 
            // HostBox
            // 
            this.HostBox.Location = new System.Drawing.Point(28, 38);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(159, 20);
            this.HostBox.TabIndex = 0;
            this.HostBox.Text = "irc.rizon.net";
            // 
            // infoBot
            // 
            this.infoBot.Controls.Add(this.label7);
            this.infoBot.Controls.Add(this.usermodeI);
            this.infoBot.Controls.Add(this.usermodeIW);
            this.infoBot.Controls.Add(this.label6);
            this.infoBot.Controls.Add(this.userBox);
            this.infoBot.Controls.Add(this.label5);
            this.infoBot.Controls.Add(this.passBox);
            this.infoBot.Controls.Add(this.label4);
            this.infoBot.Controls.Add(this.rnBox);
            this.infoBot.Controls.Add(this.label3);
            this.infoBot.Controls.Add(this.NickBox);
            this.infoBot.Location = new System.Drawing.Point(298, 361);
            this.infoBot.Name = "infoBot";
            this.infoBot.Size = new System.Drawing.Size(416, 100);
            this.infoBot.TabIndex = 1;
            this.infoBot.TabStop = false;
            this.infoBot.Text = "Bot Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usermode:";
            // 
            // usermodeI
            // 
            this.usermodeI.AutoSize = true;
            this.usermodeI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usermodeI.Checked = true;
            this.usermodeI.Location = new System.Drawing.Point(325, 41);
            this.usermodeI.Name = "usermodeI";
            this.usermodeI.Size = new System.Drawing.Size(33, 17);
            this.usermodeI.TabIndex = 14;
            this.usermodeI.TabStop = true;
            this.usermodeI.Text = "+i";
            this.usermodeI.UseVisualStyleBackColor = true;
            this.usermodeI.CheckedChanged += new System.EventHandler(this.usermodeI_CheckedChanged);
            // 
            // usermodeIW
            // 
            this.usermodeIW.AutoSize = true;
            this.usermodeIW.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usermodeIW.Location = new System.Drawing.Point(364, 41);
            this.usermodeIW.Name = "usermodeIW";
            this.usermodeIW.Size = new System.Drawing.Size(41, 17);
            this.usermodeIW.TabIndex = 13;
            this.usermodeIW.Text = "+iw";
            this.usermodeIW.UseVisualStyleBackColor = true;
            this.usermodeIW.CheckedChanged += new System.EventHandler(this.usermodeIW_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username:";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(163, 38);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(71, 20);
            this.userBox.TabIndex = 11;
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NS Pass:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(240, 38);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(71, 20);
            this.passBox.TabIndex = 9;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Real Name:";
            // 
            // rnBox
            // 
            this.rnBox.Location = new System.Drawing.Point(9, 38);
            this.rnBox.Name = "rnBox";
            this.rnBox.Size = new System.Drawing.Size(71, 20);
            this.rnBox.TabIndex = 7;
            this.rnBox.TextChanged += new System.EventHandler(this.rnBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nick:";
            // 
            // NickBox
            // 
            this.NickBox.Location = new System.Drawing.Point(86, 38);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(71, 20);
            this.NickBox.TabIndex = 5;
            this.NickBox.TextChanged += new System.EventHandler(this.NickBox_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(546, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // consoleOut
            // 
            this.consoleOut.BackColor = System.Drawing.SystemColors.Control;
            this.consoleOut.Location = new System.Drawing.Point(12, 12);
            this.consoleOut.Multiline = true;
            this.consoleOut.Name = "consoleOut";
            this.consoleOut.ReadOnly = true;
            this.consoleOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOut.Size = new System.Drawing.Size(528, 343);
            this.consoleOut.TabIndex = 4;
            // 
            // infoChan
            // 
            this.infoChan.Controls.Add(this.autoAcceptInvites);
            this.infoChan.Controls.Add(this.label8);
            this.infoChan.Controls.Add(this.ChannelBox);
            this.infoChan.Location = new System.Drawing.Point(546, 70);
            this.infoChan.Name = "infoChan";
            this.infoChan.Size = new System.Drawing.Size(168, 187);
            this.infoChan.TabIndex = 16;
            this.infoChan.TabStop = false;
            this.infoChan.Text = "Channel Info";
            // 
            // autoAcceptInvites
            // 
            this.autoAcceptInvites.AutoSize = true;
            this.autoAcceptInvites.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoAcceptInvites.Location = new System.Drawing.Point(10, 161);
            this.autoAcceptInvites.Name = "autoAcceptInvites";
            this.autoAcceptInvites.Size = new System.Drawing.Size(118, 17);
            this.autoAcceptInvites.TabIndex = 17;
            this.autoAcceptInvites.Text = "Auto-accept Invites";
            this.autoAcceptInvites.UseVisualStyleBackColor = true;
            this.autoAcceptInvites.CheckedChanged += new System.EventHandler(this.autoAcceptInvites_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Autojoin Channels:";
            // 
            // ChannelBox
            // 
            this.ChannelBox.Location = new System.Drawing.Point(10, 42);
            this.ChannelBox.Multiline = true;
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(147, 113);
            this.ChannelBox.TabIndex = 0;
            this.ChannelBox.WordWrap = false;
            this.ChannelBox.TextChanged += new System.EventHandler(this.ChannelBox_TextChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(639, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cbxTrigger
            // 
            this.cbxTrigger.FormattingEnabled = true;
            this.cbxTrigger.Items.AddRange(new object[] {
            "!",
            ".",
            "@",
            "?",
            "^",
            "*",
            "&",
            "#",
            "$"});
            this.cbxTrigger.Location = new System.Drawing.Point(587, 289);
            this.cbxTrigger.Name = "cbxTrigger";
            this.cbxTrigger.Size = new System.Drawing.Size(52, 21);
            this.cbxTrigger.TabIndex = 18;
            this.cbxTrigger.SelectedIndexChanged += new System.EventHandler(this.cbxTrigger_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Trigger:";
            // 
            // sbMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 473);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxTrigger);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.infoChan);
            this.Controls.Add(this.consoleOut);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.infoBot);
            this.Controls.Add(this.infoConn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sbMain";
            this.Text = "SharpBot";
            this.infoConn.ResumeLayout(false);
            this.infoConn.PerformLayout();
            this.infoBot.ResumeLayout(false);
            this.infoBot.PerformLayout();
            this.infoChan.ResumeLayout(false);
            this.infoChan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox infoConn;
        private System.Windows.Forms.CheckBox SSLBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.GroupBox infoBot;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox consoleOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rnBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NickBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton usermodeI;
        private System.Windows.Forms.RadioButton usermodeIW;
        private System.Windows.Forms.GroupBox infoChan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ChannelBox;
        private System.Windows.Forms.CheckBox autoAcceptInvites;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbxTrigger;
        private System.Windows.Forms.Label label9;
    }
}

