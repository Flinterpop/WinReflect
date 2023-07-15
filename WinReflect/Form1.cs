﻿using System;
using System.Configuration;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

using System.Net.NetworkInformation;


namespace WinReflect
{
    public partial class Form1 : Form
    {
        bool Listening = false;
        bool Reflecting = false;
        bool LongTermDebug = false;
        bool quietMode = false;

        byte[] packet_buffer;
        Boolean exception_thrown = false;
        int PacketsSent = 0;
        int PacketsRead = 0;

        Socket sending_socket;
        System.Net.IPAddress SendIPAddress;
        System.Net.IPEndPoint SendEndPoint;
        int FromPort;

        //public static string dirParameter;

        bool[] usefulNIC = new bool[40];
        int numUsefulNICS = 0;

        public Form1()
        {
            InitializeComponent();
            tb_host.Text = Dns.GetHostName();
            if (cb_AnyPort.Checked) cb_ListenIPs.Enabled = false;
            GetAdapterInfo();
            DisplayAdapterInfo();
            readConfigFile();
        }


        void bn_GetAdapterInfo_Click(object sender, EventArgs e)
        {
            cb_SrcIPs.Items.Clear();
            cb_SrcIPs.ResetText();
            cb_ListenIPs.Items.Clear(); ;
            cb_ListenIPs.ResetText();

            GetAdapterInfo();
            DisplayAdapterInfo();
            tabControl1.SelectedIndex = 1;//show adapter info tab
        }

        void GetAdapterInfo()//doesn't really do that. just gets list of IPv4 Source IPs for this machine and fills the SrcIp & Listen combo boxes with that.
        {
            //IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            int numNIC = 0;
            foreach (NetworkInterface adapter in nics)
            {
                usefulNIC[numNIC++] = false;
                // Only retrive information for interfaces that support IPv4.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4) == false) continue;

                //if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                string ss = adapter.Description;
                //if (ss.Contains("Bluetooth")) continue; //do not add bluetooth adapters
                if (adapter.Description.Contains("Bluetooth")) continue; //do not add bluetooth adapters
                                
                //new checkbox (Nov 2020) added to provide option to discard wireless interfaces
                if ((!cB_IncludeWireless.Checked) && (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                    continue;

                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet  || adapter.NetworkInterfaceType == NetworkInterfaceType.GigabitEthernet )
                {
                    foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            numUsefulNICS++;
                            usefulNIC[numNIC - 1] = true;
                            cb_SrcIPs.Items.Add(ip.Address);
                            cb_ListenIPs.Items.Add(ip.Address);
                            debug("adding NIC" + ip.Address.ToString());
                        }
                    }
                }
            }
            cb_SrcIPs.SelectedIndex = 0;
            cb_ListenIPs.SelectedIndex = 0;
        }


