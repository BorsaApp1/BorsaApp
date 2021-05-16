
namespace BorsaApplication
{
    partial class ParaEkle
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
            this.grpParaEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParaEkle = new System.Windows.Forms.TextBox();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.grpParaEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpParaEkle
            // 
            this.grpParaEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.grpParaEkle.Controls.Add(this.label1);
            this.grpParaEkle.Controls.Add(this.txtParaEkle);
            this.grpParaEkle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpParaEkle.Location = new System.Drawing.Point(12, 23);
            this.grpParaEkle.Name = "grpParaEkle";
            this.grpParaEkle.Size = new System.Drawing.Size(420, 186);
            this.grpParaEkle.TabIndex = 29;
            this.grpParaEkle.TabStop = false;
            this.grpParaEkle.Text = "PARA EKLEME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Girilcek Tutar:";
            // 
            // txtParaEkle
            // 
            this.txtParaEkle.Location = new System.Drawing.Point(163, 78);
            this.txtParaEkle.Name = "txtParaEkle";
            this.txtParaEkle.Size = new System.Drawing.Size(144, 32);
            this.txtParaEkle.TabIndex = 0;
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.BackColor = System.Drawing.Color.Lime;
            this.btnParaEkle.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaEkle.Location = new System.Drawing.Point(107, 244);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(212, 54);
            this.btnParaEkle.TabIndex = 31;
            this.btnParaEkle.Text = "PARA EKLE";
            this.btnParaEkle.UseVisualStyleBackColor = false;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // ParaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 340);
            this.Controls.Add(this.grpParaEkle);
            this.Controls.Add(this.btnParaEkle);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParaEkle";
            this.Padding = new System.Windows.Forms.Padding(25, 79, 25, 26);
            this.grpParaEkle.ResumeLayout(false);
            this.grpParaEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpParaEkle;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParaEkle;
    }
}