namespace ApotekOnline
{
    partial class PanelDokter
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
            this.lblDaftarPasien = new System.Windows.Forms.Label();
            this.dgPatientList = new System.Windows.Forms.DataGridView();
            this.lblDoctorPatientName = new System.Windows.Forms.Label();
            this.lblDoctorDrugName = new System.Windows.Forms.Label();
            this.lblDoctorDrugTotal = new System.Windows.Forms.Label();
            this.lblDoctorDrugInfo = new System.Windows.Forms.Label();
            this.tbDoctorDrugInfo = new System.Windows.Forms.TextBox();
            this.tbDoctorDrugTotal = new System.Windows.Forms.TextBox();
            this.tbDoctorDrugName = new System.Windows.Forms.TextBox();
            this.tbDoctorPatientName = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDaftarPasien
            // 
            this.lblDaftarPasien.AutoSize = true;
            this.lblDaftarPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarPasien.Location = new System.Drawing.Point(12, 18);
            this.lblDaftarPasien.Name = "lblDaftarPasien";
            this.lblDaftarPasien.Size = new System.Drawing.Size(179, 31);
            this.lblDaftarPasien.TabIndex = 3;
            this.lblDaftarPasien.Text = "Daftar Pasien";
            // 
            // dgPatientList
            // 
            this.dgPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatientList.Location = new System.Drawing.Point(18, 68);
            this.dgPatientList.Name = "dgPatientList";
            this.dgPatientList.Size = new System.Drawing.Size(502, 225);
            this.dgPatientList.TabIndex = 4;
            this.dgPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatientList_CellContentClick);
            // 
            // lblDoctorPatientName
            // 
            this.lblDoctorPatientName.AutoSize = true;
            this.lblDoctorPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorPatientName.Location = new System.Drawing.Point(538, 68);
            this.lblDoctorPatientName.Name = "lblDoctorPatientName";
            this.lblDoctorPatientName.Size = new System.Drawing.Size(122, 24);
            this.lblDoctorPatientName.TabIndex = 9;
            this.lblDoctorPatientName.Text = "Nama Pasien";
            // 
            // lblDoctorDrugName
            // 
            this.lblDoctorDrugName.AutoSize = true;
            this.lblDoctorDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorDrugName.Location = new System.Drawing.Point(538, 112);
            this.lblDoctorDrugName.Name = "lblDoctorDrugName";
            this.lblDoctorDrugName.Size = new System.Drawing.Size(105, 24);
            this.lblDoctorDrugName.TabIndex = 10;
            this.lblDoctorDrugName.Text = "Nama Obat";
            // 
            // lblDoctorDrugTotal
            // 
            this.lblDoctorDrugTotal.AutoSize = true;
            this.lblDoctorDrugTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorDrugTotal.Location = new System.Drawing.Point(538, 159);
            this.lblDoctorDrugTotal.Name = "lblDoctorDrugTotal";
            this.lblDoctorDrugTotal.Size = new System.Drawing.Size(71, 24);
            this.lblDoctorDrugTotal.TabIndex = 11;
            this.lblDoctorDrugTotal.Text = "Jumlah";
            // 
            // lblDoctorDrugInfo
            // 
            this.lblDoctorDrugInfo.AutoSize = true;
            this.lblDoctorDrugInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorDrugInfo.Location = new System.Drawing.Point(538, 205);
            this.lblDoctorDrugInfo.Name = "lblDoctorDrugInfo";
            this.lblDoctorDrugInfo.Size = new System.Drawing.Size(107, 24);
            this.lblDoctorDrugInfo.TabIndex = 12;
            this.lblDoctorDrugInfo.Text = "Keterangan";
            // 
            // tbDoctorDrugInfo
            // 
            this.tbDoctorDrugInfo.Location = new System.Drawing.Point(666, 210);
            this.tbDoctorDrugInfo.Multiline = true;
            this.tbDoctorDrugInfo.Name = "tbDoctorDrugInfo";
            this.tbDoctorDrugInfo.Size = new System.Drawing.Size(171, 20);
            this.tbDoctorDrugInfo.TabIndex = 16;
            // 
            // tbDoctorDrugTotal
            // 
            this.tbDoctorDrugTotal.Location = new System.Drawing.Point(666, 164);
            this.tbDoctorDrugTotal.Multiline = true;
            this.tbDoctorDrugTotal.Name = "tbDoctorDrugTotal";
            this.tbDoctorDrugTotal.Size = new System.Drawing.Size(171, 20);
            this.tbDoctorDrugTotal.TabIndex = 17;
            // 
            // tbDoctorDrugName
            // 
            this.tbDoctorDrugName.Location = new System.Drawing.Point(666, 117);
            this.tbDoctorDrugName.Multiline = true;
            this.tbDoctorDrugName.Name = "tbDoctorDrugName";
            this.tbDoctorDrugName.Size = new System.Drawing.Size(171, 20);
            this.tbDoctorDrugName.TabIndex = 18;
            // 
            // tbDoctorPatientName
            // 
            this.tbDoctorPatientName.Location = new System.Drawing.Point(666, 68);
            this.tbDoctorPatientName.Multiline = true;
            this.tbDoctorPatientName.Name = "tbDoctorPatientName";
            this.tbDoctorPatientName.Size = new System.Drawing.Size(171, 20);
            this.tbDoctorPatientName.TabIndex = 19;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(666, 250);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(88, 28);
            this.btSend.TabIndex = 20;
            this.btSend.Text = "Kirim Resep";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // PanelDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 337);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbDoctorPatientName);
            this.Controls.Add(this.tbDoctorDrugName);
            this.Controls.Add(this.tbDoctorDrugTotal);
            this.Controls.Add(this.tbDoctorDrugInfo);
            this.Controls.Add(this.lblDoctorDrugInfo);
            this.Controls.Add(this.lblDoctorDrugTotal);
            this.Controls.Add(this.lblDoctorDrugName);
            this.Controls.Add(this.lblDoctorPatientName);
            this.Controls.Add(this.dgPatientList);
            this.Controls.Add(this.lblDaftarPasien);
            this.Name = "PanelDokter";
            this.Text = "PanelDokter";
            this.Load += new System.EventHandler(this.PanelDokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaftarPasien;
        private System.Windows.Forms.DataGridView dgPatientList;
        private System.Windows.Forms.Label lblDoctorPatientName;
        private System.Windows.Forms.Label lblDoctorDrugName;
        private System.Windows.Forms.Label lblDoctorDrugTotal;
        private System.Windows.Forms.Label lblDoctorDrugInfo;
        private System.Windows.Forms.TextBox tbDoctorDrugInfo;
        private System.Windows.Forms.TextBox tbDoctorDrugTotal;
        private System.Windows.Forms.TextBox tbDoctorDrugName;
        private System.Windows.Forms.TextBox tbDoctorPatientName;
        private System.Windows.Forms.Button btSend;
    }
}