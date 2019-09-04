namespace Sy.Forms
{
    partial class OrderForm
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.grpSipDetay = new System.Windows.Forms.GroupBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.nEklencekMik = new System.Windows.Forms.NumericUpDown();
            this.LblStok = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.LblStokMiktari = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.nAlis = new System.Windows.Forms.NumericUpDown();
            this.grpSipDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEklencekMik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlis)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 38);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(234, 355);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(12, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(234, 20);
            this.txtArama.TabIndex = 1;
            // 
            // grpSipDetay
            // 
            this.grpSipDetay.Controls.Add(this.nAlis);
            this.grpSipDetay.Controls.Add(this.btnKaydet);
            this.grpSipDetay.Controls.Add(this.nEklencekMik);
            this.grpSipDetay.Controls.Add(this.lbl);
            this.grpSipDetay.Controls.Add(this.lblMiktar);
            this.grpSipDetay.Controls.Add(this.LblStokMiktari);
            this.grpSipDetay.Controls.Add(this.LblStok);
            this.grpSipDetay.Controls.Add(this.lblUrunAdi);
            this.grpSipDetay.Controls.Add(this.lblUrun);
            this.grpSipDetay.Location = new System.Drawing.Point(309, 12);
            this.grpSipDetay.Name = "grpSipDetay";
            this.grpSipDetay.Size = new System.Drawing.Size(347, 202);
            this.grpSipDetay.TabIndex = 2;
            this.grpSipDetay.TabStop = false;
            this.grpSipDetay.Text = "Sipariş Detay";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(37, 29);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(54, 13);
            this.lblUrun.TabIndex = 0;
            this.lblUrun.Text = "Ürün Adı :";
            // 
            // nEklencekMik
            // 
            this.nEklencekMik.DecimalPlaces = 2;
            this.nEklencekMik.Location = new System.Drawing.Point(146, 88);
            this.nEklencekMik.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nEklencekMik.Name = "nEklencekMik";
            this.nEklencekMik.Size = new System.Drawing.Size(120, 20);
            this.nEklencekMik.TabIndex = 1;
            this.nEklencekMik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblStok
            // 
            this.LblStok.AutoSize = true;
            this.LblStok.Location = new System.Drawing.Point(37, 58);
            this.LblStok.Name = "LblStok";
            this.LblStok.Size = new System.Drawing.Size(108, 13);
            this.LblStok.TabIndex = 0;
            this.LblStok.Text = "Mevcut Stok Miktarı :";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(37, 89);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(99, 13);
            this.lblMiktar.TabIndex = 0;
            this.lblMiktar.Text = "Eklenecek  Miktar :";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(96, 29);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(52, 17);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "label1";
            // 
            // LblStokMiktari
            // 
            this.LblStokMiktari.AutoSize = true;
            this.LblStokMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStokMiktari.Location = new System.Drawing.Point(150, 58);
            this.LblStokMiktari.Name = "LblStokMiktari";
            this.LblStokMiktari.Size = new System.Drawing.Size(52, 17);
            this.LblStokMiktari.TabIndex = 0;
            this.LblStokMiktari.Text = "label1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(124, 150);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 116);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(54, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Alış Fiyat :";
            // 
            // nAlis
            // 
            this.nAlis.DecimalPlaces = 2;
            this.nAlis.Location = new System.Drawing.Point(146, 113);
            this.nAlis.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nAlis.Name = "nAlis";
            this.nAlis.Size = new System.Drawing.Size(120, 20);
            this.nAlis.TabIndex = 3;
            this.nAlis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSipDetay);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lstUrunler);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.grpSipDetay.ResumeLayout(false);
            this.grpSipDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEklencekMik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox grpSipDetay;
        private System.Windows.Forms.NumericUpDown nEklencekMik;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label LblStokMiktari;
        private System.Windows.Forms.Label LblStok;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nAlis;
        private System.Windows.Forms.Label lbl;
    }
}