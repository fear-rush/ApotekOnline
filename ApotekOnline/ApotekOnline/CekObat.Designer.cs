namespace ApotekOnline
{
    partial class CekObat
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
            this.tbDrugSearch = new System.Windows.Forms.TextBox();
            this.lblDaftarObat = new System.Windows.Forms.Label();
            this.dgDrugList = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbBuy = new System.Windows.Forms.GroupBox();
            this.lblBuy = new System.Windows.Forms.Button();
            this.tbDrugTotal = new System.Windows.Forms.TextBox();
            this.tbBuyerDrug = new System.Windows.Forms.TextBox();
            this.tbBuyerAddress = new System.Windows.Forms.TextBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDrugName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrugList)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDrugSearch
            // 
            this.tbDrugSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrugSearch.Location = new System.Drawing.Point(122, 133);
            this.tbDrugSearch.Multiline = true;
            this.tbDrugSearch.Name = "tbDrugSearch";
            this.tbDrugSearch.Size = new System.Drawing.Size(171, 20);
            this.tbDrugSearch.TabIndex = 0;
            this.tbDrugSearch.TextChanged += new System.EventHandler(this.tbDrugSearch_TextChanged);
            // 
            // lblDaftarObat
            // 
            this.lblDaftarObat.AutoSize = true;
            this.lblDaftarObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarObat.Location = new System.Drawing.Point(12, 9);
            this.lblDaftarObat.Name = "lblDaftarObat";
            this.lblDaftarObat.Size = new System.Drawing.Size(155, 31);
            this.lblDaftarObat.TabIndex = 1;
            this.lblDaftarObat.Text = "Daftar Obat";
            // 
            // dgDrugList
            // 
            this.dgDrugList.AllowUserToAddRows = false;
            this.dgDrugList.AllowUserToDeleteRows = false;
            this.dgDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDrugList.Location = new System.Drawing.Point(18, 58);
            this.dgDrugList.Name = "dgDrugList";
            this.dgDrugList.ReadOnly = true;
            this.dgDrugList.Size = new System.Drawing.Size(588, 490);
            this.dgDrugList.TabIndex = 2;
            this.dgDrugList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDrugList_CellContentClick);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(122, 170);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(79, 27);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(10, 29);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(73, 24);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sort by ";
            // 
            // cbxSort
            // 
            this.cbxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.ItemHeight = 16;
            this.cbxSort.Location = new System.Drawing.Point(122, 29);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(171, 24);
            this.cbxSort.TabIndex = 5;
            this.cbxSort.SelectedIndexChanged += new System.EventHandler(this.cbxSort_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(6, 129);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 24);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Nama Obat";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbxSort);
            this.gbSearch.Controls.Add(this.lblSearch);
            this.gbSearch.Controls.Add(this.tbDrugSearch);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.lblSort);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(622, 58);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(321, 212);
            this.gbSearch.TabIndex = 7;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Cari Obat";
            // 
            // gbBuy
            // 
            this.gbBuy.Controls.Add(this.lblBuy);
            this.gbBuy.Controls.Add(this.tbDrugTotal);
            this.gbBuy.Controls.Add(this.tbBuyerDrug);
            this.gbBuy.Controls.Add(this.tbBuyerAddress);
            this.gbBuy.Controls.Add(this.tbBuyerName);
            this.gbBuy.Controls.Add(this.lblTotal);
            this.gbBuy.Controls.Add(this.lblDrugName);
            this.gbBuy.Controls.Add(this.lblAddress);
            this.gbBuy.Controls.Add(this.lblBuyer);
            this.gbBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuy.Location = new System.Drawing.Point(622, 287);
            this.gbBuy.Name = "gbBuy";
            this.gbBuy.Size = new System.Drawing.Size(321, 261);
            this.gbBuy.TabIndex = 8;
            this.gbBuy.TabStop = false;
            this.gbBuy.Text = "Beli Obat";
            // 
            // lblBuy
            // 
            this.lblBuy.Location = new System.Drawing.Point(122, 211);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(79, 27);
            this.lblBuy.TabIndex = 7;
            this.lblBuy.Text = "Beli";
            this.lblBuy.UseVisualStyleBackColor = true;
            this.lblBuy.Click += new System.EventHandler(this.lblBuy_Click);
            // 
            // tbDrugTotal
            // 
            this.tbDrugTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrugTotal.Location = new System.Drawing.Point(122, 175);
            this.tbDrugTotal.Multiline = true;
            this.tbDrugTotal.Name = "tbDrugTotal";
            this.tbDrugTotal.Size = new System.Drawing.Size(171, 20);
            this.tbDrugTotal.TabIndex = 13;
            this.tbDrugTotal.TextChanged += new System.EventHandler(this.tbDrugTotal_TextChanged);
            // 
            // tbBuyerDrug
            // 
            this.tbBuyerDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerDrug.Location = new System.Drawing.Point(122, 126);
            this.tbBuyerDrug.Multiline = true;
            this.tbBuyerDrug.Name = "tbBuyerDrug";
            this.tbBuyerDrug.Size = new System.Drawing.Size(171, 20);
            this.tbBuyerDrug.TabIndex = 12;
            this.tbBuyerDrug.TextChanged += new System.EventHandler(this.tbBuyerDrug_TextChanged);
            // 
            // tbBuyerAddress
            // 
            this.tbBuyerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerAddress.Location = new System.Drawing.Point(122, 77);
            this.tbBuyerAddress.Multiline = true;
            this.tbBuyerAddress.Name = "tbBuyerAddress";
            this.tbBuyerAddress.Size = new System.Drawing.Size(171, 20);
            this.tbBuyerAddress.TabIndex = 11;
            this.tbBuyerAddress.TextChanged += new System.EventHandler(this.tbBuyerAddress_TextChanged);
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerName.Location = new System.Drawing.Point(122, 33);
            this.tbBuyerName.Multiline = true;
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.Size = new System.Drawing.Size(171, 20);
            this.tbBuyerName.TabIndex = 7;
            this.tbBuyerName.TextChanged += new System.EventHandler(this.tbBuyerName_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(13, 171);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 24);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Jumlah";
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrugName.Location = new System.Drawing.Point(13, 126);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(105, 24);
            this.lblDrugName.TabIndex = 9;
            this.lblDrugName.Text = "Nama Obat";
            this.lblDrugName.Click += new System.EventHandler(this.lblDrugName_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 77);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 24);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Alamat";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.Location = new System.Drawing.Point(13, 33);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(60, 24);
            this.lblBuyer.TabIndex = 7;
            this.lblBuyer.Text = "Nama";
            this.lblBuyer.Click += new System.EventHandler(this.label1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // CekObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 594);
            this.Controls.Add(this.gbBuy);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgDrugList);
            this.Controls.Add(this.lblDaftarObat);
            this.Name = "CekObat";
            this.Text = "CekObat";
            this.Load += new System.EventHandler(this.CekObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDrugList)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbBuy.ResumeLayout(false);
            this.gbBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDrugSearch;
        private System.Windows.Forms.Label lblDaftarObat;
        private System.Windows.Forms.DataGridView dgDrugList;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox gbBuy;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDrugName;
        private System.Windows.Forms.Label lblAddress;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox tbBuyerName;
        public System.Windows.Forms.TextBox tbDrugTotal;
        public System.Windows.Forms.TextBox tbBuyerDrug;
        public System.Windows.Forms.TextBox tbBuyerAddress;
        public System.Windows.Forms.Button lblBuy;
    }
}