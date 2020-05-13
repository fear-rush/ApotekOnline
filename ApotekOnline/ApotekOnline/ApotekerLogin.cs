using ApotekOnlineLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekOnline
{
    public partial class ApotekerLogin : Form
    {
        public ApotekerLogin()
        {
            InitializeComponent();
        }
        
        private void tbApotekerUsername_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btApotekerLogin_Click(object sender, EventArgs e)
        {
            
            Apoteker apoteker = new Apoteker(tbApotekerUsername.Text, tbApotekerPassword.Text);
            if (apoteker.Authentication(tbApotekerUsername.Text, tbApotekerPassword.Text))
            {
                PanelApoteker panelapoteker = new PanelApoteker();
                this.Hide();
                panelapoteker.Show();
            }
            else
                MessageBox.Show("Username atau Password Salah");
        }

        private void ApotekerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
