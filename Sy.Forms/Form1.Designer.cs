namespace Sy.Forms
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
            this.grpbxBtn = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.lblGirisBilgi = new System.Windows.Forms.Label();
            this.grpbxBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxBtn
            // 
            this.grpbxBtn.Controls.Add(this.btnKayıtOl);
            this.grpbxBtn.Controls.Add(this.btnGirisYap);
            this.grpbxBtn.Location = new System.Drawing.Point(12, 26);
            this.grpbxBtn.Name = "grpbxBtn";
            this.grpbxBtn.Size = new System.Drawing.Size(176, 102);
            this.grpbxBtn.TabIndex = 0;
            this.grpbxBtn.TabStop = false;
            this.grpbxBtn.Text = "groupBox1";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(6, 19);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 62);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Location = new System.Drawing.Point(87, 19);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(75, 62);
            this.btnKayıtOl.TabIndex = 1;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // lblGirisBilgi
            // 
            this.lblGirisBilgi.AutoSize = true;
            this.lblGirisBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGirisBilgi.Location = new System.Drawing.Point(208, 45);
            this.lblGirisBilgi.Name = "lblGirisBilgi";
            this.lblGirisBilgi.Size = new System.Drawing.Size(238, 22);
            this.lblGirisBilgi.TabIndex = 1;
            this.lblGirisBilgi.Text = "Hoşgeldiniz ... Kamil  Osman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 269);
            this.Controls.Add(this.lblGirisBilgi);
            this.Controls.Add(this.grpbxBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpbxBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxBtn;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblGirisBilgi;
    }
}

