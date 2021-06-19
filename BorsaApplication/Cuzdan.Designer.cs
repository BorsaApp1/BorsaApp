
namespace BorsaApplication
{
    partial class Cuzdan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCuzdan = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCoin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoinMiktar = new System.Windows.Forms.TextBox();
            this.btnSatim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuzdan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCuzdan);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CÜZDAN";
            // 
            // dgvCuzdan
            // 
            this.dgvCuzdan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuzdan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCuzdan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCuzdan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuzdan.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCuzdan.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvCuzdan.Location = new System.Drawing.Point(23, 37);
            this.dgvCuzdan.Name = "dgvCuzdan";
            this.dgvCuzdan.RowHeadersVisible = false;
            this.dgvCuzdan.RowHeadersWidth = 51;
            this.dgvCuzdan.RowTemplate.Height = 24;
            this.dgvCuzdan.Size = new System.Drawing.Size(840, 302);
            this.dgvCuzdan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(61, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Satış Fiyatı:";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtSatisFiyat.Location = new System.Drawing.Point(178, 172);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(144, 32);
            this.txtSatisFiyat.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Coin:";
            // 
            // cmbCoin
            // 
            this.cmbCoin.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Location = new System.Drawing.Point(178, 40);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(144, 32);
            this.cmbCoin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coin Miktarı:";
            // 
            // txtCoinMiktar
            // 
            this.txtCoinMiktar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtCoinMiktar.Location = new System.Drawing.Point(178, 109);
            this.txtCoinMiktar.Name = "txtCoinMiktar";
            this.txtCoinMiktar.Size = new System.Drawing.Size(144, 32);
            this.txtCoinMiktar.TabIndex = 6;
            // 
            // btnSatim
            // 
            this.btnSatim.BackColor = System.Drawing.Color.Lime;
            this.btnSatim.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatim.Location = new System.Drawing.Point(178, 230);
            this.btnSatim.Name = "btnSatim";
            this.btnSatim.Size = new System.Drawing.Size(133, 50);
            this.btnSatim.TabIndex = 12;
            this.btnSatim.Text = "SATIM";
            this.btnSatim.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSatim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbCoin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSatisFiyat);
            this.groupBox2.Controls.Add(this.txtCoinMiktar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(23, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 296);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satım İşlemi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.maskedTextBox2);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(501, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 296);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bitiş Tarihi:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(196, 146);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 34);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(196, 68);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(121, 34);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(89, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "RAPOR OLUŞTUR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Cuzdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 713);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cuzdan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuzdan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvCuzdan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoinMiktar;
        private System.Windows.Forms.Button btnSatim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}