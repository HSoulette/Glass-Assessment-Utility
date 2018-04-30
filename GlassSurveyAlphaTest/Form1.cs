using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassSurveyAlphaTest
{
    public partial class Form1 : Form
    {


        Stopwatch sw1 = new Stopwatch();
        public Form1()
        {
            InitializeComponent();


        }
        // Field Tablet Tool v0.5
        //
        // Panels = p_ObjectName
        // Buttons = b_ObjectName
        // TextBoxes = tb_ObjectName
        // OpenFile = openFile_ObjectName (Usually Object Name is the same as the filename without the extention)
        //
        // The way this is set up is super basic, and still buggy. I read the "adb wifi dumpsys" to a file, and parse that file for the information for the scanner.
        // For the tools, simple bat scripting is used. These scripts could be icons on the desktop, but to keep it simple for the field folks, I've make them simple buttons.
        // I've seperated each tool to avoid mistakes being made while any one tool or function is being used.
        //
        // I will add more notes as develpment continues.
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        


        private void t_stopwatch_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw1.Elapsed;
            tb_duration.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);


        }





        public static bool IsFileReady(String sFilename)
        {
            // If the file can be opened for exclusive access it means that the file
            // is no longer locked by another process.
            try
            {
                using (FileStream inputStream = File.Open(sFilename, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    if (inputStream.Length > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
        }



        private void rssi_Tick(object sender, EventArgs e)
        {

        }



        private void runbat_Tick(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            var process = new Process { StartInfo = startInfo };

            process.Start();

            //process.StandardInput.WriteLine(" cd C:\\VisualStudio\\Builds\\GlassSurveyAlphaTest\\GlassSurveyAlphaTest\\bin\\Debug");
            //process.StandardInput.WriteLine(" adb devices");
            //process.StandardInput.WriteLine(" adb shell dumpsys wifi > rssiraw.txt");
            //process.StandardInput.WriteLine(" FINDSTR /L \"RSSI: \" rssiraw.txt > value.txt");
            //process.StandardInput.WriteLine(" for /f \"tokens = 5 delims =, \" %%a in (value.txt) do (echo %%a > rssi.txt)");
            //process.StandardInput.WriteLine(" for /f \"tokens = 6 delims =, \" %%a in (value.txt) do (echo %%a > linkspeed.txt)");

            process.StandardInput.WriteLine(" start /b rssi.bat ");

            if (new FileInfo("rssiraw.txt").Length == 0)
            {


                System.IO.File.WriteAllText(@"ssid.txt", "Glass USB Disconnected     ");
                System.IO.File.WriteAllText(@"channel.txt", "Glass USB Disconnected     ");
                System.IO.File.WriteAllText(@"bssid.txt", "Glass USB Disconnected     ");
                System.IO.File.WriteAllText(@"rssi.txt", "Glass USB Disconnected     ");
                System.IO.File.WriteAllText(@"linkspeed.txt", "Glass USB Disconnected     ");
                tb_status.Text = "Glass USB Disconnected";
                tb_status.ForeColor = Color.Black;
                tb_ssid.Text = File.ReadAllText(openFile_ssid.FileName);
                tb_channel.Text = File.ReadAllText(openFile_channel.FileName);
                tb_bssid.Text = File.ReadAllText(openFile_bssid.FileName);
                tb_rssi.Text = File.ReadAllText(openFile_rssi.FileName);
                tb_linkspeed.Text = File.ReadAllText(openFile_linkspeed.FileName);
            }

            if (tb_bssid.Text.Contains("Starting WiFi Scanning"))
            {

                tb_status.Text = "Starting WiFi Scanning...";
                tb_status.ForeColor = Color.Black;
                tb_ssid.Text = File.ReadAllText(openFile_ssid.FileName);
                tb_channel.Text = File.ReadAllText(openFile_channel.FileName);
                tb_bssid.Text = File.ReadAllText(openFile_bssid.FileName);
                tb_rssi.Text = File.ReadAllText(openFile_rssi.FileName);
                tb_linkspeed.Text = File.ReadAllText(openFile_linkspeed.FileName);
            }


            else
            {
                tb_ssid.Text = File.ReadAllText(openFile_ssid.FileName);
                tb_channel.Text = File.ReadAllText(openFile_channel.FileName);
                tb_bssid.Text = File.ReadAllText(openFile_bssid.FileName);
                tb_rssi.Text = File.ReadAllText(openFile_rssi.FileName);
                tb_linkspeed.Text = File.ReadAllText(openFile_linkspeed.FileName);

            }
            process.StandardInput.WriteLine(" exit");

            process.WaitForExit();

        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Filename.Text))
            {

            l_FilenameError.Visible = false;
            System.IO.File.WriteAllText(@"Test1.csv", string.Empty);
            File.AppendAllText(@"Test1.csv", "Timestamp,");
            File.AppendAllText(@"Test1.csv", "BSSID,");
            File.AppendAllText(@"Test1.csv", "Channel,");
            File.AppendAllText(@"Test1.csv", "DataRate,");
            File.AppendAllText(@"Test1.csv", "RSSI\r\n");
            //File.AppendAllText(@"Test1.csv", "Channel,");
            //File.AppendAllText(@"Test1.csv", "SSID\r\n");
            t_Csv.Enabled = true;
            runbat.Enabled = true;
            sw1.Start();
            sw.Enabled = true;
            tb_roamcount.Text = "0";
            tb_disconnections.Text = "0";
            b_start.Enabled = false;
            tb_status.Text = "Starting WiFi Scanning...";
            //System.IO.File.WriteAllText(@"rssiraw.txt", "Starting WiFi Scanning");
            //System.IO.File.WriteAllText(@"ssid.txt", "Starting WiFi Scanning");
            //System.IO.File.WriteAllText(@"channel.txt", "Starting WiFi Scanning");
            //System.IO.File.WriteAllText(@"bssid.txt", "Starting WiFi Scanning");
            //System.IO.File.WriteAllText(@"rssi.txt", "Starting WiFi Scanning");
            //System.IO.File.WriteAllText(@"linkspeed.txt", "Starting WiFi Scanning");
            }

            else
            {
                l_FilenameError.Visible = true;
            }
        }






private void b_stop_Click(object sender, EventArgs e)
        {

            t_Csv.Enabled = false;
            runbat.Enabled = false;
            sw1.Stop();
            sw.Enabled = false;
            b_start.Enabled = true;
            b_Tools.Enabled = true;
            tb_ssid.Text = "";
            tb_channel.Text = "";
            tb_bssid.Text = "";
            tb_bssidcount.Text = "";
            tb_rssi.Text = "";
            tb_linkspeed.Text = "";
            tb_roamcount.Text = "0";
           // tb_disconnections.Text = "0";
            int disconnects = Convert.ToInt32(tb_disconnections.Text);
            tb_disconnections.Text = (disconnects - disconnects).ToString();
            tb_status.Text = "Tap Start Scanning With Glass Connected and the Screen On";
            tb_status.ForeColor = Color.Black;







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



        private void tb_bssid_TextChanged(object sender, EventArgs e)
        {

            if (tb_bssid.Text.Contains("00:00:00:00:00"))
            {
                tb_status.Text = "Disconnected From WiFi!";

                tb_status.ForeColor = Color.Red;

                int disconnects = Convert.ToInt32(tb_disconnections.Text);
                tb_disconnections.Text = (disconnects + 1).ToString();

            }
            else if (tb_bssid.Text.Contains("USB") || tb_bssid.Text.Contains("<none>") || tb_bssid.Text.Contains("Starting WiFi Scanning"))
            {

            }
            else
            {
                tb_bssidcount.AppendText(tb_bssid.Text);
                var var_lines = tb_bssidcount.Lines.Where(line => !String.IsNullOrWhiteSpace(line)).Count();
                string string_lines = var_lines.ToString();
                tb_roamcount.Text = string_lines;

            }
        }










        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tb_bssidcount_TextChanged(object sender, EventArgs e)
        {
            tb_bssidcount.ScrollToCaret();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            sw1.Reset();
            tb_duration.Text = "00:00:00:00";
        }

        private void tb_channel_TextChanged(object sender, EventArgs e)
        {
            if (tb_channel.Text.Contains("2412"))
            {
                tb_channel.Text = "1 (2.4 Ghz)";
            }

            if (tb_channel.Text.Contains("2437"))
            {
                tb_channel.Text = "6 (2.4 Ghz)";
            }

            if (tb_channel.Text.Contains("2462"))
            {
                tb_channel.Text = "11 (2.4 Ghz)";
            }

            if (tb_channel.Text.Contains("5180"))
            {
                tb_channel.Text = "36 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5190"))
            {
                tb_channel.Text = "38 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5200"))
            {
                tb_channel.Text = "40 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5210"))
            {
                tb_channel.Text = "42 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5220"))
            {
                tb_channel.Text = "44 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5230"))
            {
                tb_channel.Text = "46 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5240"))
            {
                tb_channel.Text = "48 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5250"))
            {
                tb_channel.Text = "50 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5260"))
            {
                tb_channel.Text = "52 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5270"))
            {
                tb_channel.Text = "54 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5280"))
            {
                tb_channel.Text = "56 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5290"))
            {
                tb_channel.Text = "58 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5300"))
            {
                tb_channel.Text = "60 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5310"))
            {
                tb_channel.Text = "62 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5320"))
            {
                tb_channel.Text = "64 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5500"))
            {
                tb_channel.Text = "100 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5510"))
            {
                tb_channel.Text = "102 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5520"))
            {
                tb_channel.Text = "104 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5530"))
            {
                tb_channel.Text = "106 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5540"))
            {
                tb_channel.Text = "108 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5550"))
            {
                tb_channel.Text = "110 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5560"))
            {
                tb_channel.Text = "112 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5570"))
            {
                tb_channel.Text = "114 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5580"))
            {
                tb_channel.Text = "116 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5590"))
            {
                tb_channel.Text = "118 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5600"))
            {
                tb_channel.Text = "120 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5610"))
            {
                tb_channel.Text = "122 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5620"))
            {
                tb_channel.Text = "124 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5630"))
            {
                tb_channel.Text = "126 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5640"))
            {
                tb_channel.Text = "128 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5660"))
            {
                tb_channel.Text = "132 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5670"))
            {
                tb_channel.Text = "134 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5680"))
            {
                tb_channel.Text = "136 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5690"))
            {
                tb_channel.Text = "138 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5700"))
            {
                tb_channel.Text = "140 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5710"))
            {
                tb_channel.Text = "142 (5 Ghz DFS)";
            }

            if (tb_channel.Text.Contains("5745"))
            {
                tb_channel.Text = "149 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5755"))
            {
                tb_channel.Text = "151 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5765"))
            {
                tb_channel.Text = "153 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5775"))
            {
                tb_channel.Text = "155 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5785"))
            {
                tb_channel.Text = "157 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5795"))
            {
                tb_channel.Text = "159 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5805"))
            {
                tb_channel.Text = "161 (5 Ghz)";
            }

            if (tb_channel.Text.Contains("5825 "))
            {
                tb_channel.Text = "165 (5 Ghz)";
            }

        }


        int i = 1;
        private void tb_ssid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_rssi_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(tb_rssi.Text, out value))
            {
                if (value >= -90 && value <= -75)
                {
                    tb_rssi.BackColor = Color.Red;
                    tb_rssi.ForeColor = Color.White;
                    tb_status.Text = "Very Poor Signal";
                    tb_status.ForeColor = Color.Red;

                }
                if (value >= -74 && value <= -68)
                {
                    tb_rssi.BackColor = Color.Orange;
                    tb_rssi.ForeColor = Color.White;
                    tb_status.Text = "Poor Signal";
                    tb_status.ForeColor = Color.Orange;

                }
                if (value >= -67 && value <= -62)
                {
                    tb_rssi.BackColor = Color.GreenYellow;
                    tb_rssi.ForeColor = Color.White;
                    tb_status.Text = "Good Signal";
                    tb_status.ForeColor = Color.GreenYellow;

                }
                if (value >= -61 && value <= -20)
                {
                    tb_rssi.BackColor = Color.Green;
                    tb_rssi.ForeColor = Color.White;
                    tb_status.Text = "Excellent Signal";
                    tb_status.ForeColor = Color.Green;

                }
            }
            else
            {
                tb_rssi.BackColor = Color.White;
                tb_rssi.ForeColor = Color.Black;
            }
        }

        private void b_Scan_Click(object sender, EventArgs e)
        {
            p_ScanTool.Visible = true;
            p_Tools.Visible = false;
            p_Help.Visible = false;
            b_Help.Enabled = true;
            b_Tools.Enabled = true;
            b_Scan.Enabled = false;
        }

        private void b_Tools_Click(object sender, EventArgs e)
        {
            p_Tools.Visible = true;
            p_ScanTool.Visible = false;
            p_Help.Visible = false;
            b_Help.Enabled = true;
            b_Scan.Enabled = true;
            b_Tools.Enabled = false;

        }

        private void b_5ghz_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false,
            };

            var process = new Process { StartInfo = startInfo };

            process.Start();
            process.StandardInput.WriteLine(" cd c:\\bat ");
            process.StandardInput.WriteLine(" start 5Ghz.bat ");
            process.StandardInput.WriteLine(" exit");

            process.WaitForExit();

        }

        private void b_24ghz_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false,
            };

            var process = new Process { StartInfo = startInfo };

            process.Start();
            process.StandardInput.WriteLine(" cd c:\\bat ");
            process.StandardInput.WriteLine(" start 2_4Ghz.bat ");
            process.StandardInput.WriteLine(" exit");

            process.WaitForExit();
        }

        private void b_Logs_Click(object sender, EventArgs e)
        {

            



            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false,
            };

        var process = new Process { StartInfo = startInfo };

        process.Start();
            process.StandardInput.WriteLine(" cd c:\\bat ");
            process.StandardInput.WriteLine(" start grablogs.bat ");
            process.StandardInput.WriteLine(" exit");
            //
            process.WaitForExit();
        }

        private void b_Help_Click(object sender, EventArgs e)
        {
            p_ScanTool.Visible = false;
            p_Tools.Visible = false;
            p_Help.Visible = true;
            b_Help.Enabled = false;
            b_Tools.Enabled = true;
            b_Scan.Enabled = true;
        }

        private void b_Logs2_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false,
            };

            var process = new Process { StartInfo = startInfo };

            process.Start();
            process.StandardInput.WriteLine(" cd c:\\bat ");
            process.StandardInput.WriteLine(" start grablogs.bat ");
            process.StandardInput.WriteLine(" exit");
            //
            process.WaitForExit();
        }

        private void t_Csv_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now; 
            string s = dt.ToString("yyyy/MM/dd - HH:mm:ss:fff");


            string duration = tb_duration.Text;
            string bssid = tb_bssid.Text;
            string bssid2 = bssid.Substring(0, 17);
            string rssi = tb_rssi.Text;
            string rssi2 = rssi.Substring(0, 5  );
            string channel = tb_channel.Text;
            string linkspeed = tb_linkspeed.Text;
            string linkspeed2 = linkspeed.Substring(0,4);
            File.AppendAllText(@"Test1.csv", (s) + ",");
            File.AppendAllText(@"Test1.csv", (bssid2) + ",");
            File.AppendAllText(@"Test1.csv", (channel) + ",");
            File.AppendAllText(@"Test1.csv", (linkspeed2) + ",");
            File.AppendAllText(@"Test1.csv", (rssi) + "\r\n");

        }

        private void b_stopsave_Click(object sender, EventArgs e)
        {

            t_Csv.Enabled = false;
            runbat.Enabled = false;
            sw1.Stop();
            sw.Enabled = false;
            b_start.Enabled = true;
            b_Tools.Enabled = true;
            tb_ssid.Text = "";
            tb_channel.Text = "";
            tb_bssid.Text = "";
            tb_bssidcount.Text = "";
            tb_rssi.Text = "";
            tb_linkspeed.Text = "";
            tb_roamcount.Text = "0";
            // tb_disconnections.Text = "0";
            int disconnects = Convert.ToInt32(tb_disconnections.Text);
            tb_disconnections.Text = (disconnects - disconnects).ToString();
            tb_status.Text = "Tap Start Scanning With Glass Connected and the Screen On";
            tb_status.ForeColor = Color.Black;


        }
    }
    }
        



