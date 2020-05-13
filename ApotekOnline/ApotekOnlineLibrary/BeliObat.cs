using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ApotekOnlineDBLibrary;


namespace ApotekOnlineLibrary
{
    public class BeliObat
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public double Harga { get; set; }
        public int Jumlah { get; set; }

        public double Total { get; set; }

        public string NamaObat { get; set; }

        public BeliObat(string nama, string alamat, double harga, int jumlah, string namaobat)
        {
            this.Nama = nama;
            this.Alamat = alamat;
            this.Jumlah = jumlah;
            this.Harga = harga;
            this.NamaObat = namaobat;


        }
        public double TotalHarga(double harga, int jumlah)
        {
            this.Harga = harga;
            this.Jumlah = jumlah;

            this.Total = this.Harga * this.Jumlah;

            return this.Total;
        }


        
    }
}
