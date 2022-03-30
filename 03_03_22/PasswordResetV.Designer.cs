namespace _03_03_22
{
    partial class PasswordResetV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetV));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnKullaniciKontrol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre Tekrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Enabled = false;
            this.txtSifre.Location = new System.Drawing.Point(111, 108);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(153, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(111, 27);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(153, 20);
            this.txtKullanici.TabIndex = 0;
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Enabled = false;
            this.btnSifreGuncelle.Location = new System.Drawing.Point(111, 166);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(153, 41);
            this.btnSifreGuncelle.TabIndex = 3;
            this.btnSifreGuncelle.Text = "Şifre Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Enabled = false;
            this.txtSifreTekrar.Location = new System.Drawing.Point(111, 134);
            this.txtSifreTekrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(153, 20);
            this.txtSifreTekrar.TabIndex = 4;
            // 
            // btnKullaniciKontrol
            // 
            this.btnKullaniciKontrol.BackColor = System.Drawing.Color.White;
            this.btnKullaniciKontrol.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciKontrol.Image")));
            this.btnKullaniciKontrol.Location = new System.Drawing.Point(271, 26);
            this.btnKullaniciKontrol.Name = "btnKullaniciKontrol";
            this.btnKullaniciKontrol.Size = new System.Drawing.Size(37, 22);
            this.btnKullaniciKontrol.TabIndex = 1;
            this.btnKullaniciKontrol.UseVisualStyleBackColor = false;
            this.btnKullaniciKontrol.Click += new System.EventHandler(this.btnKullaniciKontrol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Güvenlik Sorusu";
            // 
            // cboGuvenlikSorusu
            // 
            this.cboGuvenlikSorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuvenlikSorusu.Enabled = false;
            this.cboGuvenlikSorusu.FormattingEnabled = true;
            this.cboGuvenlikSorusu.Location = new System.Drawing.Point(111, 53);
            this.cboGuvenlikSorusu.Name = "cboGuvenlikSorusu";
            this.cboGuvenlikSorusu.Size = new System.Drawing.Size(153, 21);
            this.cboGuvenlikSorusu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cevap";
            // 
            // txtCevap
            // 
            this.txtCevap.Enabled = false;
            this.txtCevap.Location = new System.Drawing.Point(111, 81);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(153, 20);
            this.txtCevap.TabIndex = 2;
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.cboGuvenlikSorusu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKullaniciKontrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.btnSifreGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordReset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordReset_FormClosed_1);
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnKullaniciKontrol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGuvenlikSorusu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCevap;
    }
}