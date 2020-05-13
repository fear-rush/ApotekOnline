namespace ApotekOnline
{
    partial class PanelRequest
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
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.tbComplaint = new System.Windows.Forms.TextBox();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.rbHendra = new System.Windows.Forms.RadioButton();
            this.rbIsnan = new System.Windows.Forms.RadioButton();
            this.rbRobert = new System.Windows.Forms.RadioButton();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(23, 21);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(122, 24);
            this.lblPatientName.TabIndex = 9;
            this.lblPatientName.Text = "Nama Pasien";
            this.lblPatientName.Click += new System.EventHandler(this.lblUpdateDrug_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(23, 118);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(167, 24);
            this.lblSchedule.TabIndex = 10;
            this.lblSchedule.Text = "Pilih Jadwal Dokter";
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(23, 69);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(80, 24);
            this.lblComplaint.TabIndex = 11;
            this.lblComplaint.Text = "Keluhan";
            // 
            // tbComplaint
            // 
            this.tbComplaint.Location = new System.Drawing.Point(203, 69);
            this.tbComplaint.Multiline = true;
            this.tbComplaint.Name = "tbComplaint";
            this.tbComplaint.Size = new System.Drawing.Size(243, 20);
            this.tbComplaint.TabIndex = 16;
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(203, 25);
            this.tbPatientName.Multiline = true;
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(243, 20);
            this.tbPatientName.TabIndex = 17;
            // 
            // rbHendra
            // 
            this.rbHendra.AutoSize = true;
            this.rbHendra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHendra.Location = new System.Drawing.Point(27, 160);
            this.rbHendra.Name = "rbHendra";
            this.rbHendra.Size = new System.Drawing.Size(209, 24);
            this.rbHendra.TabIndex = 18;
            this.rbHendra.TabStop = true;
            this.rbHendra.Text = "dr. Hendra (08.00 - 10.00)";
            this.rbHendra.UseVisualStyleBackColor = true;
            // 
            // rbIsnan
            // 
            this.rbIsnan.AutoSize = true;
            this.rbIsnan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIsnan.Location = new System.Drawing.Point(27, 201);
            this.rbIsnan.Name = "rbIsnan";
            this.rbIsnan.Size = new System.Drawing.Size(196, 24);
            this.rbIsnan.TabIndex = 19;
            this.rbIsnan.TabStop = true;
            this.rbIsnan.Text = "dr. Isnan (10.00 - 12.00)";
            this.rbIsnan.UseVisualStyleBackColor = true;
            // 
            // rbRobert
            // 
            this.rbRobert.AutoSize = true;
            this.rbRobert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRobert.Location = new System.Drawing.Point(27, 245);
            this.rbRobert.Name = "rbRobert";
            this.rbRobert.Size = new System.Drawing.Size(197, 24);
            this.rbRobert.TabIndex = 20;
            this.rbRobert.TabStop = true;
            this.rbRobert.Text = "dr. Robert (12.00-14.00)";
            this.rbRobert.UseVisualStyleBackColor = true;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(27, 289);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(89, 31);
            this.btConfirm.TabIndex = 21;
            this.btConfirm.Text = "Konfirmasi";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // PanelRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 346);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.rbRobert);
            this.Controls.Add(this.rbIsnan);
            this.Controls.Add(this.rbHendra);
            this.Controls.Add(this.tbPatientName);
            this.Controls.Add(this.tbComplaint);
            this.Controls.Add(this.lblComplaint);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblPatientName);
            this.Name = "PanelRequest";
            this.Text = "PanelRequest";
            this.Load += new System.EventHandler(this.PanelRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.TextBox tbComplaint;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.RadioButton rbHendra;
        private System.Windows.Forms.RadioButton rbIsnan;
        private System.Windows.Forms.RadioButton rbRobert;
        private System.Windows.Forms.Button btConfirm;
    }
}