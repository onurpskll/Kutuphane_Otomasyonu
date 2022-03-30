namespace _03_03_22
{
    partial class MainV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmKitap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKitapEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKitapListele = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmanet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmanetEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmanetListele = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetAl = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKitap,
            this.tsmEmanet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(835, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmKitap
            // 
            this.tsmKitap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKitapEkle,
            this.tsmKitapListele});
            this.tsmKitap.Name = "tsmKitap";
            this.tsmKitap.Size = new System.Drawing.Size(46, 19);
            this.tsmKitap.Text = "Kitap";
            // 
            // tsmKitapEkle
            // 
            this.tsmKitapEkle.Name = "tsmKitapEkle";
            this.tsmKitapEkle.Size = new System.Drawing.Size(137, 22);
            this.tsmKitapEkle.Text = "Kitap Ekle";
            // 
            // tsmKitapListele
            // 
            this.tsmKitapListele.Name = "tsmKitapListele";
            this.tsmKitapListele.Size = new System.Drawing.Size(137, 22);
            this.tsmKitapListele.Text = "Kitap Listele";
            // 
            // tsmEmanet
            // 
            this.tsmEmanet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEmanetEkle,
            this.tsmEmanetListele});
            this.tsmEmanet.Name = "tsmEmanet";
            this.tsmEmanet.Size = new System.Drawing.Size(59, 19);
            this.tsmEmanet.Text = "Emanet";
            // 
            // tsmEmanetEkle
            // 
            this.tsmEmanetEkle.Name = "tsmEmanetEkle";
            this.tsmEmanetEkle.Size = new System.Drawing.Size(150, 22);
            this.tsmEmanetEkle.Text = "Emanet Ekle";
            // 
            // tsmEmanetListele
            // 
            this.tsmEmanetListele.Name = "tsmEmanetListele";
            this.tsmEmanetListele.Size = new System.Drawing.Size(150, 22);
            this.tsmEmanetListele.Text = "Emanet Listele";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapEkle.Image")));
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapEkle.Location = new System.Drawing.Point(61, 78);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(303, 115);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "KİTAP EKLE";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapListele.Image")));
            this.btnKitapListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapListele.Location = new System.Drawing.Point(61, 213);
            this.btnKitapListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(303, 115);
            this.btnKitapListele.TabIndex = 3;
            this.btnKitapListele.Text = "KİTAP LİSTELE";
            this.btnKitapListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapListele.UseVisualStyleBackColor = true;
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetListele.Image")));
            this.btnEmanetListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetListele.Location = new System.Drawing.Point(444, 213);
            this.btnEmanetListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(303, 115);
            this.btnEmanetListele.TabIndex = 5;
            this.btnEmanetListele.Text = "EMANET LİSTELE";
            this.btnEmanetListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            // 
            // btnEmanetAl
            // 
            this.btnEmanetAl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetAl.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetAl.Image")));
            this.btnEmanetAl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetAl.Location = new System.Drawing.Point(444, 78);
            this.btnEmanetAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetAl.Name = "btnEmanetAl";
            this.btnEmanetAl.Size = new System.Drawing.Size(303, 115);
            this.btnEmanetAl.TabIndex = 4;
            this.btnEmanetAl.Text = "EMANET AL";
            this.btnEmanetAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetAl.UseVisualStyleBackColor = true;
            // 
            // MainV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 394);
            this.Controls.Add(this.btnEmanetListele);
            this.Controls.Add(this.btnEmanetAl);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainV_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmKitap;
        private System.Windows.Forms.ToolStripMenuItem tsmEmanet;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetAl;
        private System.Windows.Forms.ToolStripMenuItem tsmKitapEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmKitapListele;
        private System.Windows.Forms.ToolStripMenuItem tsmEmanetEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEmanetListele;
    }
}