using System;
using System.Collections.Generic;
using System.Text;

namespace BoulderBeta.Models
{
    class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string EmailAdress { get; set; }
        public bool LoggedIn { get; set; }

        public User(int userid, string username, string userpass, string email, bool loggedin)
        {
            this.UserID = userid;
            this.UserName = username;
            this.UserPassword = userpass;
            this.EmailAdress = email;
            this.LoggedIn = loggedin;
        }
    }
}
