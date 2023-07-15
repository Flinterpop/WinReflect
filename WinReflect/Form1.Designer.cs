namespace WinReflect
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
                sending_socket.Dispose();
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
            this.rtb_Debug = new System.Windows.Forms.RichTextBox();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.bn_Quit = new System.Windows.Forms.Button();
            this.bn_listen = new System.Windows.Forms.Button();
            this.tb_ListenIP = new System.Windows.Forms.TextBox();
            this.tb_ListenPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SendPort = new System.Windows.Forms.TextBox();
            this.tb_SendIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_PacketsRead = new System.Windows.Forms.TextBox();
            this.tb_PacketsSent = new System.Windows.Forms.TextBox();
            this.bn_GetAdapterInfo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bn_ReflectMC = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_SrcIPs = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_MulticastInd = new System.Windows.Forms.Label();
            this.cb_AnyPort = new System.Windows.Forms.CheckBox();
            this.cb_ListenIPs = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_MC_TTL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_ReflectSrcPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_LongRunDebug = new System.Windows.Forms.CheckBox();
            this.cb_Debug = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtb_AdapterInfo = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.bn_SaveConfig = new System.Windows.Forms.Button();
            this.bn_ReadConfig = new System.Windows.Forms.Button();
            this.cB_IncludeWireless = new System.Windows.Forms.CheckBox();
            this.bn_Clear = new System.Windows.Forms.Button();
            this.bn_ShowConfig = new System.Windows.Forms.Button();
            this.cb_Quiet = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Debug
            // 
            this.rtb_Debug.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Debug.Location = new System.Drawing.Point(5, 54);
            this.rtb_Debug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_Debug.Name = "rtb_Debug";
            this.rtb_Debug.ReadOnly = true;
            this.rtb_Debug.Size = new System.Drawing.Size(933, 351);
            this.rtb_Debug.TabIndex = 1;
            this.rtb_Debug.Text = "";
            // 
            // tb_host
            // 
            this.tb_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_host.Location = new System.Drawing.Point(161, 14);
            this.tb_host.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(396, 29);
            this.tb_host.TabIndex = 3;
            // 
            // bn_Quit
            // 
            this.bn_Quit.Location = new System.Drawing.Point(858, 14);
            this.bn_Quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_Quit.Name = "bn_Quit";
            this.bn_Quit.Size = new System.Drawing.Size(147, 48);
            this.bn_Quit.TabIndex = 4;
            this.bn_Quit.Text = "Quit";
            this.bn_Quit.UseVisualStyleBackColor = true;
            this.bn_Quit.Click += new System.EventHandler(this.bn_Quit_Click);
            // 
            // bn_listen
            // 
            this.bn_listen.Location = new System.Drawing.Point(262, 301);
            this.bn_listen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_listen.Name = "bn_listen";
            this.bn_listen.Size = new System.Drawing.Size(174, 48);
            this.bn_listen.TabIndex = 6;
            this.bn_listen.Text = "Start Listening";
            this.bn_listen.UseVisualStyleBackColor = true;
            this.bn_listen.Click += new System.EventHandler(this.bn_listen_Click);
            // 
            // tb_ListenIP
            // 
            this.tb_ListenIP.Location = new System.Drawing.Point(237, 20);
            this.tb_ListenIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ListenIP.Name = "tb_ListenIP";
            this.tb_ListenIP.Size = new System.Drawing.Size(226, 29);
            this.tb_ListenIP.TabIndex = 7;
            this.tb_ListenIP.Text = "239.255.0.1";
            this.tb_ListenIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ListenPort
            // 
            this.tb_ListenPort.Location = new System.Drawing.Point(237, 76);
            this.tb_ListenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ListenPort.Name = "tb_ListenPort";
            this.tb_ListenPort.Size = new System.Drawing.Size(226, 29);
            this.tb_ListenPort.TabIndex = 8;
            this.tb_ListenPort.Text = "1841";
            this.tb_ListenPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Listen for IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Listen on Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Reflect Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reflect IP";
            // 
            // tb_SendPort
            // 
            this.tb_SendPort.Location = new System.Drawing.Point(15, 76);
            this.tb_SendPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_SendPort.Name = "tb_SendPort";
            this.tb_SendPort.Size = new System.Drawing.Size(226, 29);
            this.tb_SendPort.TabIndex = 14;
            this.tb_SendPort.Text = "5006";
            this.tb_SendPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_SendIP
            // 
            this.tb_SendIP.Location = new System.Drawing.Point(15, 26);
            this.tb_SendIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_SendIP.Name = "tb_SendIP";
            this.tb_SendIP.Size = new System.Drawing.Size(226, 29);
            this.tb_SendIP.TabIndex = 13;
            this.tb_SendIP.Text = "239.255.3.5";
            this.tb_SendIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Packets Read";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Packets Reflected";
            // 
            // tb_PacketsRead
            // 
            this.tb_PacketsRead.Location = new System.Drawing.Point(262, 367);
            this.tb_PacketsRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PacketsRead.Name = "tb_PacketsRead";
            this.tb_PacketsRead.Size = new System.Drawing.Size(170, 29);
            this.tb_PacketsRead.TabIndex = 18;
            // 
            // tb_PacketsSent
            // 
            this.tb_PacketsSent.Location = new System.Drawing.Point(32, 367);
            this.tb_PacketsSent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PacketsSent.Name = "tb_PacketsSent";
            this.tb_PacketsSent.Size = new System.Drawing.Size(170, 29);
            this.tb_PacketsSent.TabIndex = 19;
            // 
            // bn_GetAdapterInfo
            // 
            this.bn_GetAdapterInfo.Location = new System.Drawing.Point(596, 14);
            this.bn_GetAdapterInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_GetAdapterInfo.Name = "bn_GetAdapterInfo";
            this.bn_GetAdapterInfo.Size = new System.Drawing.Size(235, 48);
            this.bn_GetAdapterInfo.TabIndex = 20;
            this.bn_GetAdapterInfo.Text = "Query Adapter Info";
            this.bn_GetAdapterInfo.UseVisualStyleBackColor = true;
            this.bn_GetAdapterInfo.Click += new System.EventHandler(this.bn_GetAdapterInfo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Host Name";
            // 
            // bn_ReflectMC
            // 
            this.bn_ReflectMC.Location = new System.Drawing.Point(32, 301);
            this.bn_ReflectMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_ReflectMC.Name = "bn_ReflectMC";
            this.bn_ReflectMC.Size = new System.Drawing.Size(174, 48);
            this.bn_ReflectMC.TabIndex = 22;
            this.bn_ReflectMC.Text = "Start Reflecting";
            this.bn_ReflectMC.UseVisualStyleBackColor = true;
            this.bn_ReflectMC.Click += new System.EventHandler(this.bn_ReflectMC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Reflect Src IP";
            // 
            // cb_SrcIPs
            // 
            this.cb_SrcIPs.FormattingEnabled = true;
            this.cb_SrcIPs.Location = new System.Drawing.Point(15, 120);
            this.cb_SrcIPs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_SrcIPs.Name = "cb_SrcIPs";
            this.cb_SrcIPs.Size = new System.Drawing.Size(226, 32);
            this.cb_SrcIPs.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lb_MulticastInd);
            this.groupBox1.Controls.Add(this.cb_AnyPort);
            this.groupBox1.Controls.Add(this.cb_ListenIPs);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_ListenIP);
            this.groupBox1.Controls.Add(this.tb_ListenPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bn_listen);
            this.groupBox1.Controls.Add(this.tb_PacketsRead);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(34, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(477, 425);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listen";
            // 
            // lb_MulticastInd
            // 
            this.lb_MulticastInd.AutoSize = true;
            this.lb_MulticastInd.Location = new System.Drawing.Point(358, 233);
            this.lb_MulticastInd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MulticastInd.Name = "lb_MulticastInd";
            this.lb_MulticastInd.Size = new System.Drawing.Size(52, 25);
            this.lb_MulticastInd.TabIndex = 34;
            this.lb_MulticastInd.Text = "TBD";
            // 
            // cb_AnyPort
            // 
            this.cb_AnyPort.AutoSize = true;
            this.cb_AnyPort.Checked = true;
            this.cb_AnyPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AnyPort.Location = new System.Drawing.Point(152, 186);
            this.cb_AnyPort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_AnyPort.Name = "cb_AnyPort";
            this.cb_AnyPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_AnyPort.Size = new System.Drawing.Size(203, 29);
            this.cb_AnyPort.TabIndex = 33;
            this.cb_AnyPort.Text = "Listen on ANY Port";
            this.cb_AnyPort.UseVisualStyleBackColor = true;
            this.cb_AnyPort.CheckedChanged += new System.EventHandler(this.cb_AnyPort_CheckedChanged);
            // 
            // cb_ListenIPs
            // 
            this.cb_ListenIPs.FormattingEnabled = true;
            this.cb_ListenIPs.Location = new System.Drawing.Point(237, 126);
            this.cb_ListenIPs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ListenIPs.Name = "cb_ListenIPs";
            this.cb_ListenIPs.Size = new System.Drawing.Size(226, 32);
            this.cb_ListenIPs.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 131);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "Listen on Src IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Listening on Multicast?";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.tb_MC_TTL);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_ReflectSrcPort);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cb_SrcIPs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bn_ReflectMC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_PacketsSent);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_SendIP);
            this.groupBox2.Controls.Add(this.tb_SendPort);
            this.groupBox2.Location = new System.Drawing.Point(545, 113);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(460, 425);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reflect";
            // 
            // tb_MC_TTL
            // 
            this.tb_MC_TTL.Location = new System.Drawing.Point(98, 214);
            this.tb_MC_TTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_MC_TTL.Name = "tb_MC_TTL";
            this.tb_MC_TTL.Size = new System.Drawing.Size(143, 29);
            this.tb_MC_TTL.TabIndex = 29;
            this.tb_MC_TTL.Text = "128";
            this.tb_MC_TTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 220);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "TTL";
            // 
            // tb_ReflectSrcPort
            // 
            this.tb_ReflectSrcPort.Location = new System.Drawing.Point(98, 170);
            this.tb_ReflectSrcPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ReflectSrcPort.Name = "tb_ReflectSrcPort";
            this.tb_ReflectSrcPort.Size = new System.Drawing.Size(143, 29);
            this.tb_ReflectSrcPort.TabIndex = 27;
            this.tb_ReflectSrcPort.Text = "5006";
            this.tb_ReflectSrcPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Reflect Src Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(34, 617);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 452);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_LongRunDebug);
            this.tabPage1.Controls.Add(this.cb_Debug);
            this.tabPage1.Controls.Add(this.rtb_Debug);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(962, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Debug";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_LongRunDebug
            // 
            this.cb_LongRunDebug.AutoSize = true;
            this.cb_LongRunDebug.Location = new System.Drawing.Point(210, 18);
            this.cb_LongRunDebug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_LongRunDebug.Name = "cb_LongRunDebug";
            this.cb_LongRunDebug.Size = new System.Drawing.Size(244, 29);
            this.cb_LongRunDebug.TabIndex = 4;
            this.cb_LongRunDebug.Text = "Long Run Debug Active";
            this.cb_LongRunDebug.UseVisualStyleBackColor = true;
            this.cb_LongRunDebug.CheckedChanged += new System.EventHandler(this.cb_LongRunDebug_CheckedChanged);
            // 
            // cb_Debug
            // 
            this.cb_Debug.AutoSize = true;
            this.cb_Debug.Checked = true;
            this.cb_Debug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Debug.Location = new System.Drawing.Point(7, 18);
            this.cb_Debug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Debug.Name = "cb_Debug";
            this.cb_Debug.Size = new System.Drawing.Size(155, 29);
            this.cb_Debug.TabIndex = 3;
            this.cb_Debug.Text = "Debug Active";
            this.cb_Debug.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtb_AdapterInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(962, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adapter Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtb_AdapterInfo
            // 
            this.rtb_AdapterInfo.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_AdapterInfo.Location = new System.Drawing.Point(7, 10);
            this.rtb_AdapterInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_AdapterInfo.Name = "rtb_AdapterInfo";
            this.rtb_AdapterInfo.Size = new System.Drawing.Size(943, 398);
            this.rtb_AdapterInfo.TabIndex = 0;
            this.rtb_AdapterInfo.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(962, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(946, 375);
            this.label10.TabIndex = 1;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(962, 415);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Change Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(492, 450);
            this.label12.TabIndex = 0;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // bn_SaveConfig
            // 
            this.bn_SaveConfig.Location = new System.Drawing.Point(714, 566);
            this.bn_SaveConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_SaveConfig.Name = "bn_SaveConfig";
            this.bn_SaveConfig.Size = new System.Drawing.Size(144, 42);
            this.bn_SaveConfig.TabIndex = 29;
            this.bn_SaveConfig.Text = "Save Config";
            this.bn_SaveConfig.UseVisualStyleBackColor = true;
            this.bn_SaveConfig.Click += new System.EventHandler(this.bn_SaveConfig_Click);
            // 
            // bn_ReadConfig
            // 
            this.bn_ReadConfig.Location = new System.Drawing.Point(560, 566);
            this.bn_ReadConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_ReadConfig.Name = "bn_ReadConfig";
            this.bn_ReadConfig.Size = new System.Drawing.Size(144, 42);
            this.bn_ReadConfig.TabIndex = 30;
            this.bn_ReadConfig.Text = "Read Config";
            this.bn_ReadConfig.UseVisualStyleBackColor = true;
            this.bn_ReadConfig.Click += new System.EventHandler(this.bn_ReadConfig_Click);
            // 
            // cB_IncludeWireless
            // 
            this.cB_IncludeWireless.AutoSize = true;
            this.cB_IncludeWireless.Location = new System.Drawing.Point(598, 72);
            this.cB_IncludeWireless.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cB_IncludeWireless.Name = "cB_IncludeWireless";
            this.cB_IncludeWireless.Size = new System.Drawing.Size(192, 29);
            this.cB_IncludeWireless.TabIndex = 31;
            this.cB_IncludeWireless.Text = "include Wireless?";
            this.cB_IncludeWireless.UseVisualStyleBackColor = true;
            this.cB_IncludeWireless.CheckedChanged += new System.EventHandler(this.cB_IncludeWireless_CheckedChanged);
            // 
            // bn_Clear
            // 
            this.bn_Clear.Location = new System.Drawing.Point(34, 566);
            this.bn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bn_Clear.Name = "bn_Clear";
            this.bn_Clear.Size = new System.Drawing.Size(133, 42);
            this.bn_Clear.TabIndex = 32;
            this.bn_Clear.Text = "Clear Debug";
            this.bn_Clear.UseVisualStyleBackColor = true;
            this.bn_Clear.Click += new System.EventHandler(this.bn_Clear_Click);
            // 
            // bn_ShowConfig
            // 
            this.bn_ShowConfig.Location = new System.Drawing.Point(868, 566);
            this.bn_ShowConfig.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bn_ShowConfig.Name = "bn_ShowConfig";
            this.bn_ShowConfig.Size = new System.Drawing.Size(137, 42);
            this.bn_ShowConfig.TabIndex = 35;
            this.bn_ShowConfig.Text = "Show Config";
            this.bn_ShowConfig.UseVisualStyleBackColor = true;
            this.bn_ShowConfig.Click += new System.EventHandler(this.bn_ShowConfig_Click);
            // 
            // cb_Quiet
            // 
            this.cb_Quiet.AutoSize = true;
            this.cb_Quiet.Location = new System.Drawing.Point(204, 574);
            this.cb_Quiet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_Quiet.Name = "cb_Quiet";
            this.cb_Quiet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_Quiet.Size = new System.Drawing.Size(184, 29);
            this.cb_Quiet.TabIndex = 35;
            this.cb_Quiet.Text = "Quiet (High Perf)";
            this.cb_Quiet.UseVisualStyleBackColor = true;
            this.cb_Quiet.CheckedChanged += new System.EventHandler(this.cb_Quiet_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 1086);
            this.Controls.Add(this.cb_Quiet);
            this.Controls.Add(this.bn_ShowConfig);
            this.Controls.Add(this.bn_Clear);
            this.Controls.Add(this.cB_IncludeWireless);
            this.Controls.Add(this.bn_ReadConfig);
            this.Controls.Add(this.bn_SaveConfig);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bn_GetAdapterInfo);
            this.Controls.Add(this.bn_Quit);
            this.Controls.Add(this.tb_host);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "WinPacketReflector - 31 Jan 2021 - B. Graham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_Debug;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Button bn_Quit;
        private System.Windows.Forms.Button bn_listen;
        private System.Windows.Forms.TextBox tb_ListenIP;
        private System.Windows.Forms.TextBox tb_ListenPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SendPort;
        private System.Windows.Forms.TextBox tb_SendIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_PacketsRead;
        private System.Windows.Forms.TextBox tb_PacketsSent;
        private System.Windows.Forms.Button bn_GetAdapterInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bn_ReflectMC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_SrcIPs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtb_AdapterInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Debug;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_LongRunDebug;
        private System.Windows.Forms.TextBox tb_ReflectSrcPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_MC_TTL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bn_SaveConfig;
        private System.Windows.Forms.Button bn_ReadConfig;
        private System.Windows.Forms.ComboBox cb_ListenIPs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cB_IncludeWireless;
        private System.Windows.Forms.Button bn_Clear;
        private System.Windows.Forms.CheckBox cb_AnyPort;
        private System.Windows.Forms.Button bn_ShowConfig;
        private System.Windows.Forms.Label lb_MulticastInd;
        private System.Windows.Forms.CheckBox cb_Quiet;
    }
}

