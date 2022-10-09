namespace adamasmaca
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
            this.button1 = new System.Windows.Forms.Button();
            this.olufull = new System.Windows.Forms.PictureBox();
            this.acsagbacak = new System.Windows.Forms.PictureBox();
            this.acsolbacak = new System.Windows.Forms.PictureBox();
            this.acsolkol = new System.Windows.Forms.PictureBox();
            this.acsagkol = new System.Windows.Forms.PictureBox();
            this.acvucut = new System.Windows.Forms.PictureBox();
            this.ackafa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olufull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsagbacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsolbacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsolkol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsagkol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acvucut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ackafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(964, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kelimeyi buldum!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // olufull
            // 
            this.olufull.BackColor = System.Drawing.Color.Transparent;
            this.olufull.Image = global::adamasmaca.Properties.Resources.olufull;
            this.olufull.Location = new System.Drawing.Point(30, 12);
            this.olufull.Name = "olufull";
            this.olufull.Size = new System.Drawing.Size(736, 490);
            this.olufull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.olufull.TabIndex = 9;
            this.olufull.TabStop = false;
            this.olufull.Visible = false;
            // 
            // acsagbacak
            // 
            this.acsagbacak.Location = new System.Drawing.Point(422, 300);
            this.acsagbacak.Name = "acsagbacak";
            this.acsagbacak.Size = new System.Drawing.Size(62, 143);
            this.acsagbacak.TabIndex = 6;
            this.acsagbacak.TabStop = false;
            // 
            // acsolbacak
            // 
            this.acsolbacak.Location = new System.Drawing.Point(360, 300);
            this.acsolbacak.Name = "acsolbacak";
            this.acsolbacak.Size = new System.Drawing.Size(62, 134);
            this.acsolbacak.TabIndex = 5;
            this.acsolbacak.TabStop = false;
            // 
            // acsolkol
            // 
            this.acsolkol.Location = new System.Drawing.Point(337, 184);
            this.acsolkol.Name = "acsolkol";
            this.acsolkol.Size = new System.Drawing.Size(75, 102);
            this.acsolkol.TabIndex = 4;
            this.acsolkol.TabStop = false;
            // 
            // acsagkol
            // 
            this.acsagkol.Location = new System.Drawing.Point(420, 184);
            this.acsagkol.Name = "acsagkol";
            this.acsagkol.Size = new System.Drawing.Size(74, 102);
            this.acsagkol.TabIndex = 3;
            this.acsagkol.TabStop = false;
            // 
            // acvucut
            // 
            this.acvucut.Location = new System.Drawing.Point(412, 177);
            this.acvucut.Name = "acvucut";
            this.acvucut.Size = new System.Drawing.Size(8, 123);
            this.acvucut.TabIndex = 2;
            this.acvucut.TabStop = false;
            // 
            // ackafa
            // 
            this.ackafa.Location = new System.Drawing.Point(360, 100);
            this.ackafa.Name = "ackafa";
            this.ackafa.Size = new System.Drawing.Size(105, 78);
            this.ackafa.TabIndex = 1;
            this.ackafa.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::adamasmaca.Properties.Resources.full;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(959, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tahminini Gir";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hayvanlar",
            "Şehirler",
            "Meyveler ve Sebzeler"});
            this.comboBox1.Location = new System.Drawing.Point(1023, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(1185, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Kelimeyi Getir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(917, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 40);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(782, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategori Seçiniz";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(920, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "English";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(1012, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 16;
            this.button4.Text = "Türkçe";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(782, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 855);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olufull);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acsagbacak);
            this.Controls.Add(this.acsolbacak);
            this.Controls.Add(this.acsolkol);
            this.Controls.Add(this.acsagkol);
            this.Controls.Add(this.acvucut);
            this.Controls.Add(this.ackafa);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.TransparencyKey = System.Drawing.Color.Firebrick;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olufull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsagbacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsolbacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsolkol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsagkol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acvucut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ackafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ackafa;
        private System.Windows.Forms.PictureBox acvucut;
        private System.Windows.Forms.PictureBox acsagkol;
        private System.Windows.Forms.PictureBox acsolkol;
        private System.Windows.Forms.PictureBox acsolbacak;
        private System.Windows.Forms.PictureBox acsagbacak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox olufull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}

