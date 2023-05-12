using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntp_10_05_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuKes_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void menuKopyala_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void menuYapistir_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("MessageBox yazı kısmı","Bilgi Başlığı",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
            DialogResult cevap = MessageBox.Show("Dosyayı silmek istediğinizden emin misiniz?",
                "Dosya Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("Dosya Silindi");
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi!");
            }

        }

        private void menuKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            //sfd.Filter = "Text Dosyası |*.txt";
            sfd.Filter = "Text Dosyası |*.txt| Word Dosyası |*.docx | Tüm Dosyalar |*.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "Text Dosyası |*.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuYeni_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void menuYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtEditor.Text, txtEditor.Font, Brushes.Red, new Point(100, 100));
        }
    }
}
