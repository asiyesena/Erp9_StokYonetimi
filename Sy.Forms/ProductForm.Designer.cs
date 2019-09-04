namespace Sy.Forms
{
    partial class ProductForm
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
            this.LblProduct = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.LblKritik = new System.Windows.Forms.Label();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.nStok = new System.Windows.Forms.NumericUpDown();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.listUrunler = new System.Windows.Forms.ListBox();
            this.LblBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.Location = new System.Drawing.Point(35, 43);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(54, 13);
            this.LblProduct.TabIndex = 0;
            this.LblProduct.Text = "Üürn Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(107, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(242, 20);
            this.txtAd.TabIndex = 1;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(35, 78);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // LblKritik
            // 
            this.LblKritik.AutoSize = true;
            this.LblKritik.Location = new System.Drawing.Point(35, 113);
            this.LblKritik.Name = "LblKritik";
            this.LblKritik.Size = new System.Drawing.Size(63, 13);
            this.LblKritik.TabIndex = 0;
            this.LblKritik.Text = "Kiritik Stok :";
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(107, 76);
            this.nFiyat.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(242, 20);
            this.nFiyat.TabIndex = 2;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nStok
            // 
            this.nStok.DecimalPlaces = 2;
            this.nStok.Location = new System.Drawing.Point(107, 106);
            this.nStok.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nStok.Name = "nStok";
            this.nStok.Size = new System.Drawing.Size(242, 20);
            this.nStok.TabIndex = 2;
            this.nStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(377, 40);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(93, 86);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(515, 43);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(236, 20);
            this.txtAra.TabIndex = 4;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // listUrunler
            // 
            this.listUrunler.FormattingEnabled = true;
            this.listUrunler.Location = new System.Drawing.Point(515, 76);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(236, 303);
            this.listUrunler.TabIndex = 5;
            // 
            // LblBilgi
            // 
            this.LblBilgi.AutoSize = true;
            this.LblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBilgi.ForeColor = System.Drawing.Color.Red;
            this.LblBilgi.Location = new System.Drawing.Point(35, 191);
            this.LblBilgi.Name = "LblBilgi";
            this.LblBilgi.Size = new System.Drawing.Size(400, 22);
            this.LblBilgi.TabIndex = 6;
            this.LblBilgi.Text = "LblBilgi burada üürnlerin bilgisini vereceğiz.";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBilgi);
            this.Controls.Add(this.listUrunler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.nStok);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.LblKritik);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.LblProduct);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label LblKritik;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.NumericUpDown nStok;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox listUrunler;
        private System.Windows.Forms.Label LblBilgi;
    }
}