
namespace BorsaApplication
{
    partial class AdminEkran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.mtabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtabPageUrun = new MetroFramework.Controls.MetroTabPage();
            this.btnCoinEkle = new System.Windows.Forms.Button();
            this.dgvUrunKontrol = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtabPara = new MetroFramework.Controls.MetroTabPage();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.dgvParaKontrol = new System.Windows.Forms.DataGridView();
            this.UserID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpAdmin.SuspendLayout();
            this.mtabControl.SuspendLayout();
            this.mtabPageUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunKontrol)).BeginInit();
            this.mtabPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaKontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.mtabControl);
            this.grpAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAdmin.Location = new System.Drawing.Point(23, 26);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(1018, 491);
            this.grpAdmin.TabIndex = 0;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "ADMIN EKRANI";
            // 
            // mtabControl
            // 
            this.mtabControl.Controls.Add(this.mtabPageUrun);
            this.mtabControl.Controls.Add(this.mtabPara);
            this.mtabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mtabControl.Location = new System.Drawing.Point(6, 32);
            this.mtabControl.Name = "mtabControl";
            this.mtabControl.SelectedIndex = 1;
            this.mtabControl.Size = new System.Drawing.Size(1005, 445);
            this.mtabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mtabControl.TabIndex = 29;
            this.mtabControl.UseSelectable = true;
            // 
            // mtabPageUrun
            // 
            this.mtabPageUrun.AllowDrop = true;
            this.mtabPageUrun.Controls.Add(this.btnCoinEkle);
            this.mtabPageUrun.Controls.Add(this.dgvUrunKontrol);
            this.mtabPageUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtabPageUrun.HorizontalScrollbarBarColor = true;
            this.mtabPageUrun.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabPageUrun.HorizontalScrollbarSize = 10;
            this.mtabPageUrun.Location = new System.Drawing.Point(4, 44);
            this.mtabPageUrun.Name = "mtabPageUrun";
            this.mtabPageUrun.Size = new System.Drawing.Size(997, 397);
            this.mtabPageUrun.TabIndex = 0;
            this.mtabPageUrun.Text = "ÜRÜN KONTROL EKRANI";
            this.mtabPageUrun.VerticalScrollbarBarColor = true;
            this.mtabPageUrun.VerticalScrollbarHighlightOnWheel = false;
            this.mtabPageUrun.VerticalScrollbarSize = 10;
            this.mtabPageUrun.Enter += new System.EventHandler(this.mtabPageUrun_Enter);
            // 
            // btnCoinEkle
            // 
            this.btnCoinEkle.BackColor = System.Drawing.Color.Lime;
            this.btnCoinEkle.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinEkle.Location = new System.Drawing.Point(376, 328);
            this.btnCoinEkle.Name = "btnCoinEkle";
            this.btnCoinEkle.Size = new System.Drawing.Size(200, 39);
            this.btnCoinEkle.TabIndex = 4;
            this.btnCoinEkle.Text = "ONAYLA";
            this.btnCoinEkle.UseVisualStyleBackColor = false;
            this.btnCoinEkle.Click += new System.EventHandler(this.btnCoinEkle_Click);
            // 
            // dgvUrunKontrol
            // 
            this.dgvUrunKontrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunKontrol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUrunKontrol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUrunKontrol.ColumnHeadersHeight = 29;
            this.dgvUrunKontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.ItemID,
            this.ItemAmount,
            this.ItemPrice,
            this.ItemAccept});
            this.dgvUrunKontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvUrunKontrol.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvUrunKontrol.Location = new System.Drawing.Point(26, 15);
            this.dgvUrunKontrol.Name = "dgvUrunKontrol";
            this.dgvUrunKontrol.ReadOnly = true;
            this.dgvUrunKontrol.RowHeadersWidth = 51;
            this.dgvUrunKontrol.RowTemplate.Height = 24;
            this.dgvUrunKontrol.Size = new System.Drawing.Size(935, 291);
            this.dgvUrunKontrol.TabIndex = 2;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
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
            this.ItemAmount.HeaderText = "Item Amount";
            this.ItemAmount.MinimumWidth = 6;
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "ItemPrice";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // ItemAccept
            // 
            this.ItemAccept.DataPropertyName = "ItemAccept";
            this.ItemAccept.HeaderText = "Item Accept";
            this.ItemAccept.MinimumWidth = 6;
            this.ItemAccept.Name = "ItemAccept";
            this.ItemAccept.ReadOnly = true;
            // 
            // mtabPara
            // 
            this.mtabPara.Controls.Add(this.btnParaEkle);
            this.mtabPara.Controls.Add(this.dgvParaKontrol);
            this.mtabPara.HorizontalScrollbarBarColor = true;
            this.mtabPara.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabPara.HorizontalScrollbarSize = 10;
            this.mtabPara.Location = new System.Drawing.Point(4, 44);
            this.mtabPara.Name = "mtabPara";
            this.mtabPara.Size = new System.Drawing.Size(997, 397);
            this.mtabPara.TabIndex = 1;
            this.mtabPara.Text = "PARA KONTROL EKRANI";
            this.mtabPara.VerticalScrollbarBarColor = true;
            this.mtabPara.VerticalScrollbarHighlightOnWheel = false;
            this.mtabPara.VerticalScrollbarSize = 10;
            this.mtabPara.Enter += new System.EventHandler(this.mtabPara_Enter);
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.BackColor = System.Drawing.Color.Lime;
            this.btnParaEkle.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaEkle.Location = new System.Drawing.Point(376, 328);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(200, 39);
            this.btnParaEkle.TabIndex = 6;
            this.btnParaEkle.Text = "ONAYLA";
            this.btnParaEkle.UseVisualStyleBackColor = false;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // dgvParaKontrol
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvParaKontrol.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParaKontrol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvParaKontrol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParaKontrol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParaKontrol.ColumnHeadersHeight = 29;
            this.dgvParaKontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID1,
            this.MoneyAmount,
            this.MoneyAccept});
            this.dgvParaKontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvParaKontrol.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvParaKontrol.Location = new System.Drawing.Point(26, 15);
            this.dgvParaKontrol.Name = "dgvParaKontrol";
            this.dgvParaKontrol.ReadOnly = true;
            this.dgvParaKontrol.RowHeadersWidth = 51;
            this.dgvParaKontrol.RowTemplate.Height = 24;
            this.dgvParaKontrol.Size = new System.Drawing.Size(935, 291);
            this.dgvParaKontrol.TabIndex = 5;
            // 
            // UserID1
            // 
            this.UserID1.DataPropertyName = "UserID";
            this.UserID1.HeaderText = "User ID";
            this.UserID1.MinimumWidth = 6;
            this.UserID1.Name = "UserID1";
            this.UserID1.ReadOnly = true;
            this.UserID1.Width = 294;
            // 
            // MoneyAmount
            // 
            this.MoneyAmount.DataPropertyName = "MoneyAmount";
            this.MoneyAmount.HeaderText = "Money Amount";
            this.MoneyAmount.MinimumWidth = 6;
            this.MoneyAmount.Name = "MoneyAmount";
            this.MoneyAmount.ReadOnly = true;
            this.MoneyAmount.Width = 294;
            // 
            // MoneyAccept
            // 
            this.MoneyAccept.DataPropertyName = "MoneyAccept";
            this.MoneyAccept.HeaderText = "Money Accept";
            this.MoneyAccept.MinimumWidth = 6;
            this.MoneyAccept.Name = "MoneyAccept";
            this.MoneyAccept.ReadOnly = true;
            this.MoneyAccept.Width = 294;
            // 
            // AdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 546);
            this.Controls.Add(this.grpAdmin);
            this.Name = "AdminEkran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminEkran_FormClosed);
            this.grpAdmin.ResumeLayout(false);
            this.mtabControl.ResumeLayout(false);
            this.mtabPageUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunKontrol)).EndInit();
            this.mtabPara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaKontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdmin;
        private MetroFramework.Controls.MetroTabControl mtabControl;
        private MetroFramework.Controls.MetroTabPage mtabPageUrun;
        private System.Windows.Forms.Button btnCoinEkle;
        private System.Windows.Forms.DataGridView dgvUrunKontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAccept;
        private MetroFramework.Controls.MetroTabPage mtabPara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.DataGridView dgvParaKontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAccept;
    }
}