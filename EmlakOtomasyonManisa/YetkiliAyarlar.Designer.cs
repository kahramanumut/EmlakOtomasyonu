namespace EmlakOtomasyonManisa
{
    partial class YetkiliAyarlar
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
            this.checkBoxIsLogin = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxIsLogin
            // 
            this.checkBoxIsLogin.AutoSize = true;
            this.checkBoxIsLogin.Checked = true;
            this.checkBoxIsLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsLogin.Location = new System.Drawing.Point(12, 12);
            this.checkBoxIsLogin.Name = "checkBoxIsLogin";
            this.checkBoxIsLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsLogin.Size = new System.Drawing.Size(153, 17);
            this.checkBoxIsLogin.TabIndex = 1;
            this.checkBoxIsLogin.Text = "Kullanıcı adı ve şifreyle giriş";
            this.checkBoxIsLogin.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(13, 178);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 46);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(121, 178);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(83, 46);
            this.btnSifirla.TabIndex = 3;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // YetkiliAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(233, 244);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.checkBoxIsLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YetkiliAyarlar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.LocationChanged += new System.EventHandler(this.Ayarlar_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsLogin;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSifirla;
    }
}