using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApotekOnlineDBLibrary;
using ApotekOnlineLibrary;

namespace ApotekOnline
{
    public partial class Konfirmasi : Form
    {

        public Konfirmasi(BeliObat d)
        {
            InitializeComponent();

            tbName.Text = d.Nama;
            tbAddress.Text = d.Alamat;
            tbDrug.Text = d.NamaObat;
            tbTotal.Text = d.Jumlah.ToString();
            tbTotalPrice.Text = d.Total.ToString();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih telah berbelanja di Apotek Online");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
