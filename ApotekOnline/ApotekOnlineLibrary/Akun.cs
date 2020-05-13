using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekOnlineLibrary
{
    public abstract class Akun
    {
        protected string Username { get; set; }
        protected string Password { get; set; }

        public Akun(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public abstract bool Authentication(string username, string password);
    }
}
