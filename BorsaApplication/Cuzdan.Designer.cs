
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCuzdan = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.mtxBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.mtxBitis = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuzdan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCuzdan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CÜZDAN";
            // 
            // dgvCuzdan
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dgvCuzdan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuzdan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuzdan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCuzdan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCuzdan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuzdan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemID,
            this.ItemAmount,
            this.DateOfPurchase});
            this.dgvCuzdan.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCuzdan.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvCuzdan.Location = new System.Drawing.Point(27, 37);
            this.dgvCuzdan.Name = "dgvCuzdan";
            this.dgvCuzdan.RowHeadersVisible = false;
            this.dgvCuzdan.RowHeadersWidth = 51;
            this.dgvCuzdan.RowTemplate.Height = 24;
            this.dgvCuzdan.Size = new System.Drawing.Size(840, 302);
            this.dgvCuzdan.TabIndex = 2;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "ItemAmount";
            this.ItemAmount.MinimumWidth = 6;
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ReadOnly = true;
            // 
            // DateOfPurchase
            // 
            this.DateOfPurchase.DataPropertyName = "DateOfPurchase";
            this.DateOfPurchase.HeaderText = "Date Of Purchase";
            this.DateOfPurchase.MinimumWidth = 6;
            this.DateOfPurchase.Name = "DateOfPurchase";
            this.DateOfPurchase.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRapor);
            this.groupBox3.Controls.Add(this.mtxBaslangic);
            this.groupBox3.Controls.Add(this.mtxBitis);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(23, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(888, 142);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapor";
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.Lime;
            this.btnRapor.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRapor.Location = new System.Drawing.Point(615, 54);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(252, 50);
            this.btnRapor.TabIndex = 13;
            this.btnRapor.Text = "RAPOR OLUŞTUR";
            this.btnRapor.UseVisualStyleBackColor = false;
            // 
            // mtxBaslangic
            // 
            this.mtxBaslangic.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxBaslangic.Location = new System.Drawing.Point(178, 64);
            this.mtxBaslangic.Mask = "00/00/0000";
            this.mtxBaslangic.Name = "mtxBaslangic";
            this.mtxBaslangic.Size = new System.Drawing.Size(121, 34);
            this.mtxBaslangic.TabIndex = 5;
            this.mtxBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // mtxBitis
            // 
            this.mtxBitis.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxBitis.Location = new System.Drawing.Point(453, 64);
            this.mtxBitis.Mask = "00/00/0000";
            this.mtxBitis.Name = "mtxBitis";
            this.mtxBitis.Size = new System.Drawing.Size(121, 34);
            this.mtxBitis.TabIndex = 4;
            this.mtxBitis.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bitiş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // Cuzdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cuzdan";
            this.Load += new System.EventHandler(this.Cuzdan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuzdan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvCuzdan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.MaskedTextBox mtxBaslangic;
        private System.Windows.Forms.MaskedTextBox mtxBitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchase;
    }
}