namespace ApotekOnline
{
    partial class Login
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
            this.btDokter = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btApoteker = new System.Windows.Forms.Button();
            this.btPasien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDokter
            // 
            this.btDokter.Location = new System.Drawing.Point(17, 124);
            this.btDokter.Name = "btDokter";
            this.btDokter.Size = new System.Drawing.Size(101, 38);
            this.btDokter.TabIndex = 0;
            this.btDokter.Text = "Dokter";
            this.btDokter.UseVisualStyleBackColor = true;
            this.btDokter.Click += new System.EventHandler(this.btDokter_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(410, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Selamat Datang di Aplikasi Apotek Online";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(80, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(276, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Anda Ingin Login Sebagai : ";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btApoteker
            // 
            this.btApoteker.Location = new System.Drawing.Point(169, 124);
            this.btApoteker.Name = "btApoteker";
            this.btApoteker.Size = new System.Drawing.Size(101, 38);
            this.btApoteker.TabIndex = 3;
            this.btApoteker.Text = "Apoteker";
            this.btApoteker.UseVisualStyleBackColor = true;
            this.btApoteker.Click += new System.EventHandler(this.btApoteker_Click);
            // 
            // btPasien
            // 
            this.btPasien.Location = new System.Drawing.Point(321, 124);
            this.btPasien.Name = "btPasien";
            this.btPasien.Size = new System.Drawing.Size(101, 38);
            this.btPasien.TabIndex = 4;
            this.btPasien.Text = "Pasien";
            this.btPasien.UseVisualStyleBackColor = true;
            this.btPasien.Click += new System.EventHandler(this.btPasien_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 187);
            this.Controls.Add(this.btPasien);
            this.Controls.Add(this.btApoteker);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btDokter);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDokter;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btApoteker;
        private System.Windows.Forms.Button btPasien;
    }
}