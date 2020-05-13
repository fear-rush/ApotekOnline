namespace ApotekOnline
{
    partial class DokterLogin
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
            this.lblDokterUsername = new System.Windows.Forms.Label();
            this.lblDokterPassword = new System.Windows.Forms.Label();
            this.tbDokterPassword = new System.Windows.Forms.TextBox();
            this.tbDokterUsername = new System.Windows.Forms.TextBox();
            this.btDokterLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDokterUsername
            // 
            this.lblDokterUsername.AutoSize = true;
            this.lblDokterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDokterUsername.Location = new System.Drawing.Point(54, 42);
            this.lblDokterUsername.Name = "lblDokterUsername";
            this.lblDokterUsername.Size = new System.Drawing.Size(83, 20);
            this.lblDokterUsername.TabIndex = 1;
            this.lblDokterUsername.Text = "Username";
            // 
            // lblDokterPassword
            // 
            this.lblDokterPassword.AutoSize = true;
            this.lblDokterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDokterPassword.Location = new System.Drawing.Point(54, 70);
            this.lblDokterPassword.Name = "lblDokterPassword";
            this.lblDokterPassword.Size = new System.Drawing.Size(78, 20);
            this.lblDokterPassword.TabIndex = 2;
            this.lblDokterPassword.Text = "Password";
            // 
            // tbDokterPassword
            // 
            this.tbDokterPassword.Location = new System.Drawing.Point(162, 70);
            this.tbDokterPassword.Name = "tbDokterPassword";
            this.tbDokterPassword.Size = new System.Drawing.Size(126, 20);
            this.tbDokterPassword.TabIndex = 3;
            this.tbDokterPassword.UseSystemPasswordChar = true;
            // 
            // tbDokterUsername
            // 
            this.tbDokterUsername.Location = new System.Drawing.Point(162, 44);
            this.tbDokterUsername.Name = "tbDokterUsername";
            this.tbDokterUsername.Size = new System.Drawing.Size(126, 20);
            this.tbDokterUsername.TabIndex = 4;
            this.tbDokterUsername.TextChanged += new System.EventHandler(this.tbDokterUsername_TextChanged);
            // 
            // btDokterLogin
            // 
            this.btDokterLogin.Location = new System.Drawing.Point(162, 96);
            this.btDokterLogin.Name = "btDokterLogin";
            this.btDokterLogin.Size = new System.Drawing.Size(75, 23);
            this.btDokterLogin.TabIndex = 5;
            this.btDokterLogin.Text = "Login";
            this.btDokterLogin.UseVisualStyleBackColor = true;
            this.btDokterLogin.Click += new System.EventHandler(this.btDokterLogin_Click);
            // 
            // DokterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 146);
            this.Controls.Add(this.btDokterLogin);
            this.Controls.Add(this.tbDokterUsername);
            this.Controls.Add(this.tbDokterPassword);
            this.Controls.Add(this.lblDokterPassword);
            this.Controls.Add(this.lblDokterUsername);
            this.Name = "DokterLogin";
            this.Text = "DoctorLogin";
            this.Load += new System.EventHandler(this.DokterLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDokterUsername;
        private System.Windows.Forms.Label lblDokterPassword;
        private System.Windows.Forms.TextBox tbDokterPassword;
        private System.Windows.Forms.TextBox tbDokterUsername;
        private System.Windows.Forms.Button btDokterLogin;
    }
}