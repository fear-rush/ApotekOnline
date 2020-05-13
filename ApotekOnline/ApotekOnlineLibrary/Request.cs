using ApotekOnlineDBLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApotekOnlineLibrary
{
    public class Request
    {
        public string Nama { get; set; }
        public string Keluhan { get; set; }

        public  Request(string nama, string keluhan)
        {
            this.Nama = nama;
            this.Keluhan = keluhan;
        }
    }
}
