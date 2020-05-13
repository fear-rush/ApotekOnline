using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekOnline
{
    public partial class Fitur : Form
    {
        public Fitur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelRequest request = new PanelRequest();
            request.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CekObat cekobat = new CekObat();
            cekobat.Show();
        }
    }
}
