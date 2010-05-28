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
    public partial class Preferences : Form
    {
        private bool goodToGo;
        private ProcessStartInfo si;
        private string errorMsg = "";

        public Preferences()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.comboBoxFind.Text = this.LastFindLocation;
            this.textBoxSave.Text = this.SaveLocation;
        }

        public String SaveLocation
        {
            get { return Properties.Settings.Default.saveLocation; }
            set 
            { 
                Properties.Settings.Default.saveLocation = value;
                Properties.Settings.Default.Save();
            }
        }

        public String LastFindLocation
        {
            get { return Properties.Settings.Default.lastFindLocation; }
            set 
            { 
                Properties.Settings.Default.lastFindLocation = value;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonFileBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSave.ShowDialog();
            if (folderBrowserDialogSave.SelectedPath.Equals(""))
            {
                textBoxSave.Text = SaveLocation;
            }
            else
            {
                textBoxSave.Text = folderBrowserDialogSave.SelectedPath;
            }
        }

        private void buttonOK_Validating(object sender, CancelEventArgs e)
        {
            if (checkFindTextBox())
            {
                this.errorProvider.SetError(comboBoxFind, errorMsg);
                goodToGo = true;
            }
            else
            {
                this.errorProvider.SetError(comboBoxFind, errorMsg);
                goodToGo = false;
            }
        }

        private bool checkFindTextBox()
        {
            string currentLine;

            si = new ProcessStartInfo("cmd.exe");
            si.RedirectStandardInput = true;
            si.RedirectStandardOutput = true;
            si.RedirectStandardError = true;
            si.UseShellExecute = false;
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Hidden;

            Process console = Process.Start(si);
            console.StandardInput.WriteLine("adb shell ls " + comboBoxFind.Text);
            console.StandardInput.WriteLine("exit");

            currentLine = console.StandardOutput.ReadLine();
            while (!currentLine.Contains(comboBoxFind.Text))
            {
                currentLine = console.StandardOutput.ReadLine();
            }
            currentLine = console.StandardOutput.ReadLine();

            if (currentLine.Contains("No such file or directory"))
            {
                errorMsg = "Please make sure path is in correct Linux format or that the path exists!";
                return false;
            }
            if (currentLine.Contains("permission denied"))
            {
                errorMsg = "Please make sure that you have permission to enter path!";
                return false; 
            }
            if(currentLine.Length == 0)
            {
                errorMsg = "Directory is empty. Please choose directory with files to search through.";
                return false;
            }

            errorMsg = "";
            return true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (goodToGo)
            {
                SaveLocation = this.textBoxSave.Text;
                LastFindLocation = this.comboBoxFind.Text;
                this.DialogResult = DialogResult.OK;
                //MessageBox.Show(SaveLocation + " " + LastFindLocation);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.textBoxSave.Text = SaveLocation;
            this.comboBoxFind.Text = LastFindLocation;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //MessageBox.Show(SaveLocation + " " + LastFindLocation);
        }

        /*private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            if (checkFindTextBox())
            {
                this.errorProvider.SetError(comboBoxFind, errorMsg);
            }
            else
            {
                this.errorProvider.SetError(comboBoxFind, errorMsg);
            }
        }*/
    }
}
