using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntp_10_05_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";

                txtBilgi.Text += "---------------\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 35;
                    txtBilgi.Text += "Çorba " + (nCorba.Value * 35) + "₺ \r\n";
                }
                if (nSalata.Value > 0)
                {
                    hesap += nSalata.Value * 10;
                    txtBilgi.Text += "Salata " + (nSalata.Value * 10) + "₺ \r\n";
                }
                if (nAnaYemek.Value > 0)
                {
                    hesap += nAnaYemek.Value * 80;
                    txtBilgi.Text += "Ana Yemek " + (nAnaYemek.Value * 80) + "₺ \r\n";
                }
                if (nTatli.Value > 0)
                {
                    hesap += nTatli.Value * 30;
                    txtBilgi.Text += "Tatlı " + (nTatli.Value * 30) + "₺ \r\n";
                }
                txtBilgi.Text += "---------------\r\n";
                txtBilgi.Text += "Toplam: " + hesap + "₺";
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }
    }
}
