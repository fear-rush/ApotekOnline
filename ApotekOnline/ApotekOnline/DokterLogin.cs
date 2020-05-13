using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApotekOnlineLibrary;

namespace ApotekOnline
{
    public partial class DokterLogin : Form
    {
        public int id;
        public DokterLogin()
        {
            InitializeComponent();
        }

        private void tbDokterUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDokterLogin_Click(object sender, EventArgs e)
        {
            Dokter dokter = new Dokter(tbDokterUsername.Text, tbDokterPassword.Text);
            if (dokter.Authentication(tbDokterUsername.Text, tbDokterPassword.Text))
            {
               
                PanelDokter panel = new PanelDokter(dokter);
                this.Hide();
                panel.Show();
                
            }
            else
                MessageBox.Show("Username atau Password Salah");


        }

        private void DokterLogin_Load(object sender, EventArgs e)
        {

        }
    

    }
}
