using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekOnlineLibrary
{
    public class KirimResep
    {
        public string NamaPasien { get; set; }
        public string NamaObat { get; set; }
        public int Jumlah { get; set; }
        public string Keterangan { get; set; }

        public KirimResep(string namapasien, string namaobat, int jumlah, string keterangan)
        {
            this.NamaPasien = namapasien;
            this.NamaObat = namaobat;
            this.Jumlah = jumlah;
            this.Keterangan = keterangan;
        }
    }
}
