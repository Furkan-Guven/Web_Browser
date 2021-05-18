namespace tarayici
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDur = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAra = new System.Windows.Forms.ToolStripButton();
            this.btnGit = new System.Windows.Forms.ToolStripButton();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyar = new System.Windows.Forms.ToolStripSplitButton();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnAnaSayfa = new System.Windows.Forms.ToolStripButton();
            this.btnYenile = new System.Windows.Forms.ToolStripButton();
            this.lblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGeri = new System.Windows.Forms.ToolStripButton();
            this.btnİleri = new System.Windows.Forms.ToolStripButton();
            this.btnEkle = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.furkanGüvenTarafındanYazıldıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDur
            // 
            this.btnDur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDur.Image = global::tarayici.Properties.Resources._109_AllAnnotations_Error_16x16_72;
            this.btnDur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(23, 22);
            this.btnDur.Text = "Dur";
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(628, 222);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("https://www.google.com.tr/", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // btnAra
            // 
            this.btnAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = global::tarayici.Properties.Resources.search_glyph;
            this.btnAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(23, 22);
            this.btnAra.Text = "Arama";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGit
            // 
            this.btnGit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGit.Image = global::tarayici.Properties.Resources.Go;
            this.btnGit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(23, 22);
            this.btnGit.Text = "Git";
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furkanGüvenTarafındanYazıldıToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAyar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.btnAyar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyar.Image = global::tarayici.Properties.Resources.settings_16;
            this.btnAyar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(32, 22);
            this.btnAyar.Text = "Ayarlar";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // txtUrl
            // 
            this.txtUrl.AutoSize = false;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 25);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Image = global::tarayici.Properties.Resources.HomeHS;
            this.btnAnaSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(23, 22);
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Image = global::tarayici.Properties.Resources._112_RefreshArrow_Blue_16x16_72;
            this.btnYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(23, 22);
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(511, 21);
            this.lblDurum.Spring = true;
            this.lblDurum.Text = "...";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 20);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGeri,
            this.btnİleri,
            this.btnYenile,
            this.btnAnaSayfa,
            this.txtUrl,
            this.btnGit,
            this.btnDur,
            this.btnAra,
            this.btnAyar,
            this.btnEkle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGeri
            // 
            this.btnGeri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = global::tarayici.Properties.Resources.Back;
            this.btnGeri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(23, 22);
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnİleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.Image = global::tarayici.Properties.Resources.forward;
            this.btnİleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(23, 22);
            this.btnİleri.Text = "İleri";
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEkle.Image = global::tarayici.Properties.Resources.FavoriteStar_16x16;
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(32, 22);
            this.btnEkle.Text = "Sık Kullanılanlara Ekle";
            this.btnEkle.ButtonClick += new System.EventHandler(this.btnEkle_ButtonClick);
            this.btnEkle.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnEkle_DropDownItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDurum,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 247);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // furkanGüvenTarafındanYazıldıToolStripMenuItem
            // 
            this.furkanGüvenTarafındanYazıldıToolStripMenuItem.Name = "furkanGüvenTarafındanYazıldıToolStripMenuItem";
            this.furkanGüvenTarafındanYazıldıToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.furkanGüvenTarafındanYazıldıToolStripMenuItem.Text = "Furkan Güven Tarafından Yazıldı.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 273);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Furkan Güven İnternet Tarayıcısı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnDur;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton btnAra;
        private System.Windows.Forms.ToolStripButton btnGit;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton btnAyar;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton btnAnaSayfa;
        private System.Windows.Forms.ToolStripButton btnYenile;
        private System.Windows.Forms.ToolStripStatusLabel lblDurum;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGeri;
        private System.Windows.Forms.ToolStripButton btnİleri;
        private System.Windows.Forms.ToolStripSplitButton btnEkle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem furkanGüvenTarafındanYazıldıToolStripMenuItem;
    }
}

