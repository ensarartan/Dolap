namespace Dolap
{
    partial class Guncelle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_urunaciklama = new System.Windows.Forms.Label();
            this.lbl_urunfiyat = new System.Windows.Forms.Label();
            this.lbladed = new System.Windows.Forms.Label();
            this.lbl_uruncikistarih = new System.Windows.Forms.Label();
            this.lbl_urungiristarih = new System.Windows.Forms.Label();
            this.lbl_uruntipi = new System.Windows.Forms.Label();
            this.lbl_urunrengi = new System.Windows.Forms.Label();
            this.lbl_urunboyut = new System.Windows.Forms.Label();
            this.lbl_urunisim = new System.Windows.Forms.Label();
            this.lbl_urunid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtb_urunid = new System.Windows.Forms.TextBox();
            this.txtb_urunisim = new System.Windows.Forms.TextBox();
            this.txtb_urunboyut = new System.Windows.Forms.TextBox();
            this.txtb_urunrengi = new System.Windows.Forms.TextBox();
            this.txtb_uruntipi = new System.Windows.Forms.TextBox();
            this.txtb_urungiristarih = new System.Windows.Forms.TextBox();
            this.txtb_uruncikistarih = new System.Windows.Forms.TextBox();
            this.txtb_urunadedi = new System.Windows.Forms.TextBox();
            this.txtb_urunfiyat = new System.Windows.Forms.TextBox();
            this.txtb_urunaciklama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 402);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1106, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb_urunaciklama);
            this.groupBox1.Controls.Add(this.txtb_urunfiyat);
            this.groupBox1.Controls.Add(this.txtb_urunadedi);
            this.groupBox1.Controls.Add(this.txtb_uruncikistarih);
            this.groupBox1.Controls.Add(this.txtb_urungiristarih);
            this.groupBox1.Controls.Add(this.txtb_uruntipi);
            this.groupBox1.Controls.Add(this.txtb_urunrengi);
            this.groupBox1.Controls.Add(this.txtb_urunboyut);
            this.groupBox1.Controls.Add(this.txtb_urunisim);
            this.groupBox1.Controls.Add(this.txtb_urunid);
            this.groupBox1.Controls.Add(this.lbl_urunaciklama);
            this.groupBox1.Controls.Add(this.lbl_urunfiyat);
            this.groupBox1.Controls.Add(this.lbladed);
            this.groupBox1.Controls.Add(this.lbl_uruncikistarih);
            this.groupBox1.Controls.Add(this.lbl_urungiristarih);
            this.groupBox1.Controls.Add(this.lbl_uruntipi);
            this.groupBox1.Controls.Add(this.lbl_urunrengi);
            this.groupBox1.Controls.Add(this.lbl_urunboyut);
            this.groupBox1.Controls.Add(this.lbl_urunisim);
            this.groupBox1.Controls.Add(this.lbl_urunid);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(318, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // lbl_urunaciklama
            // 
            this.lbl_urunaciklama.AutoSize = true;
            this.lbl_urunaciklama.Location = new System.Drawing.Point(8, 331);
            this.lbl_urunaciklama.Name = "lbl_urunaciklama";
            this.lbl_urunaciklama.Size = new System.Drawing.Size(150, 20);
            this.lbl_urunaciklama.TabIndex = 10;
            this.lbl_urunaciklama.Text = "Ürün Açıklaması :";
            // 
            // lbl_urunfiyat
            // 
            this.lbl_urunfiyat.AutoSize = true;
            this.lbl_urunfiyat.Location = new System.Drawing.Point(49, 299);
            this.lbl_urunfiyat.Name = "lbl_urunfiyat";
            this.lbl_urunfiyat.Size = new System.Drawing.Size(109, 20);
            this.lbl_urunfiyat.TabIndex = 9;
            this.lbl_urunfiyat.Text = "Ürün Fiyatı :";
            // 
            // lbladed
            // 
            this.lbladed.AutoSize = true;
            this.lbladed.Location = new System.Drawing.Point(48, 267);
            this.lbladed.Name = "lbladed";
            this.lbladed.Size = new System.Drawing.Size(110, 20);
            this.lbladed.TabIndex = 8;
            this.lbladed.Text = "Ürün Adedi :";
            // 
            // lbl_uruncikistarih
            // 
            this.lbl_uruncikistarih.AutoSize = true;
            this.lbl_uruncikistarih.Location = new System.Drawing.Point(2, 235);
            this.lbl_uruncikistarih.Name = "lbl_uruncikistarih";
            this.lbl_uruncikistarih.Size = new System.Drawing.Size(156, 20);
            this.lbl_uruncikistarih.TabIndex = 7;
            this.lbl_uruncikistarih.Text = "Ürün Çıkış Tarihi :";
            // 
            // lbl_urungiristarih
            // 
            this.lbl_urungiristarih.AutoSize = true;
            this.lbl_urungiristarih.Location = new System.Drawing.Point(4, 203);
            this.lbl_urungiristarih.Name = "lbl_urungiristarih";
            this.lbl_urungiristarih.Size = new System.Drawing.Size(154, 20);
            this.lbl_urungiristarih.TabIndex = 6;
            this.lbl_urungiristarih.Text = "Ürün Giriş Tarihi :";
            // 
            // lbl_uruntipi
            // 
            this.lbl_uruntipi.AutoSize = true;
            this.lbl_uruntipi.Location = new System.Drawing.Point(64, 171);
            this.lbl_uruntipi.Name = "lbl_uruntipi";
            this.lbl_uruntipi.Size = new System.Drawing.Size(94, 20);
            this.lbl_uruntipi.TabIndex = 5;
            this.lbl_uruntipi.Text = "Ürün Tipi :";
            // 
            // lbl_urunrengi
            // 
            this.lbl_urunrengi.AutoSize = true;
            this.lbl_urunrengi.Location = new System.Drawing.Point(47, 139);
            this.lbl_urunrengi.Name = "lbl_urunrengi";
            this.lbl_urunrengi.Size = new System.Drawing.Size(111, 20);
            this.lbl_urunrengi.TabIndex = 4;
            this.lbl_urunrengi.Text = "Ürün Rengi :";
            // 
            // lbl_urunboyut
            // 
            this.lbl_urunboyut.AutoSize = true;
            this.lbl_urunboyut.Location = new System.Drawing.Point(35, 107);
            this.lbl_urunboyut.Name = "lbl_urunboyut";
            this.lbl_urunboyut.Size = new System.Drawing.Size(123, 20);
            this.lbl_urunboyut.TabIndex = 3;
            this.lbl_urunboyut.Text = "Ürün Boyutu :";
            // 
            // lbl_urunisim
            // 
            this.lbl_urunisim.AutoSize = true;
            this.lbl_urunisim.Location = new System.Drawing.Point(60, 75);
            this.lbl_urunisim.Name = "lbl_urunisim";
            this.lbl_urunisim.Size = new System.Drawing.Size(98, 20);
            this.lbl_urunisim.TabIndex = 2;
            this.lbl_urunisim.Text = "Ürün İsmi :";
            // 
            // lbl_urunid
            // 
            this.lbl_urunid.AutoSize = true;
            this.lbl_urunid.Location = new System.Drawing.Point(75, 43);
            this.lbl_urunid.Name = "lbl_urunid";
            this.lbl_urunid.Size = new System.Drawing.Size(83, 20);
            this.lbl_urunid.TabIndex = 1;
            this.lbl_urunid.Text = "Ürün ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 230);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtb_urunid
            // 
            this.txtb_urunid.Enabled = false;
            this.txtb_urunid.Location = new System.Drawing.Point(161, 40);
            this.txtb_urunid.Name = "txtb_urunid";
            this.txtb_urunid.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunid.TabIndex = 11;
            // 
            // txtb_urunisim
            // 
            this.txtb_urunisim.Location = new System.Drawing.Point(161, 72);
            this.txtb_urunisim.Name = "txtb_urunisim";
            this.txtb_urunisim.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunisim.TabIndex = 12;
            // 
            // txtb_urunboyut
            // 
            this.txtb_urunboyut.Location = new System.Drawing.Point(161, 104);
            this.txtb_urunboyut.Name = "txtb_urunboyut";
            this.txtb_urunboyut.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunboyut.TabIndex = 13;
            // 
            // txtb_urunrengi
            // 
            this.txtb_urunrengi.Location = new System.Drawing.Point(161, 136);
            this.txtb_urunrengi.Name = "txtb_urunrengi";
            this.txtb_urunrengi.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunrengi.TabIndex = 14;
            // 
            // txtb_uruntipi
            // 
            this.txtb_uruntipi.Location = new System.Drawing.Point(161, 168);
            this.txtb_uruntipi.Name = "txtb_uruntipi";
            this.txtb_uruntipi.Size = new System.Drawing.Size(146, 26);
            this.txtb_uruntipi.TabIndex = 15;
            // 
            // txtb_urungiristarih
            // 
            this.txtb_urungiristarih.Location = new System.Drawing.Point(161, 200);
            this.txtb_urungiristarih.Name = "txtb_urungiristarih";
            this.txtb_urungiristarih.Size = new System.Drawing.Size(146, 26);
            this.txtb_urungiristarih.TabIndex = 16;
            // 
            // txtb_uruncikistarih
            // 
            this.txtb_uruncikistarih.Location = new System.Drawing.Point(161, 232);
            this.txtb_uruncikistarih.Name = "txtb_uruncikistarih";
            this.txtb_uruncikistarih.Size = new System.Drawing.Size(146, 26);
            this.txtb_uruncikistarih.TabIndex = 17;
            // 
            // txtb_urunadedi
            // 
            this.txtb_urunadedi.Location = new System.Drawing.Point(161, 264);
            this.txtb_urunadedi.Name = "txtb_urunadedi";
            this.txtb_urunadedi.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunadedi.TabIndex = 18;
            // 
            // txtb_urunfiyat
            // 
            this.txtb_urunfiyat.Location = new System.Drawing.Point(161, 296);
            this.txtb_urunfiyat.Name = "txtb_urunfiyat";
            this.txtb_urunfiyat.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunfiyat.TabIndex = 19;
            // 
            // txtb_urunaciklama
            // 
            this.txtb_urunaciklama.Location = new System.Drawing.Point(161, 328);
            this.txtb_urunaciklama.Name = "txtb_urunaciklama";
            this.txtb_urunaciklama.Size = new System.Drawing.Size(146, 26);
            this.txtb_urunaciklama.TabIndex = 20;
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Guncelle";
            this.Text = "Guncelle";
            this.Load += new System.EventHandler(this.Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_urunaciklama;
        private System.Windows.Forms.Label lbl_urunfiyat;
        private System.Windows.Forms.Label lbladed;
        private System.Windows.Forms.Label lbl_uruncikistarih;
        private System.Windows.Forms.Label lbl_urungiristarih;
        private System.Windows.Forms.Label lbl_uruntipi;
        private System.Windows.Forms.Label lbl_urunrengi;
        private System.Windows.Forms.Label lbl_urunboyut;
        private System.Windows.Forms.Label lbl_urunisim;
        private System.Windows.Forms.Label lbl_urunid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtb_urunaciklama;
        private System.Windows.Forms.TextBox txtb_urunfiyat;
        private System.Windows.Forms.TextBox txtb_urunadedi;
        private System.Windows.Forms.TextBox txtb_uruncikistarih;
        private System.Windows.Forms.TextBox txtb_urungiristarih;
        private System.Windows.Forms.TextBox txtb_uruntipi;
        private System.Windows.Forms.TextBox txtb_urunrengi;
        private System.Windows.Forms.TextBox txtb_urunboyut;
        private System.Windows.Forms.TextBox txtb_urunisim;
        private System.Windows.Forms.TextBox txtb_urunid;
    }
}