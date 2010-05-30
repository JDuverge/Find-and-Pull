using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections.ObjectModel;

namespace FindAndPull
{
    public partial class Check : Form
    {
        private ProcessStartInfo si;
        bool deviceFound;

        public Check()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon1;
            this.textBoxDevices.Clear();
            string currentLine = "";
            DeviceFound = false;

            si = new ProcessStartInfo("cmd.exe");
            si.RedirectStandardInput = true;
            si.RedirectStandardOutput = true;
            si.RedirectStandardError = true;
            si.UseShellExecute = false;
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Hidden;

            Process console = Process.Start(si);
            console.StandardInput.WriteLine("adb devices");
            console.StandardInput.WriteLine("exit");

            currentLine = console.StandardOutput.ReadLine();
            while (!currentLine.Contains("List of devices"))
            {
                currentLine = console.StandardOutput.ReadLine();
            }
            currentLine = console.StandardOutput.ReadLine();
            console.WaitForExit();

            this.textBoxDevices.Text = currentLine;

            if (this.textBoxDevices.Text.Trim().Equals(""))
            {
                this.textBoxDevices.Text = "No Devices Found!";
                this.DeviceFound = false;
            }
            else if (this.textBoxDevices.Text.Trim().Contains("device"))
            {
                this.DeviceFound = true;
            }

            if (this.DeviceFound)
            {
                this.DialogResult = DialogResult.Yes;
            }
            //Have to fix so don't need check 
            //screen if program finds device
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private bool DeviceFound
        {
            get { return deviceFound; }
            set { deviceFound = value; }
        }
    }
}
