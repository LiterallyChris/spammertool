using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spammer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            if (webClient.DownloadString("https://raw.githubusercontent.com/LiterallyChris/spammertool/main/version.txt").Contains("1.1"))
            {
                if (MessageBox.Show("Looks like theres an update, would you like to download it?", "Spammer Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://github.com/LiterallyChris/spammertool/releases");
                }
                else
                {

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/LiterallyChris/spammertool");
        }
    }
}
