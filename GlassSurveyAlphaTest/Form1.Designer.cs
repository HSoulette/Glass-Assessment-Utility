using System;

namespace GlassSurveyAlphaTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_rssi = new System.Windows.Forms.TextBox();
            this.openFile_rssi = new System.Windows.Forms.OpenFileDialog();
            this.rssi = new System.Windows.Forms.Timer(this.components);
            this.runbat = new System.Windows.Forms.Timer(this.components);
            this.tb_linkspeed = new System.Windows.Forms.TextBox();
            this.openFile_linkspeed = new System.Windows.Forms.OpenFileDialog();
            this.b_start = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.tb_bssid = new System.Windows.Forms.TextBox();
            this.openFile_bssid = new System.Windows.Forms.OpenFileDialog();
            this.openFile_ssid = new System.Windows.Forms.OpenFileDialog();
            this.tb_ssid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_bssidcount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFile_bssidcount = new System.Windows.Forms.OpenFileDialog();
            this.tb_roamcount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_duration = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sw = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tb_channel = new System.Windows.Forms.TextBox();
            this.openFile_channel = new System.Windows.Forms.OpenFileDialog();
            this.b_reset = new System.Windows.Forms.Button();
            this.tb_disconnections = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.p_ScanTool = new System.Windows.Forms.Panel();
            this.b_stopsave = new System.Windows.Forms.Button();
            this.l_FilenameError = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Filename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.b_Scan = new System.Windows.Forms.Button();
            this.b_Tools = new System.Windows.Forms.Button();
            this.p_Tools = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.b_24ghz2 = new System.Windows.Forms.Button();
            this.b_5ghz2 = new System.Windows.Forms.Button();
            this.b_Logs2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.b_Logs = new System.Windows.Forms.Button();
            this.b_SG3ReinstallS = new System.Windows.Forms.Button();
            this.b_SG3ReinstallG = new System.Windows.Forms.Button();
            this.b_SG2Reinstall = new System.Windows.Forms.Button();
            this.b_24ghz = new System.Windows.Forms.Button();
            this.b_5ghz = new System.Windows.Forms.Button();
            this.b_WiFiQRCode = new System.Windows.Forms.Button();
            this.p_navigation = new System.Windows.Forms.Panel();
            this.b_Help = new System.Windows.Forms.Button();
            this.p_Help = new System.Windows.Forms.Panel();
            this.l_HelpTitle = new System.Windows.Forms.Label();
            this.l_HelpText1 = new System.Windows.Forms.Label();
            this.t_Csv = new System.Windows.Forms.Timer(this.components);
            this.p_ScanTool.SuspendLayout();
            this.p_Tools.SuspendLayout();
            this.p_navigation.SuspendLayout();
            this.p_Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_rssi
            // 
            this.tb_rssi.BackColor = System.Drawing.Color.White;
            this.tb_rssi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rssi.Location = new System.Drawing.Point(740, 618);
            this.tb_rssi.Name = "tb_rssi";
            this.tb_rssi.ReadOnly = true;
            this.tb_rssi.Size = new System.Drawing.Size(328, 35);
            this.tb_rssi.TabIndex = 0;
            this.tb_rssi.TextChanged += new System.EventHandler(this.tb_rssi_TextChanged);
            // 
            // openFile_rssi
            // 
            this.openFile_rssi.FileName = "rssi.txt";
            this.openFile_rssi.ReadOnlyChecked = true;
            this.openFile_rssi.ValidateNames = false;
            // 
            // rssi
            // 
            this.rssi.Enabled = true;
            this.rssi.Interval = 1151;
            this.rssi.Tick += new System.EventHandler(this.rssi_Tick);
            // 
            // runbat
            // 
            this.runbat.Interval = 1500;
            this.runbat.Tick += new System.EventHandler(this.runbat_Tick);
            // 
            // tb_linkspeed
            // 
            this.tb_linkspeed.BackColor = System.Drawing.Color.White;
            this.tb_linkspeed.Enabled = false;
            this.tb_linkspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_linkspeed.Location = new System.Drawing.Point(740, 674);
            this.tb_linkspeed.Name = "tb_linkspeed";
            this.tb_linkspeed.ReadOnly = true;
            this.tb_linkspeed.Size = new System.Drawing.Size(328, 35);
            this.tb_linkspeed.TabIndex = 1;
            // 
            // openFile_linkspeed
            // 
            this.openFile_linkspeed.FileName = "linkspeed.txt";
            this.openFile_linkspeed.ValidateNames = false;
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.Color.SteelBlue;
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.ForeColor = System.Drawing.Color.White;
            this.b_start.Location = new System.Drawing.Point(804, 752);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(264, 65);
            this.b_start.TabIndex = 2;
            this.b_start.Text = "Start Scanning";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_stop
            // 
            this.b_stop.BackColor = System.Drawing.Color.SteelBlue;
            this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_stop.ForeColor = System.Drawing.Color.White;
            this.b_stop.Location = new System.Drawing.Point(14, 752);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(264, 65);
            this.b_stop.TabIndex = 3;
            this.b_stop.Text = "Stop/Clear Scan";
            this.b_stop.UseVisualStyleBackColor = false;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // tb_bssid
            // 
            this.tb_bssid.BackColor = System.Drawing.Color.White;
            this.tb_bssid.Enabled = false;
            this.tb_bssid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bssid.Location = new System.Drawing.Point(740, 517);
            this.tb_bssid.Name = "tb_bssid";
            this.tb_bssid.ReadOnly = true;
            this.tb_bssid.Size = new System.Drawing.Size(328, 35);
            this.tb_bssid.TabIndex = 4;
            this.tb_bssid.TextChanged += new System.EventHandler(this.tb_bssid_TextChanged);
            // 
            // openFile_bssid
            // 
            this.openFile_bssid.FileName = "bssid.txt";
            this.openFile_bssid.ReadOnlyChecked = true;
            this.openFile_bssid.ValidateNames = false;
            // 
            // openFile_ssid
            // 
            this.openFile_ssid.FileName = "ssid.txt";
            this.openFile_ssid.ReadOnlyChecked = true;
            this.openFile_ssid.ValidateNames = false;
            // 
            // tb_ssid
            // 
            this.tb_ssid.BackColor = System.Drawing.Color.White;
            this.tb_ssid.Enabled = false;
            this.tb_ssid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ssid.Location = new System.Drawing.Point(740, 457);
            this.tb_ssid.Name = "tb_ssid";
            this.tb_ssid.ReadOnly = true;
            this.tb_ssid.Size = new System.Drawing.Size(328, 35);
            this.tb_ssid.TabIndex = 5;
            this.tb_ssid.TextChanged += new System.EventHandler(this.tb_ssid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connected SSID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current BSSID (AP):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Signal Strength:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Rate (Mbps):";
            // 
            // tb_bssidcount
            // 
            this.tb_bssidcount.BackColor = System.Drawing.Color.White;
            this.tb_bssidcount.Enabled = false;
            this.tb_bssidcount.Location = new System.Drawing.Point(225, 618);
            this.tb_bssidcount.Multiline = true;
            this.tb_bssidcount.Name = "tb_bssidcount";
            this.tb_bssidcount.ReadOnly = true;
            this.tb_bssidcount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_bssidcount.Size = new System.Drawing.Size(248, 91);
            this.tb_bssidcount.TabIndex = 10;
            this.tb_bssidcount.TextChanged += new System.EventHandler(this.tb_bssidcount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Associations:";
            // 
            // openFile_bssidcount
            // 
            this.openFile_bssidcount.FileName = "bssidcount.txt";
            this.openFile_bssidcount.ReadOnlyChecked = true;
            // 
            // tb_roamcount
            // 
            this.tb_roamcount.BackColor = System.Drawing.SystemColors.Control;
            this.tb_roamcount.Enabled = false;
            this.tb_roamcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_roamcount.Location = new System.Drawing.Point(284, 518);
            this.tb_roamcount.Name = "tb_roamcount";
            this.tb_roamcount.ReadOnly = true;
            this.tb_roamcount.Size = new System.Drawing.Size(190, 35);
            this.tb_roamcount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Scan Duration:";
            // 
            // tb_duration
            // 
            this.tb_duration.BackColor = System.Drawing.Color.White;
            this.tb_duration.Enabled = false;
            this.tb_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_duration.Location = new System.Drawing.Point(284, 460);
            this.tb_duration.Name = "tb_duration";
            this.tb_duration.ReadOnly = true;
            this.tb_duration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_duration.Size = new System.Drawing.Size(190, 35);
            this.tb_duration.TabIndex = 14;
            this.tb_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // sw
            // 
            this.sw.Interval = 10;
            this.sw.Tick += new System.EventHandler(this.t_stopwatch_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "AP Channel:";
            // 
            // tb_channel
            // 
            this.tb_channel.BackColor = System.Drawing.Color.White;
            this.tb_channel.Enabled = false;
            this.tb_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_channel.Location = new System.Drawing.Point(740, 569);
            this.tb_channel.Name = "tb_channel";
            this.tb_channel.ReadOnly = true;
            this.tb_channel.Size = new System.Drawing.Size(328, 35);
            this.tb_channel.TabIndex = 15;
            this.tb_channel.TextChanged += new System.EventHandler(this.tb_channel_TextChanged);
            // 
            // openFile_channel
            // 
            this.openFile_channel.FileName = "channel.txt";
            // 
            // b_reset
            // 
            this.b_reset.BackColor = System.Drawing.Color.SteelBlue;
            this.b_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_reset.ForeColor = System.Drawing.Color.White;
            this.b_reset.Location = new System.Drawing.Point(31, 669);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(165, 40);
            this.b_reset.TabIndex = 17;
            this.b_reset.Text = "Reset Timer";
            this.b_reset.UseVisualStyleBackColor = false;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // tb_disconnections
            // 
            this.tb_disconnections.BackColor = System.Drawing.SystemColors.Control;
            this.tb_disconnections.Enabled = false;
            this.tb_disconnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_disconnections.Location = new System.Drawing.Point(284, 566);
            this.tb_disconnections.Name = "tb_disconnections";
            this.tb_disconnections.ReadOnly = true;
            this.tb_disconnections.Size = new System.Drawing.Size(190, 35);
            this.tb_disconnections.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Disconnections:";
            // 
            // tb_status
            // 
            this.tb_status.BackColor = System.Drawing.Color.Black;
            this.tb_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_status.ForeColor = System.Drawing.Color.White;
            this.tb_status.Location = new System.Drawing.Point(740, 406);
            this.tb_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_status.Multiline = true;
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(328, 36);
            this.tb_status.TabIndex = 21;
            this.tb_status.Text = "Connection Status";
            this.tb_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_ScanTool
            // 
            this.p_ScanTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_ScanTool.Controls.Add(this.b_stopsave);
            this.p_ScanTool.Controls.Add(this.l_FilenameError);
            this.p_ScanTool.Controls.Add(this.label12);
            this.p_ScanTool.Controls.Add(this.tb_Filename);
            this.p_ScanTool.Controls.Add(this.label9);
            this.p_ScanTool.Controls.Add(this.b_stop);
            this.p_ScanTool.Controls.Add(this.tb_bssidcount);
            this.p_ScanTool.Controls.Add(this.tb_ssid);
            this.p_ScanTool.Controls.Add(this.tb_status);
            this.p_ScanTool.Controls.Add(this.tb_channel);
            this.p_ScanTool.Controls.Add(this.label7);
            this.p_ScanTool.Controls.Add(this.tb_rssi);
            this.p_ScanTool.Controls.Add(this.label1);
            this.p_ScanTool.Controls.Add(this.label5);
            this.p_ScanTool.Controls.Add(this.tb_bssid);
            this.p_ScanTool.Controls.Add(this.tb_linkspeed);
            this.p_ScanTool.Controls.Add(this.tb_duration);
            this.p_ScanTool.Controls.Add(this.label4);
            this.p_ScanTool.Controls.Add(this.b_reset);
            this.p_ScanTool.Controls.Add(this.tb_disconnections);
            this.p_ScanTool.Controls.Add(this.label2);
            this.p_ScanTool.Controls.Add(this.tb_roamcount);
            this.p_ScanTool.Controls.Add(this.label6);
            this.p_ScanTool.Controls.Add(this.b_start);
            this.p_ScanTool.Controls.Add(this.label8);
            this.p_ScanTool.Controls.Add(this.label3);
            this.p_ScanTool.Location = new System.Drawing.Point(320, 18);
            this.p_ScanTool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_ScanTool.Name = "p_ScanTool";
            this.p_ScanTool.Size = new System.Drawing.Size(1078, 825);
            this.p_ScanTool.TabIndex = 22;
            this.p_ScanTool.Visible = false;
            // 
            // b_stopsave
            // 
            this.b_stopsave.BackColor = System.Drawing.Color.SteelBlue;
            this.b_stopsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stopsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_stopsave.ForeColor = System.Drawing.Color.White;
            this.b_stopsave.Location = new System.Drawing.Point(507, 752);
            this.b_stopsave.Name = "b_stopsave";
            this.b_stopsave.Size = new System.Drawing.Size(264, 65);
            this.b_stopsave.TabIndex = 26;
            this.b_stopsave.Text = "Stop and Save";
            this.b_stopsave.UseVisualStyleBackColor = false;
            this.b_stopsave.Click += new System.EventHandler(this.b_stopsave_Click);
            // 
            // l_FilenameError
            // 
            this.l_FilenameError.AutoSize = true;
            this.l_FilenameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_FilenameError.ForeColor = System.Drawing.Color.DarkRed;
            this.l_FilenameError.Location = new System.Drawing.Point(80, 361);
            this.l_FilenameError.Name = "l_FilenameError";
            this.l_FilenameError.Size = new System.Drawing.Size(350, 29);
            this.l_FilenameError.TabIndex = 25;
            this.l_FilenameError.Text = "*PLEASE ENTER A FILENAME";
            this.l_FilenameError.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "CSV Filename:";
            // 
            // tb_Filename
            // 
            this.tb_Filename.BackColor = System.Drawing.Color.White;
            this.tb_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Filename.Location = new System.Drawing.Point(283, 406);
            this.tb_Filename.Name = "tb_Filename";
            this.tb_Filename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Filename.Size = new System.Drawing.Size(190, 35);
            this.tb_Filename.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 621);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "BSSID History:";
            // 
            // b_Scan
            // 
            this.b_Scan.BackColor = System.Drawing.Color.SteelBlue;
            this.b_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Scan.ForeColor = System.Drawing.Color.White;
            this.b_Scan.Location = new System.Drawing.Point(4, 152);
            this.b_Scan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Scan.Name = "b_Scan";
            this.b_Scan.Size = new System.Drawing.Size(292, 74);
            this.b_Scan.TabIndex = 23;
            this.b_Scan.Text = "WiFi Scanner";
            this.b_Scan.UseVisualStyleBackColor = false;
            this.b_Scan.Click += new System.EventHandler(this.b_Scan_Click);
            // 
            // b_Tools
            // 
            this.b_Tools.BackColor = System.Drawing.Color.SteelBlue;
            this.b_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Tools.ForeColor = System.Drawing.Color.White;
            this.b_Tools.Location = new System.Drawing.Point(4, 15);
            this.b_Tools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Tools.Name = "b_Tools";
            this.b_Tools.Size = new System.Drawing.Size(292, 74);
            this.b_Tools.TabIndex = 24;
            this.b_Tools.Text = "Android Tools";
            this.b_Tools.UseVisualStyleBackColor = false;
            this.b_Tools.Click += new System.EventHandler(this.b_Tools_Click);
            // 
            // p_Tools
            // 
            this.p_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Tools.Controls.Add(this.label11);
            this.p_Tools.Controls.Add(this.b_24ghz2);
            this.p_Tools.Controls.Add(this.b_5ghz2);
            this.p_Tools.Controls.Add(this.b_Logs2);
            this.p_Tools.Controls.Add(this.label10);
            this.p_Tools.Controls.Add(this.b_Logs);
            this.p_Tools.Controls.Add(this.b_SG3ReinstallS);
            this.p_Tools.Controls.Add(this.b_SG3ReinstallG);
            this.p_Tools.Controls.Add(this.b_SG2Reinstall);
            this.p_Tools.Controls.Add(this.b_24ghz);
            this.p_Tools.Controls.Add(this.b_5ghz);
            this.p_Tools.Location = new System.Drawing.Point(320, 18);
            this.p_Tools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_Tools.Name = "p_Tools";
            this.p_Tools.Size = new System.Drawing.Size(1074, 822);
            this.p_Tools.TabIndex = 25;
            this.p_Tools.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(686, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(331, 37);
            this.label11.TabIndex = 11;
            this.label11.Text = "S3/SmartPhone Tools";
            // 
            // b_24ghz2
            // 
            this.b_24ghz2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_24ghz2.Enabled = false;
            this.b_24ghz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_24ghz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_24ghz2.ForeColor = System.Drawing.Color.White;
            this.b_24ghz2.Location = new System.Drawing.Point(666, 406);
            this.b_24ghz2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_24ghz2.Name = "b_24ghz2";
            this.b_24ghz2.Size = new System.Drawing.Size(378, 106);
            this.b_24ghz2.TabIndex = 10;
            this.b_24ghz2.Text = "2.4 Ghz Band Steer";
            this.b_24ghz2.UseVisualStyleBackColor = false;
            // 
            // b_5ghz2
            // 
            this.b_5ghz2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_5ghz2.Enabled = false;
            this.b_5ghz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_5ghz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_5ghz2.ForeColor = System.Drawing.Color.White;
            this.b_5ghz2.Location = new System.Drawing.Point(666, 260);
            this.b_5ghz2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_5ghz2.Name = "b_5ghz2";
            this.b_5ghz2.Size = new System.Drawing.Size(378, 106);
            this.b_5ghz2.TabIndex = 9;
            this.b_5ghz2.Text = "5 Ghz Band Steer";
            this.b_5ghz2.UseVisualStyleBackColor = false;
            // 
            // b_Logs2
            // 
            this.b_Logs2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_Logs2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Logs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Logs2.ForeColor = System.Drawing.Color.White;
            this.b_Logs2.Location = new System.Drawing.Point(666, 120);
            this.b_Logs2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Logs2.Name = "b_Logs2";
            this.b_Logs2.Size = new System.Drawing.Size(378, 106);
            this.b_Logs2.TabIndex = 8;
            this.b_Logs2.Text = "Save Logs (5 Minutes)";
            this.b_Logs2.UseVisualStyleBackColor = false;
            this.b_Logs2.Click += new System.EventHandler(this.b_Logs2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 37);
            this.label10.TabIndex = 7;
            this.label10.Text = "Smart Glass Tools";
            // 
            // b_Logs
            // 
            this.b_Logs.BackColor = System.Drawing.Color.SteelBlue;
            this.b_Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Logs.ForeColor = System.Drawing.Color.White;
            this.b_Logs.Location = new System.Drawing.Point(32, 120);
            this.b_Logs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Logs.Name = "b_Logs";
            this.b_Logs.Size = new System.Drawing.Size(378, 106);
            this.b_Logs.TabIndex = 6;
            this.b_Logs.Text = "Save Logs (5 Minutes)";
            this.b_Logs.UseVisualStyleBackColor = false;
            this.b_Logs.Click += new System.EventHandler(this.b_Logs_Click);
            // 
            // b_SG3ReinstallS
            // 
            this.b_SG3ReinstallS.BackColor = System.Drawing.Color.SteelBlue;
            this.b_SG3ReinstallS.Enabled = false;
            this.b_SG3ReinstallS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SG3ReinstallS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SG3ReinstallS.ForeColor = System.Drawing.Color.White;
            this.b_SG3ReinstallS.Location = new System.Drawing.Point(666, 697);
            this.b_SG3ReinstallS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_SG3ReinstallS.Name = "b_SG3ReinstallS";
            this.b_SG3ReinstallS.Size = new System.Drawing.Size(378, 106);
            this.b_SG3ReinstallS.TabIndex = 4;
            this.b_SG3ReinstallS.Text = "Re-Flash SG3 (Phone)";
            this.b_SG3ReinstallS.UseVisualStyleBackColor = false;
            // 
            // b_SG3ReinstallG
            // 
            this.b_SG3ReinstallG.BackColor = System.Drawing.Color.SteelBlue;
            this.b_SG3ReinstallG.Enabled = false;
            this.b_SG3ReinstallG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SG3ReinstallG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SG3ReinstallG.ForeColor = System.Drawing.Color.White;
            this.b_SG3ReinstallG.Location = new System.Drawing.Point(33, 695);
            this.b_SG3ReinstallG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_SG3ReinstallG.Name = "b_SG3ReinstallG";
            this.b_SG3ReinstallG.Size = new System.Drawing.Size(378, 106);
            this.b_SG3ReinstallG.TabIndex = 3;
            this.b_SG3ReinstallG.Text = "Re-Flash SG3 (Glass)";
            this.b_SG3ReinstallG.UseVisualStyleBackColor = false;
            // 
            // b_SG2Reinstall
            // 
            this.b_SG2Reinstall.BackColor = System.Drawing.Color.SteelBlue;
            this.b_SG2Reinstall.Enabled = false;
            this.b_SG2Reinstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SG2Reinstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SG2Reinstall.ForeColor = System.Drawing.Color.White;
            this.b_SG2Reinstall.Location = new System.Drawing.Point(32, 552);
            this.b_SG2Reinstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_SG2Reinstall.Name = "b_SG2Reinstall";
            this.b_SG2Reinstall.Size = new System.Drawing.Size(378, 106);
            this.b_SG2Reinstall.TabIndex = 2;
            this.b_SG2Reinstall.Text = "Re-Flash SG2";
            this.b_SG2Reinstall.UseVisualStyleBackColor = false;
            // 
            // b_24ghz
            // 
            this.b_24ghz.BackColor = System.Drawing.Color.SteelBlue;
            this.b_24ghz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_24ghz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_24ghz.ForeColor = System.Drawing.Color.White;
            this.b_24ghz.Location = new System.Drawing.Point(33, 406);
            this.b_24ghz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_24ghz.Name = "b_24ghz";
            this.b_24ghz.Size = new System.Drawing.Size(378, 106);
            this.b_24ghz.TabIndex = 1;
            this.b_24ghz.Text = "2.4 Ghz Band Steer";
            this.b_24ghz.UseVisualStyleBackColor = false;
            this.b_24ghz.Click += new System.EventHandler(this.b_24ghz_Click);
            // 
            // b_5ghz
            // 
            this.b_5ghz.BackColor = System.Drawing.Color.SteelBlue;
            this.b_5ghz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_5ghz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_5ghz.ForeColor = System.Drawing.Color.White;
            this.b_5ghz.Location = new System.Drawing.Point(33, 260);
            this.b_5ghz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_5ghz.Name = "b_5ghz";
            this.b_5ghz.Size = new System.Drawing.Size(378, 106);
            this.b_5ghz.TabIndex = 0;
            this.b_5ghz.Text = "5 Ghz Band Steer";
            this.b_5ghz.UseVisualStyleBackColor = false;
            this.b_5ghz.Click += new System.EventHandler(this.b_5ghz_Click);
            // 
            // b_WiFiQRCode
            // 
            this.b_WiFiQRCode.BackColor = System.Drawing.Color.SteelBlue;
            this.b_WiFiQRCode.Enabled = false;
            this.b_WiFiQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_WiFiQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_WiFiQRCode.ForeColor = System.Drawing.Color.White;
            this.b_WiFiQRCode.Location = new System.Drawing.Point(4, 600);
            this.b_WiFiQRCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_WiFiQRCode.Name = "b_WiFiQRCode";
            this.b_WiFiQRCode.Size = new System.Drawing.Size(291, 98);
            this.b_WiFiQRCode.TabIndex = 5;
            this.b_WiFiQRCode.Text = "WiFi QR Code (Future)";
            this.b_WiFiQRCode.UseVisualStyleBackColor = false;
            // 
            // p_navigation
            // 
            this.p_navigation.BackColor = System.Drawing.SystemColors.Control;
            this.p_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_navigation.Controls.Add(this.b_WiFiQRCode);
            this.p_navigation.Controls.Add(this.b_Help);
            this.p_navigation.Controls.Add(this.b_Scan);
            this.p_navigation.Controls.Add(this.b_Tools);
            this.p_navigation.Location = new System.Drawing.Point(8, 18);
            this.p_navigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_navigation.Name = "p_navigation";
            this.p_navigation.Size = new System.Drawing.Size(302, 825);
            this.p_navigation.TabIndex = 26;
            // 
            // b_Help
            // 
            this.b_Help.BackColor = System.Drawing.Color.SteelBlue;
            this.b_Help.Enabled = false;
            this.b_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Help.ForeColor = System.Drawing.Color.White;
            this.b_Help.Location = new System.Drawing.Point(4, 728);
            this.b_Help.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Help.Name = "b_Help";
            this.b_Help.Size = new System.Drawing.Size(292, 74);
            this.b_Help.TabIndex = 25;
            this.b_Help.Text = "Help";
            this.b_Help.UseVisualStyleBackColor = false;
            this.b_Help.Click += new System.EventHandler(this.b_Help_Click);
            // 
            // p_Help
            // 
            this.p_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Help.Controls.Add(this.l_HelpTitle);
            this.p_Help.Controls.Add(this.l_HelpText1);
            this.p_Help.Location = new System.Drawing.Point(320, 18);
            this.p_Help.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_Help.Name = "p_Help";
            this.p_Help.Size = new System.Drawing.Size(1078, 825);
            this.p_Help.TabIndex = 26;
            // 
            // l_HelpTitle
            // 
            this.l_HelpTitle.AutoSize = true;
            this.l_HelpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_HelpTitle.Location = new System.Drawing.Point(26, 20);
            this.l_HelpTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_HelpTitle.Name = "l_HelpTitle";
            this.l_HelpTitle.Size = new System.Drawing.Size(681, 40);
            this.l_HelpTitle.TabIndex = 1;
            this.l_HelpTitle.Text = "Glass Survey Utility v0.5 - Getting Started";
            // 
            // l_HelpText1
            // 
            this.l_HelpText1.AutoSize = true;
            this.l_HelpText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_HelpText1.Location = new System.Drawing.Point(28, 98);
            this.l_HelpText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_HelpText1.Name = "l_HelpText1";
            this.l_HelpText1.Size = new System.Drawing.Size(1092, 609);
            this.l_HelpText1.TabIndex = 0;
            this.l_HelpText1.Text = resources.GetString("l_HelpText1.Text");
            // 
            // t_Csv
            // 
            this.t_Csv.Interval = 2000;
            this.t_Csv.Tick += new System.EventHandler(this.t_Csv_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 854);
            this.Controls.Add(this.p_navigation);
            this.Controls.Add(this.p_ScanTool);
            this.Controls.Add(this.p_Tools);
            this.Controls.Add(this.p_Help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glass Survey Utility";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_ScanTool.ResumeLayout(false);
            this.p_ScanTool.PerformLayout();
            this.p_Tools.ResumeLayout(false);
            this.p_Tools.PerformLayout();
            this.p_navigation.ResumeLayout(false);
            this.p_Help.ResumeLayout(false);
            this.p_Help.PerformLayout();
            this.ResumeLayout(false);

        }

        private void b_ANS2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_rssi;
        private System.Windows.Forms.OpenFileDialog openFile_rssi;
        private System.Windows.Forms.Timer rssi;
        private System.Windows.Forms.Timer runbat;
        private System.Windows.Forms.TextBox tb_linkspeed;
        private System.Windows.Forms.OpenFileDialog openFile_linkspeed;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.TextBox tb_bssid;
        private System.Windows.Forms.OpenFileDialog openFile_bssid;
        private System.Windows.Forms.OpenFileDialog openFile_ssid;
        private System.Windows.Forms.TextBox tb_ssid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bssidcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFile_bssidcount;
        private System.Windows.Forms.TextBox tb_roamcount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_duration;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer sw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_channel;
        private System.Windows.Forms.OpenFileDialog openFile_channel;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.TextBox tb_disconnections;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Panel p_ScanTool;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_Scan;
        private System.Windows.Forms.Button b_Tools;
        private System.Windows.Forms.Panel p_Tools;
        private System.Windows.Forms.Button b_WiFiQRCode;
        private System.Windows.Forms.Button b_SG3ReinstallS;
        private System.Windows.Forms.Button b_SG3ReinstallG;
        private System.Windows.Forms.Button b_SG2Reinstall;
        private System.Windows.Forms.Button b_24ghz;
        private System.Windows.Forms.Button b_5ghz;
        private System.Windows.Forms.Button b_Logs;
        private System.Windows.Forms.Panel p_navigation;
        private System.Windows.Forms.Button b_Help;
        private System.Windows.Forms.Panel p_Help;
        private System.Windows.Forms.Label l_HelpTitle;
        private System.Windows.Forms.Label l_HelpText1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button b_24ghz2;
        private System.Windows.Forms.Button b_5ghz2;
        private System.Windows.Forms.Button b_Logs2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer t_Csv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Filename;
        private System.Windows.Forms.Label l_FilenameError;
        private System.Windows.Forms.Button b_stopsave;
    }
}

