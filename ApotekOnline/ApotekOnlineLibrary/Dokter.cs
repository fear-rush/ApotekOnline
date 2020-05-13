using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekOnlineLibrary
{
    public class Dokter : Akun
    {

        public bool hendra, isnan, robert;
        public Dokter(string username, string password) : base(username, password)
        {
            this.Username = username;
            this.Password = password;
        }


        public override bool Authentication(string username, string password)
        {
            if (this.Username == "hendra" && this.Password == "satu")
                return hendra = true;
            else if (this.Username == "robert" && this.Password == "tiga")
                return robert = true;
            else if (this.Username == "isnan" && this.Password == "dua")
                return isnan = true;

            else
                return false;
        }
       

    }
}
