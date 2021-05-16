
namespace BorsaApplication
{
    partial class CoinEkle
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
            this.grpUrunEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoinMiktar = new System.Windows.Forms.TextBox();
            this.btnCoinEkle = new System.Windows.Forms.Button();
            this.cmbCoin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpUrunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUrunEkle
            // 
            this.grpUrunEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.grpUrunEkle.Controls.Add(this.label3);
            this.grpUrunEkle.Controls.Add(this.txtSatisFiyat);
            this.grpUrunEkle.Controls.Add(this.label2);
            this.grpUrunEkle.Controls.Add(this.cmbCoin);
            this.grpUrunEkle.Controls.Add(this.label1);
            this.grpUrunEkle.Controls.Add(this.txtCoinMiktar);
            this.grpUrunEkle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUrunEkle.Location = new System.Drawing.Point(11, 24);
            this.grpUrunEkle.Name = "grpUrunEkle";
            this.grpUrunEkle.Size = new System.Drawing.Size(420, 330);
            this.grpUrunEkle.TabIndex = 32;
            this.grpUrunEkle.TabStop = false;
            this.grpUrunEkle.Text = "ÜRÜN EKLEME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coin Miktarı:";
            // 
            // txtCoinMiktar
            // 
            this.txtCoinMiktar.Location = new System.Drawing.Point(163, 146);
            this.txtCoinMiktar.Name = "txtCoinMiktar";
            this.txtCoinMiktar.Size = new System.Drawing.Size(144, 32);
            this.txtCoinMiktar.TabIndex = 0;
            // 
            // btnCoinEkle
            // 
            this.btnCoinEkle.BackColor = System.Drawing.Color.Lime;
            this.btnCoinEkle.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinEkle.Location = new System.Drawing.Point(106, 360);
            this.btnCoinEkle.Name = "btnCoinEkle";
            this.btnCoinEkle.Size = new System.Drawing.Size(212, 54);
            this.btnCoinEkle.TabIndex = 33;
            this.btnCoinEkle.Text = "COİN EKLE";
            this.btnCoinEkle.UseVisualStyleBackColor = false;
            this.btnCoinEkle.Click += new System.EventHandler(this.btnCoinEkle_Click);
            // 
            // cmbCoin
            // 
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Location = new System.Drawing.Point(163, 77);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(144, 32);
            this.cmbCoin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coin:";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(163, 209);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(144, 32);
            this.txtSatisFiyat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Satış Fiyatı:";
            // 
            // CoinEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpUrunEkle);
            this.Controls.Add(this.btnCoinEkle);
            this.Name = "CoinEkle";
            this.Load += new System.EventHandler(this.CoinEkle_Load);
            this.grpUrunEkle.ResumeLayout(false);
            this.grpUrunEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrunEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoinMiktar;
        private System.Windows.Forms.Button btnCoinEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisFiyat;
    }
}