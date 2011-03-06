using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Meebey.SmartIrc4net;

namespace sharpbot
{
    public partial class sbMain : Form
    {
        IrcClient client;
        Thread listenThread;
        string botnick;
        string botname;
        string nspass;
        string botuser;
        string trigger;
        int usermode = 0;
        string[] channels;

        delegate void messagesCallback(object sender, IrcEventArgs e);
        ParameterizedThreadStart listener;

        public sbMain()
        {
            InitializeComponent();
            client = new IrcClient();
            listener = new ParameterizedThreadStart(bgListen);
            listenThread = new Thread(listener);
            client.OnConnected += new EventHandler(this.Connected);
            client.OnRegistered += new EventHandler(client_OnRegistered);
            client.OnChannelMessage += new IrcEventHandler(client_OnChannelMessage);
            client.SupportNonRfc = true;
            client.CtcpVersion = "sharpclient";

            HostBox.Text = Properties.Settings.Default.hostname;
            PortBox.Text = Properties.Settings.Default.port;
            userBox.Text = Properties.Settings.Default.userName;
            rnBox.Text = Properties.Settings.Default.realName;
            NickBox.Text = Properties.Settings.Default.botNick;
            passBox.Text = Properties.Settings.Default.password;
            ChannelBox.Text = Properties.Settings.Default.autoChans;
            cbxTrigger.SelectedIndex = Properties.Settings.Default.trigger;
        }


        private void Connected(object sender, EventArgs e)
        {
            btnConnect.Text = "Reconnect";
            client.Login(botnick, botname, usermode, botuser, "");
            listenThread.IsBackground = true;
            listenThread.SetApartmentState(ApartmentState.MTA);
            listenThread.Start(client);
        }

        private void bgListen(object caller)
        {
            IrcClient bgClient = (IrcClient)caller;
            bgClient.Listen();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
                consoleOut.Text += String.Format("Connecting to {0} as {1}, password: {2}\r\n",
                        HostBox.Text, botnick, nspass);
                try
                {
                    client.Connect(HostBox.Text, Convert.ToInt32(PortBox.Text));
                }
                catch (CouldNotConnectException)
                {
                    consoleOut.AppendText("Could not connect. Check your connection and try again in a moment.");
                }
            }
            else
            {
                consoleOut.Text += "Reconnecting...\r\n";

                try { client.Reconnect(); }
                catch (CouldNotConnectException)
                {
                    consoleOut.AppendText("Could not connect. Check your connection and try again in a moment.");
                }
            }
        }

        void client_OnChannelMessage(object sender, IrcEventArgs e)
        {
            if (consoleOut.InvokeRequired)
            {
                messagesCallback d = new messagesCallback(client_OnChannelMessage);
                this.Invoke(d, new object[] { sender, e });
            } else {
            parseCommands(e.Data.MessageArray, e.Data.Nick, e.Data.Channel);
            }
        }

        private void parseCommands(string[] message, string nick, string channel)
        {
            if (message[0].StartsWith(trigger))
            {
                consoleOut.AppendText("!! TRIGGER DETECTED !!\r\n");
            }
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            nspass = passBox.Text;
        }

        private void NickBox_TextChanged(object sender, EventArgs e)
        {
            botnick = NickBox.Text;
        }

        private void rnBox_TextChanged(object sender, EventArgs e)
        {
            botname = rnBox.Text;
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            botuser = userBox.Text;
        }

        private void usermodeIW_CheckedChanged(object sender, EventArgs e)
        {
            usermode = 0;
        }

        private void usermodeI_CheckedChanged(object sender, EventArgs e)
        {
            usermode = 4;
        }

        private void ChannelBox_TextChanged(object sender, EventArgs e)
        {
            char[] separator = { '\r', '\n' };
            channels = ChannelBox.Text.Split(separator);
        }

        private void autoAcceptInvites_CheckedChanged(object sender, EventArgs e)
        {
            client.AutoJoinOnInvite = true;
        }

        private void client_OnRegistered(object sender, EventArgs e)
        {
            if (nspass != String.Empty)
            {
                client.RfcPrivmsg("NickServ", "IDENTIFY " + nspass);
            }
            client.RfcJoin(channels);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                client.RfcQuit("Shutdown requested.");
                client.Disconnect();
            }

            Properties.Settings.Default.autoChans = ChannelBox.Text;
            Properties.Settings.Default.botNick = NickBox.Text;
            Properties.Settings.Default.hostname = HostBox.Text;
            Properties.Settings.Default.password = passBox.Text;
            Properties.Settings.Default.port = PortBox.Text;
            Properties.Settings.Default.realName = rnBox.Text;
            Properties.Settings.Default.userName = userBox.Text;
            Properties.Settings.Default.trigger = cbxTrigger.SelectedIndex;
            Properties.Settings.Default.Save();

            Application.Exit();
        }

        private void cbxTrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            trigger = cbxTrigger.Text;
        }
    }
}
