using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkvertiseBypass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetURL_Click(object sender, EventArgs e)
        {
            try
            {
                if (Input.Text != "" && Input.Text.IndexOf("link-to") != -1 && Input.Text.IndexOf("http") != -1)
                {
                    do_it(Input.Text);
                }
                else if (Input.Text != "" && Input.Text.IndexOf("direct-link") != -1 && Input.Text.IndexOf("http") != -1)
                {
                    do_it(Input.Text);
                }
                else if (Input.Text != "" && Input.Text.IndexOf("linkvertise") != -1 && Input.Text.IndexOf("http") != -1)
                {
                    do_it(Input.Text);
                }
                else if (Input.Text != "" && Input.Text.IndexOf("up-to-down") != -1 && Input.Text.IndexOf("http") != -1)
                {
                    do_it(Input.Text);
                }
                else
                {
                    ResultBox.Text = "\n\nMissing URL";
                }
            }
            catch (Exception) { ResultBox.Text = "\n\nError"; }
        }

        void do_it(string getLink)
        {
            string url = getLink;
            url = "_YOUR_API_URL_HERE_" + url;

            Wait.Enabled = true;
            Wait.MarqueeAnimationSpeed = 10;
            loadingGIF.Visible = true;
            GetURL.Enabled = false;
            ResultBox.Text = "";
            System.Net.WebClient wc = new System.Net.WebClient();
            try
            {
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);
                wc.DownloadStringAsync(new Uri(url));
            }
            catch (Exception) 
            {
                ResultBox.Text = "\n\nError";
                Wait.MarqueeAnimationSpeed = 0;
                Wait.Enabled = false;
                loadingGIF.Visible = false;
            }
        }

        string resultURL = "Error";

        void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                ResultBox.Text = "\n\n" + e.Result;
                resultURL = e.Result;
            }
            catch(Exception)
            {
                ResultBox.Text = "\n\nError";
                resultURL = "Error";
            }
            GetURL.Enabled = true;
            Wait.MarqueeAnimationSpeed = 0;
            Wait.Enabled = false;
            loadingGIF.Visible = false;
        }

        private void CopyURL_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(resultURL);
            }
            catch (Exception) { }
            label3.Focus();
        }

        private void PasteURL_Click(object sender, EventArgs e)
        {
            try
            {
                Input.Text = Clipboard.GetText();
                PasteURL.Text = Clipboard.GetText();
            }
            catch (Exception) { }
            label3.Focus();
        }

        private void ResultBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(resultURL);
            }
            catch (Exception) { }
            label3.Focus();
        }

        private void ResultBox_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Focus();
        }
    }
}
