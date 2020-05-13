using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekOnlineLibrary
{
    public class Apoteker : Akun
    {
        public Apoteker(string username, string password) : base(username, password)
        {
            this.Username = username;
            this.Password = password;
        }

        public override bool Authentication(string username, string password)
        {

            if (this.Username == "ivan" && this.Password == "lima")
                return true;
            else if (this.Username == "firas" && this.Password == "enam")
                return true;
            else if (this.Username == "raihan" && this.Password == "tujuh")
                return true;

            else
                return false;
        }

    }
}
