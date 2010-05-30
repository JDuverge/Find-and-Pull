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
    public partial class mainForm : Form
    {
        private ProcessStartInfo si;
        private bool firstTimeClose = true;
        private string saveLoc;
        private string findLoc;
        private int searchDate;
        private string searchType;
        private string[] locations;

        public mainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon1;
            saveLoc = Properties.Settings.Default.saveLocation;
            findLoc = Properties.Settings.Default.lastFindLocation;
            searchDate = Properties.Settings.Default.searchDate;
            searchType = Properties.Settings.Default.searchType;
            if (searchType.Equals("Files"))
            {
                searchType = "f";
            }
            else if (searchType.Equals("Directories"))
            {
                searchType = "d";
            }
            else
            {
                searchType = "f";
            }
            locations = new string[1000];
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void mainForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = .5;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Preferences prefs = new Preferences())
            {
                prefs.ShowDialog();
                saveLoc = prefs.SaveLocation;
                findLoc = prefs.LastFindLocation;
                searchDate = prefs.SearchDate;
                searchType = prefs.SearchType;
            }
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Changelog change = new Changelog())
            {
                change.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstTimeClose)
            {
                firstTimeClose = false;
                DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exiting..?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes) Application.Exit();
                if (res == DialogResult.No) e.Cancel = true;
                firstTimeClose = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!textBoxSearch.Text.Trim().Equals(""))
            {
                int items = findInstances();
                if (items <= 0)
                {
                    //No instances found :(
                    checkedListBoxLocations.Visible = false;
                    buttonPull.Visible = false;
                    buttonSearch2.Visible = false;
                    textBoxSearch2.Visible = false;
                    labelSearch2.Visible = false;
                    if(items == 0) MessageBox.Show("No instances of your search text were found in specified location", "Sorry! :(");
                    textBoxSearch.Focus();
                }
                else
                {
                    checkedListBoxLocations.Visible = true;
                    buttonPull.Visible = true;
                    buttonSearch2.Visible = true;
                    textBoxSearch2.Visible = true;
                    labelSearch2.Visible = true;
                    addToCheckedListBox(items);
                }
            }
            else
            {
                MessageBox.Show("Nothing to search...", "Sorry! :(");
                textBoxSearch.Focus();
            }     
        }

        private int findInstances()
        {
            string currentLine, searchString, sDate = "";
            string sIntro = "adb shell find " + findLoc;
            string sType = " -type " + searchType;
            string sSearch = " -name \'*" + textBoxSearch.Text.Trim()
                + "*\' -print";

            searchString = sIntro;
            if (this.searchDate == 0)
            {
                searchString += sType + sSearch;
            }
            else if(this.searchDate > 0)
            {
                sDate = " -mtime +" + searchDate;
                searchString += sType + sDate + sSearch;
            }
            else if (this.searchDate < 0)
            {
                sDate = " -mtime -" + Math.Abs(searchDate);
                searchString += sType + sDate + sSearch;
            }
            else
            {
                searchString += sType + sSearch;
            }

            int i = 0;
            bool unexpectedBreak = false;

            si = new ProcessStartInfo("cmd.exe");
            si.RedirectStandardInput = true;
            si.RedirectStandardOutput = true;
            si.RedirectStandardError = true;
            si.UseShellExecute = false;
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Hidden;

            Process console = Process.Start(si);

            this.toolStripStatusLabel1.Text = "Searching.....";

            console.StandardInput.WriteLine(searchString);
            console.StandardInput.WriteLine("exit");

            currentLine = console.StandardOutput.ReadLine();
            while (!currentLine.Contains(textBoxSearch.Text.Trim()))
            {
                currentLine = console.StandardOutput.ReadLine();
            }
            currentLine = console.StandardOutput.ReadLine();
            
            while (!console.StandardOutput.EndOfStream)
            {
                try
                {
                    if (!currentLine.Trim().Equals(""))
                    {
                        locations[i++] = currentLine;
                    }
                    currentLine = console.StandardOutput.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Too many results were found. Please try again with more specific search.",
                        "Sorry For The Inconvenience...");
                    unexpectedBreak = true;
                    return -1;
                }
            }

            while (!console.HasExited && !unexpectedBreak) { }
            this.toolStripStatusLabel1.Text = "Done searching!";

            return i;
        }

        private void addToCheckedListBox(int items)
        {
            checkedListBoxLocations.Items.Clear();
            for (int i = 0; i < items; i++)
            {
                checkedListBoxLocations.Items.Add(locations[i]);
            }
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            string searchString = "";

            si = new ProcessStartInfo("cmd.exe");
            si.RedirectStandardInput = true;
            si.RedirectStandardOutput = true;
            si.RedirectStandardError = true;
            si.UseShellExecute = false;
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Hidden;

            Process console = Process.Start(si);

            this.toolStripStatusLabel1.Text = "WARNING: disconnecting device from USB will stop the pulling process!!";

            for (int i = 0; i < checkedListBoxLocations.CheckedItems.Count; i++)
            {
                searchString = "adb pull \"" + checkedListBoxLocations.CheckedItems[i]
                    + "\" \"" + saveLoc + "\"";
                console.StandardInput.WriteLine(searchString);
            }
            console.StandardInput.WriteLine("exit");
           
            while (!console.HasExited){} //Wait for all files to be pulled!
            this.toolStripStatusLabel1.Text = "It is now ok to disconnect device from USB.";
        }

        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            int count = checkedListBoxLocations.Items.Count;
            int i = 0;
            string[] newLoc = new string[count];

            for (int j = 0; j < count; j++)
            {
                string currentLine = (string)checkedListBoxLocations.Items[j];
                if(currentLine.Contains(textBoxSearch2.Text))
                {
                    newLoc[i++] = currentLine;
                }
            }

            if (newLoc.Length == 0)
            {
                MessageBox.Show("No instances of your search text were found within search results", "Sorry! :(");
            }
            else //Found within results
            {
                checkedListBoxLocations.Items.Clear();
                for (int i2 = 0; i2 < newLoc.Length; i2++)
                {
                    try
                    {
                        if(newLoc[i2] == null)
                        {
                            //Since newLoc isn't dynamic, all the empty
                            //slots will be null, so once we reach first null
                            //we're done
                            break;
                        }
                        checkedListBoxLocations.Items.Add(newLoc[i2]);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            this.textBoxSearch2.Focus();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxSearch.Clear();
            this.textBoxSearch2.Clear();
            this.checkedListBoxLocations.Items.Clear();
            this.labelSearch2.Visible = false;
            this.textBoxSearch2.Visible = false;
            this.buttonPull.Visible = false;
            this.checkedListBoxLocations.Visible = false;
            this.buttonSearch2.Visible = false;
            this.toolStripStatusLabel1.Text = "";
        }
    }
}
