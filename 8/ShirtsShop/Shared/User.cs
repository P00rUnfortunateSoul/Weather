using System;
using System.Collections.Generic;
using System.Text;

namespace ShirtsShop.Shared
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Email { get; set; }
        public string Username { get; set; }
        public string hashedPass {get; set;}

        public bool isAdmin{ get; set; }
    }
}