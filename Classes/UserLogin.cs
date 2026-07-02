using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.Classes
{
    internal class UserLogin
    {

        //اگر init تعریف کنم چمیشه؟ 
        public string Username { get; set; }
        public string Password { get; set; }

        public UserLogin()
        {
            Username = "1";
            Password = "1";
        }
    }
}