        void DisplayAdapterInfo()
        {
            rtb_AdapterInfo.Clear(); //clear the Adapter info test box if displaying this time through

            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            adapterBox(string.Format("IPv4 interface information for {0}.{1}\r\n", properties.HostName, properties.DomainName));

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            adapterBox(string.Format("  Found {0} Interfaces", nics.Count() ));
            int InterfaceCount = 1;
            foreach (NetworkInterface adapter in nics)
            {
                // Only display information for interfaces that support IPv4.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4) == false)  continue;

                adapterBox("  ===================================================================");
                adapterBox(string.Format("  Adapter {0} of {1}", InterfaceCount++, nics.Count()));

                adapterBox("  Adapter Desc:");
                adapterBox(string.Format("        {0}", adapter.Description));

                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    adapterBox(string.Format("  Adapter Name................... : {0}", adapter.Name));
                    adapterBox("  IPv4 Address(es)...............");
                    foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            adapterBox(string.Format("        IPv4 Addresses........... : {0}", ip.Address));
                        }
                    }
                }

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                adapterBox(string.Format("  Interface type................. : {0}", adapter.NetworkInterfaceType));
                adapterBox(string.Format("  Physical Address............... : {0}", adapter.GetPhysicalAddress().ToString()));
                adapterBox(string.Format("  Is receive only................ : {0}", adapter.IsReceiveOnly));
                adapterBox(string.Format("  Multicast...................... : {0}", adapter.SupportsMulticast));
                adapterBox(string.Format("  DNS suffix..................... : {0}", adapterProperties.DnsSuffix));
                adapterBox(string.Format("  DNS enabled.................... : {0}", adapterProperties.IsDnsEnabled));
                adapterBox(string.Format("  Dynamically configured DNS..... : {0}", adapterProperties.IsDynamicDnsEnabled));

                //adapterBox(string.Format("  GatewayAddresses............... : {0}", adapterProperties.GatewayAddresses));

                // Try to get the IPv4 interface properties.
                IPv4InterfaceProperties p = adapterProperties.GetIPv4Properties();
                if (p == null)
                {
                    adapterBox("No IPv4 information is available for this interface.");
                    continue;
                }
                // Display the IPv4 specific data.
                adapterBox(string.Format("        Index ................... : {0}", p.Index));
                adapterBox(string.Format("        MTU ..................... : {0}", p.Mtu));
                adapterBox(string.Format("        APIPA active............. : {0}", p.IsAutomaticPrivateAddressingActive));
                adapterBox(string.Format("        APIPA enabled............ : {0}", p.IsAutomaticPrivateAddressingEnabled));
                adapterBox(string.Format("        Forwarding enabled....... : {0}", p.IsForwardingEnabled));
                adapterBox(string.Format("        Uses WINS ............... : {0}", p.UsesWins));
            }
            rtb_AdapterInfo.SelectionStart = 0;
            rtb_AdapterInfo.SelectionLength = 0;
        }
        


        void debug(string buf)
        {
            if (cb_Debug.Checked == false) return;

            rtb_Debug.AppendText(buf + "\r\n");
            rtb_Debug.SelectionStart = rtb_Debug.Text.Length;
            rtb_Debug.ScrollToCaret();
        }

        void debugClear()
        {
            rtb_Debug.Clear();
            rtb_Debug.Update();
            debug("CLEARED");
        }

        void adapterBox(string buf)
        {
            rtb_AdapterInfo.AppendText(buf + "\r\n");
            rtb_AdapterInfo.SelectionStart = rtb_AdapterInfo.Text.Length;
            rtb_AdapterInfo.ScrollToCaret();
        }



        void bn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool isMulticast(IPAddress ipa)
        {
            byte[] checkMC = ipa.GetAddressBytes();
            return ((checkMC[0] >= 224) && (checkMC[0] <= 239))?  true:  false;
        }


        void bn_listen_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;//show debug info tab
            if (Listening==true)
            {
                //changing to STOPPED Listen mode, so re-enable listen widgets
                Listening = false;
                bn_listen.Text = "Start Listening";
                debug("Stopping listener...");
                tb_ListenIP.Enabled = true;
                tb_ListenPort.Enabled = true;
                cb_AnyPort.Enabled = true;
                if (!cb_AnyPort.Checked) cb_ListenIPs.Enabled = true;
                return;
            }

            //changing to LISTENING Listen mode, so disable listen widgets
            Listening = true;
            tb_ListenIP.Enabled = false;
            tb_ListenPort.Enabled = false;
            cb_AnyPort.Enabled = false;
            cb_ListenIPs.Enabled = false;

            bn_listen.Text = "Stop Listening";
            debug("Starting listener...");
            String szIPSelected = tb_ListenIP.Text;

            String szPort = tb_ListenPort.Text;
            int listenPort = System.Convert.ToInt32(szPort, 10);

            IPAddress ListenIPAddress = System.Net.IPAddress.Parse(szIPSelected);
            bool ListenIsMultiCast = isMulticast(ListenIPAddress);

            if (ListenIsMultiCast)
            {
                lb_MulticastInd.Text = "True";
                debug("Listening to Multicast Address");
            }
            else
                lb_MulticastInd.Text = "False";

            IPAddress localSourceIPAddress = (IPAddress)cb_ListenIPs.SelectedItem;

            IPEndPoint ListenEP;
            if (cb_AnyPort.Checked) ListenEP = new IPEndPoint(IPAddress.Any, listenPort);
            else ListenEP = new IPEndPoint(localSourceIPAddress, listenPort);

            Task.Run(async () =>
            {
                using (var udpClient = new UdpClient(ListenEP))
                {
                    if (ListenIsMultiCast == true) //if its a multicast listen IP then have to join the multicast group
                      udpClient.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ListenIPAddress, IPAddress.Any));

                    //THIS IS THE MAIN LOOP
                    while (Listening == true)
                    {
                        //IPEndPoint object will allow us to read datagrams sent from any source.
                        var receivedResults = await udpClient.ReceiveAsync();
                        packet_buffer = receivedResults.Buffer;

                        if (LongTermDebug == true)
                        {
                            //byte DSCP = (UDP packet_buffer.
                            debug(string.Format("Rx Packet. Size {0}", receivedResults.Buffer.Length));
                        }

                        ++PacketsRead;

                        //****************************PERFORMANCE ISSUE**************************
                        if (quietMode==false) tb_PacketsRead.Text = PacketsRead.ToString();//THIS COULD BE SLOW - Updates to UI should be in separate thread

                        if (Reflecting == true) sendNextPacket();

                    }//end while (true)

                    bn_listen.Text = "Start Listening";

                }//end using
            });//end Task.Run...
        }


        public void sendNextPacket()
        {
            if (LongTermDebug == true) debug("In Send Next packet");
            try
            {
                sending_socket.SendTo(packet_buffer, SendEndPoint);
            }
            catch (Exception send_exception)
            {
                exception_thrown = true;
                debug(" Exception: " + send_exception.Message.ToString());
            }

            if (exception_thrown == false)
            {
                ++PacketsSent;

                //****************************PERFORMANCE ISSUE**************************
                if (quietMode == false) tb_PacketsSent.Text = PacketsSent.ToString();//THIS COULD BE SLOW - Updates to UI should be in separate thread

                if (PacketsSent % 100==0) rtb_Debug.Clear();//Clear the debug text box once in awhile to prevent memory problems
            }
        }



        void bn_ReflectMC_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;//show debug info tab

            if (Reflecting == false)
            {
                sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                String szIPSelected = tb_SendIP.Text;
                SendIPAddress = System.Net.IPAddress.Parse(szIPSelected);
                bool sendToIsMulticast = isMulticast(SendIPAddress);
                String szTTL = tb_MC_TTL.Text;

                int ttl = System.Convert.ToInt16(szTTL, 10);

                String szPort = tb_SendPort.Text;
                int sendPort = System.Convert.ToInt16(szPort, 10);
                SendEndPoint = new System.Net.IPEndPoint(SendIPAddress, sendPort);

                String szSrcPort = tb_ReflectSrcPort.Text;
                FromPort = System.Convert.ToInt16(szSrcPort, 10);

                IPAddress localIPAddress;
                try
                {
                    localIPAddress = (IPAddress)cb_SrcIPs.SelectedItem; //NEW
                    var localEndpoint = new IPEndPoint(localIPAddress, FromPort);
                    sending_socket.Bind(localEndpoint);

                    //int default_ttl = (int)sending_socket.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive);
                    //debug("default TTL is " + default_ttl.ToString());

                    if (sendToIsMulticast)
                    {
                        debug("Sending to a Multicast Address");
                        debug("Setting Multicast packet send TTL to :" + ttl.ToString());
                        sending_socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, ttl);
                    }
                    else
                    {
                        debug("Sending to a non-Multicast Address");
                        debug("Setting packet send TTL to :" + ttl.ToString());
                        sending_socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.IpTimeToLive, ttl);
                    }

                    debug("Valid Src IP");
                    bn_ReflectMC.Text = "Stop Reflecting";
                    debug("Reflecting starting...");
                    Reflecting = true;
                }
                catch //(Exception Ex)
                {
                    Reflecting = false;
                    bn_ReflectMC.Text = "Start Reflecting";
                    debug("Reflecting Failed..."+ e.ToString());
                    return;
                }
                //CHANGING to START REFLECTING Mode so dis-enable widets
                tb_SendIP.Enabled = false;
                tb_SendPort.Enabled = false;
                cb_SrcIPs.Enabled = false;
                tb_ReflectSrcPort.Enabled = false;
                tb_MC_TTL.Enabled = false;

            }
            else //reflecting was true
            {
                //CHANGING to STOP REFLECTING Mode so re-enable widets
                tb_SendIP.Enabled = true;
                tb_SendPort.Enabled = true;
                cb_SrcIPs.Enabled = true;
                tb_ReflectSrcPort.Enabled = true;
                tb_MC_TTL.Enabled = true;

                sending_socket.Dispose();
                
                Reflecting = false;
                bn_ReflectMC.Text = "Start Reflecting";
                debug("Reflecting Stopping...");
            }
        }

        private void cb_LongRunDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_LongRunDebug.Checked==false)
                LongTermDebug = false;
            else LongTermDebug = true;

        }


        //SAVE CONFIG
        private void bn_SaveConfig_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings.Remove("szIPSelected");
            app.Settings.Add("szIPSelected", tb_ListenIP.Text);
            app.Settings.Remove("szPort");
            app.Settings.Add("szPort", tb_ListenPort.Text);
            app.Settings.Remove("szIPSelectedSend");
            app.Settings.Add("szIPSelectedSend", tb_SendIP.Text);
            app.Settings.Remove("szTTL");
            app.Settings.Add("szTTL", tb_MC_TTL.Text);
            app.Settings.Remove("szPortSend");
            app.Settings.Add("szPortSend", tb_SendPort.Text);
            app.Settings.Remove("SzSrcPort");
            app.Settings.Add("SzSrcPort", tb_ReflectSrcPort.Text);
            app.Settings.Remove("szListenIP");
            app.Settings.Add("szListenIP", cb_ListenIPs.SelectedItem.ToString());
            app.Settings.Remove("szSendIP");
            app.Settings.Add("szSendIP", cb_SrcIPs.SelectedItem.ToString());
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void bn_ReadConfig_Click(object sender, EventArgs e)
        {
            readConfigFile();
        }

        private void readConfigFile()
        {
            ConfigurationManager.RefreshSection("appSettings");
            //string sAttr;
            string test = ConfigurationManager.AppSettings.Get("szIPSelected");
            if (test == null) return;

            tb_ListenIP.Text = ConfigurationManager.AppSettings.Get("szIPSelected");
            tb_ListenPort.Text = ConfigurationManager.AppSettings.Get("szPort");
            cb_ListenIPs.SelectedItem = ConfigurationManager.AppSettings.Get("szListenIP");
            tb_SendIP.Text = ConfigurationManager.AppSettings.Get("szIPSelectedSend");
            tb_SendPort.Text = ConfigurationManager.AppSettings.Get("szPortSend");
            cb_SrcIPs.SelectedItem = ConfigurationManager.AppSettings.Get("szSendIP");
            tb_ReflectSrcPort.Text = ConfigurationManager.AppSettings.Get("szSrcPort");
            tb_MC_TTL.Text = ConfigurationManager.AppSettings.Get("szTTL");
        }

        private void cB_IncludeWireless_CheckedChanged(object sender, EventArgs e)
        {
            debug("Checked Changed");
            if (cB_IncludeWireless.Checked) debug("IS Checked");
        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {
            debugClear();
        }

        private void cb_AnyPort_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AnyPort.Checked) cb_ListenIPs.Enabled = false;
            else cb_ListenIPs.Enabled = true;
        }

        private void bn_ShowConfig_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            foreach (string key in appSettings.AllKeys)
            {
                debug(key + " " + appSettings[key]);
            }
        }

        private void cb_Quiet_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Quiet.Checked == true)
            {
                quietMode = true;
                tb_PacketsRead.Enabled = false;
                tb_PacketsSent.Enabled = false;
            }
            else
            {
                quietMode = false;
                tb_PacketsRead.Enabled = true;
                tb_PacketsSent.Enabled = true;
            }
        }

    }//end  Class
}//end namespace
