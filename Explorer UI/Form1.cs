﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    tbPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void btForward_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
