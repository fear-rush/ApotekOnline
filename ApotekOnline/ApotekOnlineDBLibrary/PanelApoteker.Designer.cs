namespace ApotekOnline
{
    partial class PanelApoteker
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
            this.lblDaftarObat = new System.Windows.Forms.Label();
            this.dgDrugListApotek = new System.Windows.Forms.DataGridView();
            this.lblUpdateDrug = new System.Windows.Forms.Label();
            this.lblUpdateInfo = new System.Windows.Forms.Label();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.tbUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbUpdateInfo = new System.Windows.Forms.TextBox();
            this.tbUpdateDrug = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.lblDaftarResep = new System.Windows.Forms.Label();
            this.dgDaftarResep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrugListApotek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDaftarResep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDaftarObat
            // 
            this.lblDaftarObat.AutoSize = true;
            this.lblDaftarObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarObat.Location = new System.Drawing.Point(12, 9);
            this.lblDaftarObat.Name = "lblDaftarObat";
            this.lblDaftarObat.Size = new System.Drawing.Size(155, 31);
            this.lblDaftarObat.TabIndex = 2;
            this.lblDaftarObat.Text = "Daftar Obat";
            // 
            // dgDrugListApotek
            // 
            this.dgDrugListApotek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDrugListApotek.Location = new System.Drawing.Point(18, 58);
            this.dgDrugListApotek.Name = "dgDrugListApotek";
            this.dgDrugListApotek.Size = new System.Drawing.Size(502, 158);
            this.dgDrugListApotek.TabIndex = 3;
            // 
            // lblUpdateDrug
            // 
            this.lblUpdateDrug.AutoSize = true;
            this.lblUpdateDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDrug.Location = new System.Drawing.Point(543, 58);
            this.lblUpdateDrug.Name = "lblUpdateDrug";
            this.lblUpdateDrug.Size = new System.Drawing.Size(105, 24);
            this.lblUpdateDrug.TabIndex = 8;
            this.lblUpdateDrug.Text = "Nama Obat";
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.AutoSize = true;
            this.lblUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInfo.Location = new System.Drawing.Point(543, 97);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Size = new System.Drawing.Size(107, 24);
            this.lblUpdateInfo.TabIndex = 9;
            this.lblUpdateInfo.Text = "Keterangan";
            this.lblUpdateInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePrice.Location = new System.Drawing.Point(543, 147);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(61, 24);
            this.lblUpdatePrice.TabIndex = 11;
            this.lblUpdatePrice.Text = "Harga";
            // 
            // tbUpdatePrice
            // 
            this.tbUpdatePrice.Location = new System.Drawing.Point(675, 151);
            this.tbUpdatePrice.Multiline = true;
            this.tbUpdatePrice.Name = "tbUpdatePrice";
            this.tbUpdatePrice.Size = new System.Drawing.Size(171, 20);
            this.tbUpdatePrice.TabIndex = 12;
            // 
            // tbUpdateInfo
            // 
            this.tbUpdateInfo.Location = new System.Drawing.Point(675, 102);
            this.tbUpdateInfo.Multiline = true;
            this.tbUpdateInfo.Name = "tbUpdateInfo";
            this.tbUpdateInfo.Size = new System.Drawing.Size(171, 20);
            this.tbUpdateInfo.TabIndex = 14;
            // 
            // tbUpdateDrug
            // 
            this.tbUpdateDrug.Location = new System.Drawing.Point(675, 63);
            this.tbUpdateDrug.Multiline = true;
            this.tbUpdateDrug.Name = "tbUpdateDrug";
            this.tbUpdateDrug.Size = new System.Drawing.Size(171, 20);
            this.tbUpdateDrug.TabIndex = 15;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(675, 189);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(79, 27);
            this.btUpdate.TabIndex = 16;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // lblDaftarResep
            // 
            this.lblDaftarResep.AutoSize = true;
            this.lblDaftarResep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarResep.Location = new System.Drawing.Point(12, 250);
            this.lblDaftarResep.Name = "lblDaftarResep";
            this.lblDaftarResep.Size = new System.Drawing.Size(175, 31);
            this.lblDaftarResep.TabIndex = 17;
            this.lblDaftarResep.Text = "Daftar Resep";
            // 
            // dgDaftarResep
            // 
            this.dgDaftarResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDaftarResep.Location = new System.Drawing.Point(18, 296);
            this.dgDaftarResep.Name = "dgDaftarResep";
            this.dgDaftarResep.Size = new System.Drawing.Size(502, 158);
            this.dgDaftarResep.TabIndex = 18;
            // 
            // PanelApoteker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 512);
            this.Controls.Add(this.dgDaftarResep);
            this.Controls.Add(this.lblDaftarResep);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbUpdateDrug);
            this.Controls.Add(this.tbUpdateInfo);
            this.Controls.Add(this.tbUpdatePrice);
            this.Controls.Add(this.lblUpdatePrice);
            this.Controls.Add(this.lblUpdateInfo);
            this.Controls.Add(this.lblUpdateDrug);
            this.Controls.Add(this.dgDrugListApotek);
            this.Controls.Add(this.lblDaftarObat);
            this.Name = "PanelApoteker";
            this.Text = "PanelApoteker";
            ((System.ComponentModel.ISupportInitialize)(this.dgDrugListApotek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDaftarResep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaftarObat;
        private System.Windows.Forms.DataGridView dgDrugListApotek;
        private System.Windows.Forms.Label lblUpdateDrug;
        private System.Windows.Forms.Label lblUpdateInfo;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.TextBox tbUpdatePrice;
        private System.Windows.Forms.TextBox tbUpdateInfo;
        private System.Windows.Forms.TextBox tbUpdateDrug;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label lblDaftarResep;
        private System.Windows.Forms.DataGridView dgDaftarResep;
    }
}