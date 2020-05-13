using ApotekOnlineDBLibrary;
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
using System.Data.Entity;
namespace ApotekOnline
{
    public partial class PanelApoteker : Form
    {
        public bool cek = true;

        ApotekOnlineContext model = new ApotekOnlineContext();
        DaftarObat dobat = new DaftarObat();
        public PanelApoteker()
        {
            InitializeComponent();
            

            var query1 =
                (from data in model.DaftarObats
                 select data).ToList();

            dgDrugListApotek.DataSource = query1;


            var query2 =
                (from c in model.DaftarReseps
                 select c).ToList();

            dgDaftarResep.DataSource = query2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelApoteker_Load(object sender, EventArgs e)
        {
            Clear();
            
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                dobat.NamaObat = tbUpdateDrug.Text.Trim();
                dobat.Keterangan = tbUpdateInfo.Text.Trim();
                dobat.Harga = int.Parse(tbUpdatePrice.Text.Trim());
                dobat.Stok = int.Parse(tbStok.Text.Trim());
                ApotekOnlineContext db = new ApotekOnlineContext();
                if (cek == true)

                    db.DaftarObats.Add(dobat);

                else
                    db.Entry(dobat).State = EntityState.Modified;


                db.SaveChanges();


                var query =
                        (from data in db.DaftarObats
                         select data).ToList();

                dgDrugListApotek.DataSource = query;
                Clear();
                dgDrugListApotek.Update();
                dgDrugListApotek.Refresh();
            }
            catch(Exception ex) {
                MessageBox.Show("Error, input tidak sesuai \n" + ex);
            }
            

         

          


        }

        

        private void dgDrugListApotek_DoubleClick(object sender, EventArgs e)
        {
            if(dgDrugListApotek.CurrentRow.Index != -1)
            {
                dobat.ObatID = Convert.ToInt32(dgDrugListApotek.CurrentRow.Cells["ObatID"].Value);
                ApotekOnlineContext db = new ApotekOnlineContext();
                dobat = db.DaftarObats.
                    Where(x => x.ObatID == dobat.ObatID).
                    FirstOrDefault();

                tbUpdateDrug.Text = dobat.NamaObat;
                tbUpdateInfo.Text = dobat.Keterangan;
                tbUpdatePrice.Text = Convert.ToString(dobat.Harga);
                tbStok.Text = Convert.ToString(dobat.Stok);
                btAdd.Text = "Update Obat";
                btDelete.Enabled = true;
                cek = false;
                
            }
        }
        void Clear()
        {
            tbUpdateDrug.Text = tbUpdateInfo.Text = tbUpdatePrice.Text = tbStok.Text = "";
            btAdd.Text = "Tambah Obat";
            btDelete.Enabled = false;
            cek = true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah Anda Yakin?", "EF Crud Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ApotekOnlineContext db = new ApotekOnlineContext();
                var entry = db.Entry(dobat);
                if (entry.State == EntityState.Detached)
                    db.DaftarObats.Attach(dobat);
                db.DaftarObats.Remove(dobat);
                db.SaveChanges();
                
                var query =
                    (from data in db.DaftarObats
                     select data).ToList();

                dgDrugListApotek.DataSource = query;
                Clear();
            }
        }

        private void dgDaftarResep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dgDrugListApotek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
