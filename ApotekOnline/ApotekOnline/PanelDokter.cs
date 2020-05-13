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
    public partial class PanelDokter : Form
    {
        

        public PanelDokter(Dokter d)
        {
            InitializeComponent();
            ApotekOnlineContext db = new ApotekOnlineContext();

            if (d.hendra == true)
            {
                var query =
                (from p in db.Hendras
                 select p).ToList();

                dgPatientList.DataSource = query;
            }
            else if (d.isnan == true)
            {
                var query =
                (from p in db.Isnans
                 select p).ToList();

                dgPatientList.DataSource = query;
            }
            else if (d.robert == true)
            {
                var query =
                (from p in db.Roberts
                 select p).ToList();

                dgPatientList.DataSource = query;
            }
           

        }

    
        private void dgPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PanelDokter_Load(object sender, EventArgs e)
        {
            
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                ApotekOnlineContext db = new ApotekOnlineContext();
                KirimResep kirim = new KirimResep(tbDoctorPatientName.Text, tbDoctorDrugName.Text, int.Parse(tbDoctorDrugTotal.Text), tbDoctorDrugInfo.Text);
                DaftarResep resep = new DaftarResep();
                resep.NamaPasien = kirim.NamaPasien;
                resep.NamaObat = kirim.NamaObat;
                resep.Jumlah = kirim.Jumlah;
                resep.Keterangan = kirim.Keterangan;

                db.DaftarReseps.Add(resep);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input tidak sesuai \n" + ex);
            }
        }
    }
}
