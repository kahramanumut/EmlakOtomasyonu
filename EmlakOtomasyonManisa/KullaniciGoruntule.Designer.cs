namespace EmlakOtomasyonManisa
{
    partial class KullaniciGoruntule
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
            this.components = new System.ComponentModel.Container();
            this.kullaniciView = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSonGiris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGirisSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYetki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeniKullaniciEkle = new System.Windows.Forms.Button();
            this.context_sagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.context_sagTikMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciView
            // 
            this.kullaniciView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnAdSoyad,
            this.columnUsername,
            this.columnSonGiris,
            this.columnGirisSayisi,
            this.columnYetki});
            this.kullaniciView.FullRowSelect = true;
            this.kullaniciView.GridLines = true;
            this.kullaniciView.Location = new System.Drawing.Point(12, 12);
            this.kullaniciView.Name = "kullaniciView";
            this.kullaniciView.Size = new System.Drawing.Size(538, 187);
            this.kullaniciView.TabIndex = 0;
            this.kullaniciView.UseCompatibleStateImageBehavior = false;
            this.kullaniciView.View = System.Windows.Forms.View.Details;
            this.kullaniciView.DoubleClick += new System.EventHandler(this.kullaniciView_DoubleClick);
            this.kullaniciView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kullaniciView_MouseClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnAdSoyad
            // 
            this.columnAdSoyad.Text = "Ad Soyad";
            this.columnAdSoyad.Width = 150;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Kullanıcı adı";
            this.columnUsername.Width = 120;
            // 
            // columnSonGiris
            // 
            this.columnSonGiris.Text = "Son Giriş Tarihi";
            this.columnSonGiris.Width = 150;
            // 
            // columnGirisSayisi
            // 
            this.columnGirisSayisi.Text = "Giriş Sayısı";
            // 
            // columnYetki
            // 
            this.columnYetki.Text = "Yetki";
            this.columnYetki.Width = 80;
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(12, 203);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(538, 28);
            this.btnYeniKullaniciEkle.TabIndex = 2;
            this.btnYeniKullaniciEkle.Text = "Yeni kullanıcı ekle";
            this.btnYeniKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // context_sagTikMenu
            // 
            this.context_sagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.context_sagTikMenu.Name = "context_sagTikMenu";
            this.context_sagTikMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::EmlakOtomasyonManisa.Properties.Resources._1457253137_custom_reports;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::EmlakOtomasyonManisa.Properties.Resources._1490190926_f_cross_2561;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // KullaniciGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 235);
            this.Controls.Add(this.btnYeniKullaniciEkle);
            this.Controls.Add(this.kullaniciView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciGoruntule";
            this.Text = "Kullanıcıları görüntüle";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.LocationChanged += new System.EventHandler(this.Kullanici_LocationChanged);
            this.context_sagTikMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView kullaniciView;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.Button btnYeniKullaniciEkle;
        private System.Windows.Forms.ColumnHeader columnAdSoyad;
        private System.Windows.Forms.ColumnHeader columnSonGiris;
        private System.Windows.Forms.ColumnHeader columnGirisSayisi;
        private System.Windows.Forms.ColumnHeader columnYetki;
        private System.Windows.Forms.ContextMenuStrip context_sagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}