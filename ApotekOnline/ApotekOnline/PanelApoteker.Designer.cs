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
            this.btAdd = new System.Windows.Forms.Button();
            this.lblDaftarResep = new System.Windows.Forms.Label();
            this.dgDaftarResep = new System.Windows.Forms.DataGridView();
            this.lblStok = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
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
            this.dgDrugListApotek.Size = new System.Drawing.Size(685, 203);
            this.dgDrugListApotek.TabIndex = 3;
            this.dgDrugListApotek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDrugListApotek_CellContentClick);
            this.dgDrugListApotek.DoubleClick += new System.EventHandler(this.dgDrugListApotek_DoubleClick);
            // 
            // lblUpdateDrug
            // 
            this.lblUpdateDrug.AutoSize = true;
            this.lblUpdateDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDrug.Location = new System.Drawing.Point(726, 57);
            this.lblUpdateDrug.Name = "lblUpdateDrug";
            this.lblUpdateDrug.Size = new System.Drawing.Size(105, 24);
            this.lblUpdateDrug.TabIndex = 8;
            this.lblUpdateDrug.Text = "Nama Obat";
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.AutoSize = true;
            this.lblUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInfo.Location = new System.Drawing.Point(724, 96);
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
            this.lblUpdatePrice.Location = new System.Drawing.Point(724, 145);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(61, 24);
            this.lblUpdatePrice.TabIndex = 11;
            this.lblUpdatePrice.Text = "Harga";
            // 
            // tbUpdatePrice
            // 
            this.tbUpdatePrice.Location = new System.Drawing.Point(868, 150);
            this.tbUpdatePrice.Multiline = true;
            this.tbUpdatePrice.Name = "tbUpdatePrice";
            this.tbUpdatePrice.Size = new System.Drawing.Size(171, 20);
            this.tbUpdatePrice.TabIndex = 12;
            // 
            // tbUpdateInfo
            // 
            this.tbUpdateInfo.Location = new System.Drawing.Point(868, 101);
            this.tbUpdateInfo.Multiline = true;
            this.tbUpdateInfo.Name = "tbUpdateInfo";
            this.tbUpdateInfo.Size = new System.Drawing.Size(171, 20);
            this.tbUpdateInfo.TabIndex = 14;
            // 
            // tbUpdateDrug
            // 
            this.tbUpdateDrug.Location = new System.Drawing.Point(868, 62);
            this.tbUpdateDrug.Multiline = true;
            this.tbUpdateDrug.Name = "tbUpdateDrug";
            this.tbUpdateDrug.Size = new System.Drawing.Size(171, 20);
            this.tbUpdateDrug.TabIndex = 15;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(728, 234);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(99, 27);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Tambah Obat";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lblDaftarResep
            // 
            this.lblDaftarResep.AutoSize = true;
            this.lblDaftarResep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarResep.Location = new System.Drawing.Point(12, 285);
            this.lblDaftarResep.Name = "lblDaftarResep";
            this.lblDaftarResep.Size = new System.Drawing.Size(175, 31);
            this.lblDaftarResep.TabIndex = 17;
            this.lblDaftarResep.Text = "Daftar Resep";
            // 
            // dgDaftarResep
            // 
            this.dgDaftarResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDaftarResep.Location = new System.Drawing.Point(18, 356);
            this.dgDaftarResep.Name = "dgDaftarResep";
            this.dgDaftarResep.Size = new System.Drawing.Size(685, 158);
            this.dgDaftarResep.TabIndex = 18;
            this.dgDaftarResep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDaftarResep_CellContentClick);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStok.Location = new System.Drawing.Point(724, 191);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(46, 24);
            this.lblStok.TabIndex = 19;
            this.lblStok.Text = "Stok";
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(868, 196);
            this.tbStok.Multiline = true;
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(171, 20);
            this.tbStok.TabIndex = 20;
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(868, 19);
            this.tbTanggal.Multiline = true;
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.ReadOnly = true;
            this.tbTanggal.Size = new System.Drawing.Size(171, 20);
            this.tbTanggal.TabIndex = 21;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(726, 18);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(110, 20);
            this.lblTanggal.TabIndex = 22;
            this.lblTanggal.Text = "last update on";
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(849, 234);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(85, 27);
            this.btDelete.TabIndex = 24;
            this.btDelete.Text = "Hapus Obat";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(954, 234);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(85, 27);
            this.btCancel.TabIndex = 25;
            this.btCancel.Text = "Batal";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(725, 273);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(339, 13);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Double click pada obat yang dipilih untuk update obat dan hapus obat";
            // 
            // PanelApoteker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 599);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.dgDaftarResep);
            this.Controls.Add(this.lblDaftarResep);
            this.Controls.Add(this.btAdd);
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
            this.Load += new System.EventHandler(this.PanelApoteker_Load);
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
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblDaftarResep;
        private System.Windows.Forms.DataGridView dgDaftarResep;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lblInfo;
    }
}