namespace EmlakOtomasyonManisa
{
    partial class carileriGoruntule
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_yas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_tel1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_tel2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_not = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_hizliArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.context_sagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcariNotu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.context_sagTikMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ID,
            this.column_Ad,
            this.column_yas,
            this.column_tel1,
            this.column_tel2,
            this.column_not});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // column_ID
            // 
            this.column_ID.Text = "Cari ID";
            // 
            // column_Ad
            // 
            this.column_Ad.Text = "Ad Soyad";
            this.column_Ad.Width = 200;
            // 
            // column_yas
            // 
            this.column_yas.Text = "Yaş";
            // 
            // column_tel1
            // 
            this.column_tel1.Text = "Telefon 1";
            this.column_tel1.Width = 150;
            // 
            // column_tel2
            // 
            this.column_tel2.Text = "Telefon 2";
            this.column_tel2.Width = 150;
            // 
            // column_not
            // 
            this.column_not.Text = "Not";
            this.column_not.Width = 250;
            // 
            // txt_hizliArama
            // 
            this.txt_hizliArama.Location = new System.Drawing.Point(488, 12);
            this.txt_hizliArama.Name = "txt_hizliArama";
            this.txt_hizliArama.Size = new System.Drawing.Size(321, 20);
            this.txt_hizliArama.TabIndex = 1;
            this.txt_hizliArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara :";
            // 
            // context_sagTikMenu
            // 
            this.context_sagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.context_sagTikMenu.Name = "context_sagTikMenu";
            this.context_sagTikMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::EmlakOtomasyonManisa.Properties.Resources._1457253137_custom_reports;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::EmlakOtomasyonManisa.Properties.Resources._1490190926_f_cross_2561;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // carilerBindingSource
            // 
            this.carilerBindingSource.DataSource = typeof(EmlakOtomasyonManisa.cariler);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.carilerBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(13, 453);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 200);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colad,
            this.colyas,
            this.coltel1,
            this.coltel2,
            this.colcariNotu});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colid
            // 
            this.colid.FieldName = "ID";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 47;
            // 
            // colad
            // 
            this.colad.FieldName = "Ad Soyad";
            this.colad.Name = "colad";
            this.colad.Visible = true;
            this.colad.VisibleIndex = 1;
            this.colad.Width = 121;
            // 
            // colyas
            // 
            this.colyas.FieldName = "Yaş";
            this.colyas.Name = "colyas";
            this.colyas.Visible = true;
            this.colyas.VisibleIndex = 2;
            this.colyas.Width = 121;
            // 
            // coltel1
            // 
            this.coltel1.FieldName = "Telefon 1";
            this.coltel1.Name = "coltel1";
            this.coltel1.Visible = true;
            this.coltel1.VisibleIndex = 3;
            this.coltel1.Width = 121;
            // 
            // coltel2
            // 
            this.coltel2.FieldName = "Telefon 2";
            this.coltel2.Name = "coltel2";
            this.coltel2.Visible = true;
            this.coltel2.VisibleIndex = 4;
            this.coltel2.Width = 121;
            // 
            // colcariNotu
            // 
            this.colcariNotu.FieldName = "Not";
            this.colcariNotu.Name = "colcariNotu";
            this.colcariNotu.Visible = true;
            this.colcariNotu.VisibleIndex = 5;
            this.colcariNotu.Width = 126;
            // 
            // carileriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(821, 674);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hizliArama);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "carileriGoruntule";
            this.Text = "Carileri Listele";
            this.Load += new System.EventHandler(this.carileriGoruntule_Load);
            this.LocationChanged += new System.EventHandler(this.carileriGoruntule_LocationChanged);
            this.context_sagTikMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader column_ID;
        private System.Windows.Forms.ColumnHeader column_Ad;
        private System.Windows.Forms.ColumnHeader column_yas;
        private System.Windows.Forms.ColumnHeader column_tel1;
        private System.Windows.Forms.ColumnHeader column_tel2;
        private System.Windows.Forms.ColumnHeader column_not;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_hizliArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip context_sagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.BindingSource carilerBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colad;
        private DevExpress.XtraGrid.Columns.GridColumn colyas;
        private DevExpress.XtraGrid.Columns.GridColumn coltel1;
        private DevExpress.XtraGrid.Columns.GridColumn coltel2;
        private DevExpress.XtraGrid.Columns.GridColumn colcariNotu;
    }
}