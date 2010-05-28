using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FindAndPull
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Process.Start(linkWebsite.Text, null);
            }
            else if (e.Button == MouseButtons.Right)
            {
                string message =
                    "Left Click link to display: " +
                    linkWebsite.Text;
                MessageBox.Show(message, "Go To Site...");
            }
        }
    }
}
