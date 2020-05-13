namespace ApotekOnline
{
    partial class ApotekerLogin
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
            this.lblApotekerUsername = new System.Windows.Forms.Label();
            this.lblApotekerPassword = new System.Windows.Forms.Label();
            this.tbApotekerUsername = new System.Windows.Forms.TextBox();
            this.tbApotekerPassword = new System.Windows.Forms.TextBox();
            this.btApotekerLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApotekerUsername
            // 
            this.lblApotekerUsername.AutoSize = true;
            this.lblApotekerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApotekerUsername.Location = new System.Drawing.Point(37, 44);
            this.lblApotekerUsername.Name = "lblApotekerUsername";
            this.lblApotekerUsername.Size = new System.Drawing.Size(83, 20);
            this.lblApotekerUsername.TabIndex = 0;
            this.lblApotekerUsername.Text = "Username";
            // 
            // lblApotekerPassword
            // 
            this.lblApotekerPassword.AutoSize = true;
            this.lblApotekerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApotekerPassword.Location = new System.Drawing.Point(37, 74);
            this.lblApotekerPassword.Name = "lblApotekerPassword";
            this.lblApotekerPassword.Size = new System.Drawing.Size(78, 20);
            this.lblApotekerPassword.TabIndex = 1;
            this.lblApotekerPassword.Text = "Password";
            // 
            // tbApotekerUsername
            // 
            this.tbApotekerUsername.Location = new System.Drawing.Point(165, 44);
            this.tbApotekerUsername.Name = "tbApotekerUsername";
            this.tbApotekerUsername.Size = new System.Drawing.Size(126, 20);
            this.tbApotekerUsername.TabIndex = 2;
            this.tbApotekerUsername.TextChanged += new System.EventHandler(this.tbApotekerUsername_TextChanged_1);
            // 
            // tbApotekerPassword
            // 
            this.tbApotekerPassword.Location = new System.Drawing.Point(165, 76);
            this.tbApotekerPassword.Name = "tbApotekerPassword";
            this.tbApotekerPassword.Size = new System.Drawing.Size(126, 20);
            this.tbApotekerPassword.TabIndex = 3;
            this.tbApotekerPassword.UseSystemPasswordChar = true;
            // 
            // btApotekerLogin
            // 
            this.btApotekerLogin.Location = new System.Drawing.Point(165, 111);
            this.btApotekerLogin.Name = "btApotekerLogin";
            this.btApotekerLogin.Size = new System.Drawing.Size(75, 23);
            this.btApotekerLogin.TabIndex = 4;
            this.btApotekerLogin.Text = "Login";
            this.btApotekerLogin.UseVisualStyleBackColor = true;
            this.btApotekerLogin.Click += new System.EventHandler(this.btApotekerLogin_Click);
            // 
            // ApotekerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 166);
            this.Controls.Add(this.btApotekerLogin);
            this.Controls.Add(this.tbApotekerPassword);
            this.Controls.Add(this.tbApotekerUsername);
            this.Controls.Add(this.lblApotekerPassword);
            this.Controls.Add(this.lblApotekerUsername);
            this.Name = "ApotekerLogin";
            this.Text = "ApotekerLogin";
            this.Load += new System.EventHandler(this.ApotekerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApotekerUsername;
        private System.Windows.Forms.Label lblApotekerPassword;
        private System.Windows.Forms.TextBox tbApotekerUsername;
        private System.Windows.Forms.TextBox tbApotekerPassword;
        private System.Windows.Forms.Button btApotekerLogin;
    }
}