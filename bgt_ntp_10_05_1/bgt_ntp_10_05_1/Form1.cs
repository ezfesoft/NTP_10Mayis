using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntp_10_05_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txt_adres.Text);
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_gecmis_git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(listBox1.SelectedItem.ToString());
        }
    }
}
