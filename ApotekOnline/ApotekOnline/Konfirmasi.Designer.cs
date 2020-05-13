namespace ApotekOnline
{
    partial class Konfirmasi
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
            this.lblConfirmName = new System.Windows.Forms.Label();
            this.lblConfirmAddress = new System.Windows.Forms.Label();
            this.lblConfirmDrugName = new System.Windows.Forms.Label();
            this.lblConfirmTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbDrug = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmName
            // 
            this.lblConfirmName.AutoSize = true;
            this.lblConfirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmName.Location = new System.Drawing.Point(16, 19);
            this.lblConfirmName.Name = "lblConfirmName";
            this.lblConfirmName.Size = new System.Drawing.Size(60, 24);
            this.lblConfirmName.TabIndex = 11;
            this.lblConfirmName.Text = "Nama";
            // 
            // lblConfirmAddress
            // 
            this.lblConfirmAddress.AutoSize = true;
            this.lblConfirmAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmAddress.Location = new System.Drawing.Point(16, 63);
            this.lblConfirmAddress.Name = "lblConfirmAddress";
            this.lblConfirmAddress.Size = new System.Drawing.Size(67, 24);
            this.lblConfirmAddress.TabIndex = 12;
            this.lblConfirmAddress.Text = "Alamat";
            // 
            // lblConfirmDrugName
            // 
            this.lblConfirmDrugName.AutoSize = true;
            this.lblConfirmDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDrugName.Location = new System.Drawing.Point(16, 150);
            this.lblConfirmDrugName.Name = "lblConfirmDrugName";
            this.lblConfirmDrugName.Size = new System.Drawing.Size(105, 24);
            this.lblConfirmDrugName.TabIndex = 13;
            this.lblConfirmDrugName.Text = "Nama Obat";
            // 
            // lblConfirmTotal
            // 
            this.lblConfirmTotal.AutoSize = true;
            this.lblConfirmTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmTotal.Location = new System.Drawing.Point(16, 104);
            this.lblConfirmTotal.Name = "lblConfirmTotal";
            this.lblConfirmTotal.Size = new System.Drawing.Size(71, 24);
            this.lblConfirmTotal.TabIndex = 14;
            this.lblConfirmTotal.Text = "Jumlah";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 190);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(107, 24);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Harga";
            // 
            // tbDrug
            // 
            this.tbDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrug.Location = new System.Drawing.Point(128, 154);
            this.tbDrug.Multiline = true;
            this.tbDrug.Name = "tbDrug";
            this.tbDrug.ReadOnly = true;
            this.tbDrug.Size = new System.Drawing.Size(171, 20);
            this.tbDrug.TabIndex = 16;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(128, 67);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(171, 20);
            this.tbAddress.TabIndex = 17;
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(128, 104);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(171, 20);
            this.tbTotal.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(128, 23);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(171, 20);
            this.tbName.TabIndex = 19;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(129, 194);
            this.tbTotalPrice.Multiline = true;
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(171, 20);
            this.tbTotalPrice.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 160);
            this.label2.TabIndex = 21;
            this.label2.Text = "Silakan transfer sebesar nominal\r\nyang telah tertera ke rekening :\r\n\r\nBNI : 31924" +
    "1\r\nBRI : 1314124\r\nMandiri : 4234234\r\n\r\nTekan Sudah jika telah melakukan transaks" +
    "i";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sudah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbDrug);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblConfirmTotal);
            this.Controls.Add(this.lblConfirmDrugName);
            this.Controls.Add(this.lblConfirmAddress);
            this.Controls.Add(this.lblConfirmName);
            this.Name = "Konfirmasi";
            this.Text = "Konfirmasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmName;
        private System.Windows.Forms.Label lblConfirmAddress;
        private System.Windows.Forms.Label lblConfirmDrugName;
        private System.Windows.Forms.Label lblConfirmTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tbDrug;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}