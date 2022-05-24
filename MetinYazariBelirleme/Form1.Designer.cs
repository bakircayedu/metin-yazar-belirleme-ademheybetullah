
namespace MetinYazariBelirleme
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MetinSecmeTab = new System.Windows.Forms.TabPage();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.txtMetinBilgileri = new System.Windows.Forms.TextBox();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnMetinSeç = new System.Windows.Forms.Button();
            this.tabMetinBilgileri = new System.Windows.Forms.TabPage();
            this.dgwCokKullanilanKelimeler = new System.Windows.Forms.DataGridView();
            this.lblKelimeSayisi = new System.Windows.Forms.Label();
            this.txtIstenenKelimeSayisi = new System.Windows.Forms.TextBox();
            this.btnKelimeleriGetir = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnKelimeAra = new System.Windows.Forms.Button();
            this.txtCumleno = new System.Windows.Forms.TextBox();
            this.txtKelimeNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArananKelime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MetinSecmeTab.SuspendLayout();
            this.tabMetinBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCokKullanilanKelimeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MetinSecmeTab);
            this.tabControl1.Controls.Add(this.tabMetinBilgileri);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // MetinSecmeTab
            // 
            this.MetinSecmeTab.Controls.Add(this.groupBox1);
            this.MetinSecmeTab.Controls.Add(this.btnAgacaAktar);
            this.MetinSecmeTab.Controls.Add(this.txtMetinBilgileri);
            this.MetinSecmeTab.Controls.Add(this.btnStackOku);
            this.MetinSecmeTab.Controls.Add(this.lblDosyaYolu);
            this.MetinSecmeTab.Controls.Add(this.txtDosyaYolu);
            this.MetinSecmeTab.Controls.Add(this.btnMetinSeç);
            this.MetinSecmeTab.Location = new System.Drawing.Point(4, 25);
            this.MetinSecmeTab.Name = "MetinSecmeTab";
            this.MetinSecmeTab.Padding = new System.Windows.Forms.Padding(3);
            this.MetinSecmeTab.Size = new System.Drawing.Size(1031, 502);
            this.MetinSecmeTab.TabIndex = 0;
            this.MetinSecmeTab.Text = "Metin Seçme";
            this.MetinSecmeTab.UseVisualStyleBackColor = true;
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(30, 304);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(97, 40);
            this.btnAgacaAktar.TabIndex = 5;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // txtMetinBilgileri
            // 
            this.txtMetinBilgileri.Location = new System.Drawing.Point(146, 128);
            this.txtMetinBilgileri.Multiline = true;
            this.txtMetinBilgileri.Name = "txtMetinBilgileri";
            this.txtMetinBilgileri.Size = new System.Drawing.Size(284, 143);
            this.txtMetinBilgileri.TabIndex = 4;
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(30, 128);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(97, 40);
            this.btnStackOku.TabIndex = 3;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(143, 41);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(80, 17);
            this.lblDosyaYolu.TabIndex = 2;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(229, 38);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.ReadOnly = true;
            this.txtDosyaYolu.Size = new System.Drawing.Size(356, 22);
            this.txtDosyaYolu.TabIndex = 1;
            // 
            // btnMetinSeç
            // 
            this.btnMetinSeç.Location = new System.Drawing.Point(30, 29);
            this.btnMetinSeç.Name = "btnMetinSeç";
            this.btnMetinSeç.Size = new System.Drawing.Size(97, 40);
            this.btnMetinSeç.TabIndex = 0;
            this.btnMetinSeç.Text = "Metin Seç";
            this.btnMetinSeç.UseVisualStyleBackColor = true;
            this.btnMetinSeç.Click += new System.EventHandler(this.btnMetinSeç_Click);
            // 
            // tabMetinBilgileri
            // 
            this.tabMetinBilgileri.Controls.Add(this.dgwCokKullanilanKelimeler);
            this.tabMetinBilgileri.Controls.Add(this.lblKelimeSayisi);
            this.tabMetinBilgileri.Controls.Add(this.txtIstenenKelimeSayisi);
            this.tabMetinBilgileri.Controls.Add(this.btnKelimeleriGetir);
            this.tabMetinBilgileri.Location = new System.Drawing.Point(4, 25);
            this.tabMetinBilgileri.Name = "tabMetinBilgileri";
            this.tabMetinBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetinBilgileri.Size = new System.Drawing.Size(767, 396);
            this.tabMetinBilgileri.TabIndex = 1;
            this.tabMetinBilgileri.Text = "Metin Bilgileri";
            this.tabMetinBilgileri.UseVisualStyleBackColor = true;
            // 
            // dgwCokKullanilanKelimeler
            // 
            this.dgwCokKullanilanKelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCokKullanilanKelimeler.Location = new System.Drawing.Point(26, 121);
            this.dgwCokKullanilanKelimeler.Name = "dgwCokKullanilanKelimeler";
            this.dgwCokKullanilanKelimeler.RowHeadersWidth = 51;
            this.dgwCokKullanilanKelimeler.RowTemplate.Height = 24;
            this.dgwCokKullanilanKelimeler.Size = new System.Drawing.Size(492, 255);
            this.dgwCokKullanilanKelimeler.TabIndex = 4;
            // 
            // lblKelimeSayisi
            // 
            this.lblKelimeSayisi.AutoSize = true;
            this.lblKelimeSayisi.Location = new System.Drawing.Point(23, 33);
            this.lblKelimeSayisi.Name = "lblKelimeSayisi";
            this.lblKelimeSayisi.Size = new System.Drawing.Size(139, 17);
            this.lblKelimeSayisi.TabIndex = 3;
            this.lblKelimeSayisi.Text = "Kelime Sayısı Giriniz:";
            // 
            // txtIstenenKelimeSayisi
            // 
            this.txtIstenenKelimeSayisi.Location = new System.Drawing.Point(168, 30);
            this.txtIstenenKelimeSayisi.Name = "txtIstenenKelimeSayisi";
            this.txtIstenenKelimeSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtIstenenKelimeSayisi.TabIndex = 2;
            // 
            // btnKelimeleriGetir
            // 
            this.btnKelimeleriGetir.Location = new System.Drawing.Point(26, 65);
            this.btnKelimeleriGetir.Name = "btnKelimeleriGetir";
            this.btnKelimeleriGetir.Size = new System.Drawing.Size(97, 50);
            this.btnKelimeleriGetir.TabIndex = 1;
            this.btnKelimeleriGetir.Text = "Kelimeleri Getir";
            this.btnKelimeleriGetir.UseVisualStyleBackColor = true;
            this.btnKelimeleriGetir.Click += new System.EventHandler(this.btnKelimeleriGetir_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(120, 44);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(97, 40);
            this.btnHash.TabIndex = 6;
            this.btnHash.Text = "Hash\'e Aktar";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnKelimeAra
            // 
            this.btnKelimeAra.Location = new System.Drawing.Point(120, 243);
            this.btnKelimeAra.Name = "btnKelimeAra";
            this.btnKelimeAra.Size = new System.Drawing.Size(97, 40);
            this.btnKelimeAra.TabIndex = 7;
            this.btnKelimeAra.Text = "Hash\'e ara";
            this.btnKelimeAra.UseVisualStyleBackColor = true;
            this.btnKelimeAra.Click += new System.EventHandler(this.btnKelimeAra_Click);
            // 
            // txtCumleno
            // 
            this.txtCumleno.Location = new System.Drawing.Point(119, 155);
            this.txtCumleno.Name = "txtCumleno";
            this.txtCumleno.Size = new System.Drawing.Size(100, 22);
            this.txtCumleno.TabIndex = 8;
            // 
            // txtKelimeNo
            // 
            this.txtKelimeNo.Location = new System.Drawing.Point(119, 202);
            this.txtKelimeNo.Name = "txtKelimeNo";
            this.txtKelimeNo.Size = new System.Drawing.Size(100, 22);
            this.txtKelimeNo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArananKelime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKelimeNo);
            this.groupBox1.Controls.Add(this.btnHash);
            this.groupBox1.Controls.Add(this.btnKelimeAra);
            this.groupBox1.Controls.Add(this.txtCumleno);
            this.groupBox1.Location = new System.Drawing.Point(608, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 428);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash İslemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cümle Sırası: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kelime Sırası: ";
            // 
            // txtArananKelime
            // 
            this.txtArananKelime.Location = new System.Drawing.Point(120, 302);
            this.txtArananKelime.Name = "txtArananKelime";
            this.txtArananKelime.Size = new System.Drawing.Size(200, 22);
            this.txtArananKelime.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aranan Kelime: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.MetinSecmeTab.ResumeLayout(false);
            this.MetinSecmeTab.PerformLayout();
            this.tabMetinBilgileri.ResumeLayout(false);
            this.tabMetinBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCokKullanilanKelimeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MetinSecmeTab;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.TextBox txtMetinBilgileri;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Button btnMetinSeç;
        private System.Windows.Forms.TabPage tabMetinBilgileri;
        private System.Windows.Forms.DataGridView dgwCokKullanilanKelimeler;
        private System.Windows.Forms.Label lblKelimeSayisi;
        private System.Windows.Forms.TextBox txtIstenenKelimeSayisi;
        private System.Windows.Forms.Button btnKelimeleriGetir;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnKelimeAra;
        private System.Windows.Forms.TextBox txtCumleno;
        private System.Windows.Forms.TextBox txtKelimeNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArananKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

