using ApotekOnlineDBLibrary;
using ApotekOnlineLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekOnline
{
    public partial class PanelRequest : Form
    {
        public PanelRequest()
        {
            InitializeComponent();
        }

        private void lblUpdateDrug_Click(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ApotekOnlineContext db = new ApotekOnlineContext();
                if (rbHendra.Checked)
                {

                    Request request = new Request(tbPatientName.Text, tbComplaint.Text);
                    Hendra hendra = new Hendra();
                    hendra.NamaPasien = request.Nama;
                    hendra.Keluhan = request.Keluhan;
                    hendra.Tanggal = DateTime.Now;
                    db.Hendras.Add(hendra);
                    db.SaveChanges();


                }
                else if (rbIsnan.Checked)
                {
                    Request request = new Request(tbPatientName.Text, tbComplaint.Text);
                    Isnan isnan = new Isnan();
                    isnan.NamaPasien = request.Nama;
                    isnan.Keluhan = request.Keluhan;
                    isnan.Tanggal = DateTime.Now;
                    db.Isnans.Add(isnan);
                    db.SaveChanges();
                }
                else if (rbRobert.Checked)
                {
                    Request request = new Request(tbPatientName.Text, tbComplaint.Text);
                    Robert robert = new Robert();
                    robert.NamaPasien = request.Nama;
                    robert.Keluhan = request.Keluhan;
                    robert.Tanggal = DateTime.Now;
                    db.Roberts.Add(robert);
                    db.SaveChanges();
                }


                MessageBox.Show("Request Checkup berhasil");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input tidak sesuai \n" + ex);
            }
        }

        private void PanelRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
