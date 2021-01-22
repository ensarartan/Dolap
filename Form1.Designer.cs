namespace Dolap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_kayitol = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(325, 303);
            this.txt_kullanici.Margin = new System.Windows.Forms.Padding(5);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(193, 26);
            this.txt_kullanici.TabIndex = 3;
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Location = new System.Drawing.Point(194, 306);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(121, 20);
            this.lbl_kullanici.TabIndex = 4;
            this.lbl_kullanici.Text = "Kullanıcı Adı :";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(259, 340);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(56, 20);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Şifre :";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(325, 337);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(193, 26);
            this.txt_pass.TabIndex = 6;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.Location = new System.Drawing.Point(535, 303);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(85, 60);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_kayitol
            // 
            this.lbl_kayitol.AutoSize = true;
            this.lbl_kayitol.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayitol.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_kayitol.Location = new System.Drawing.Point(328, 366);
            this.lbl_kayitol.Name = "lbl_kayitol";
            this.lbl_kayitol.Size = new System.Drawing.Size(59, 18);
            this.lbl_kayitol.TabIndex = 8;
            this.lbl_kayitol.Text = "Kayıt Ol";
            this.lbl_kayitol.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox2.Location = new System.Drawing.Point(0, 422);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(798, 80);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(798, 60);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 502);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_kayitol);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_kullanici);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_kayitol;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

