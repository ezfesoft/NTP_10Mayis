namespace bgt_ntp_10_05_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.cmDuzen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.AnaMenu.SuspendLayout();
            this.cmDuzen.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenu
            // 
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuCikis});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(800, 24);
            this.AnaMenu.TabIndex = 0;
            this.AnaMenu.Text = "AnaMenu";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuAc,
            this.menuKaydet,
            this.menuYazdir});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuDuzen
            // 
            this.menuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKes,
            this.menuKopyala,
            this.menuYapistir});
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(52, 20);
            this.menuDuzen.Text = "Düzen";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuCikis.Size = new System.Drawing.Size(44, 20);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // menuYeni
            // 
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuYeni.Size = new System.Drawing.Size(180, 22);
            this.menuYeni.Text = "Yeni";
            this.menuYeni.Click += new System.EventHandler(this.menuYeni_Click);
            // 
            // menuAc
            // 
            this.menuAc.Name = "menuAc";
            this.menuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuAc.Size = new System.Drawing.Size(180, 22);
            this.menuAc.Text = "Aç";
            this.menuAc.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(180, 22);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // menuYazdir
            // 
            this.menuYazdir.Name = "menuYazdir";
            this.menuYazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuYazdir.Size = new System.Drawing.Size(180, 22);
            this.menuYazdir.Text = "Yazdır";
            this.menuYazdir.Click += new System.EventHandler(this.menuYazdir_Click);
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(180, 22);
            this.menuKes.Text = "Kes";
            this.menuKes.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopyala.Size = new System.Drawing.Size(180, 22);
            this.menuKopyala.Text = "Kopyala";
            this.menuKopyala.Click += new System.EventHandler(this.menuKopyala_Click);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(180, 22);
            this.menuYapistir.Text = "Yapıştır";
            this.menuYapistir.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.cmDuzen;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 24);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 426);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // cmDuzen
            // 
            this.cmDuzen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.cmDuzen.Name = "cmDuzen";
            this.cmDuzen.Size = new System.Drawing.Size(117, 70);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.menuKopyala_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.AnaMenu);
            this.MainMenuStrip = this.AnaMenu;
            this.Name = "Form1";
            this.Text = "Not Defteri - MenuStrip Uygulaması";
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.cmDuzen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuAc;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripMenuItem menuYazdir;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ContextMenuStrip cmDuzen;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument belge;
    }
}

