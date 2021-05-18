using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tarayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUrl.Width = this.Width - 270;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txtUrl.Width = this.Width - 270;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void btnEkle_ButtonClick(object sender, EventArgs e)
        {
            btnEkle.DropDown.Items.Add(txtUrl.Text);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Value = 10;
            lblDurum.Text = e.Url.ToString() + " yükleniyor...";
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 0;
            lblDurum.Text = "";
            txtUrl.Text = e.Url.ToString();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Control)
                    txtUrl.Text = "http://www." + txtUrl.Text + ".com";
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void btnEkle_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtUrl.Text = e.ClickedItem.Text;
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
