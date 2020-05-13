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

    public partial class CekObat : Form
    {
        public string Nama = "";
        public string Alamat = "";
        public string NamaObat = "";
        public string Jumlah = "";
        public string Harga = "";
        public CekObat()
        {
            InitializeComponent();
            cbxSort.Items.Add("Nama (Ascending)");
            cbxSort.Items.Add("Nama (Descending)");
            cbxSort.Items.Add("Harga Tertinggi");
            cbxSort.Items.Add("Harga Terendah");
            cbxSort.Items.Add("Obat ID");
            cbxSort.DropDownStyle = ComboBoxStyle.DropDownList;

            ApotekOnlineContext model = new ApotekOnlineContext();

            var query =
                (from data in model.DaftarObats
                 select data).ToList();

            dgDrugList.DataSource = query;

        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSort.Text == "Nama (Ascending)")
            {
                ApotekOnlineContext model = new ApotekOnlineContext();


                var query =
                    (from a in model.DaftarObats
                     orderby a.NamaObat
                     select a).ToList();

                dgDrugList.DataSource = query;
                    
            }
            else if (cbxSort.Text == "Nama (Descending)")
            {
                ApotekOnlineContext model = new ApotekOnlineContext();


                var query =
                    (from a in model.DaftarObats
                     orderby a.NamaObat descending
                     select a).ToList();

                dgDrugList.DataSource = query;

            }
            if (cbxSort.Text == "Harga Tertinggi")
            {
                ApotekOnlineContext model = new ApotekOnlineContext();


                var query =
                    (from a in model.DaftarObats
                     orderby a.Harga descending
                     select a).ToList();

                dgDrugList.DataSource = query;

            }
            if (cbxSort.Text == "Harga Terendah")
            {
                ApotekOnlineContext model = new ApotekOnlineContext();


                var query =
                    (from a in model.DaftarObats
                     orderby a.Harga
                     select a).ToList();

                dgDrugList.DataSource = query;

            }
            if (cbxSort.Text == "Obat ID")
            {
                ApotekOnlineContext model = new ApotekOnlineContext();


                var query =
                    (from a in model.DaftarObats
                     orderby a.ObatID
                     select a).ToList();

                dgDrugList.DataSource = query;

            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            ApotekOnlineContext model = new ApotekOnlineContext();

            if ((from a in model.DaftarObats where a.NamaObat == tbDrugSearch.Text select a).Any())
            {
                var query = (from a in model.DaftarObats
                             where a.NamaObat == tbDrugSearch.Text
                             select a).ToList();

                dgDrugList.DataSource = query;
            }
            else
                MessageBox.Show("Obat tidak ditemukan");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void dgDrugList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CekObat_Load(object sender, EventArgs e)
        {

        }

        private void tbDrugSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void lblBuy_Click(object sender, EventArgs e)
        {
            try
            {
                ApotekOnlineContext buy = new ApotekOnlineContext();
                DaftarObat daftar = new DaftarObat();

                double query =
                     (from c in buy.DaftarObats
                      where c.NamaObat == tbBuyerDrug.Text
                      select c.Harga).Sum();




                BeliObat beliobat = new BeliObat(tbBuyerName.Text, tbBuyerAddress.Text, query, int.Parse(tbDrugTotal.Text), tbBuyerDrug.Text);
                double sum = beliobat.TotalHarga(query, int.Parse(tbDrugTotal.Text));
                MessageBox.Show(sum.ToString());


                Konfirmasi konfirmasi = new Konfirmasi(beliobat);
                Nama = tbBuyerName.Text;
                Alamat = tbBuyerAddress.Text;
                NamaObat = tbBuyerDrug.Text;
                Jumlah = tbDrugTotal.Text;
                Harga = sum.ToString();
                konfirmasi.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input tidak sesuai \n" + ex);
            }

           
           


            

        }

        private void tbBuyerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuyerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuyerDrug_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDrugTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDrugName_Click(object sender, EventArgs e)
        {

        }
    }
}
