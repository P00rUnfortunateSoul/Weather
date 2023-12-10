
using System.Collections.Generic;
using System.Linq;
using ShirtsShop.Shared;

namespace ShirtsShop.Client.Services{
    public class AuthService
    {
        public bool IsAuthenticated { get; private set; }
        public string Role { get; private set;}

        private List<User> users = new List<User>{
            new User{Id = 1, Email ="admin@admin.com", Username = "admin", hashedPass = "admin", isAdmin = true},
            new User{Id = 2, Email ="user@user.com", Username = "user", hashedPass = "user", isAdmin = false}
        };

        public void SetAuthentication(bool isAuthenticated)
        {
            IsAuthenticated = isAuthenticated;
        }

        public bool checkAuth(string username, string password){
            var user = users.FirstOrDefault(u => u.Username == username && u.hashedPass == password);

            if (user != null){
                if (user.isAdmin){
                    Role = "admin";
                } else {Role = "user";}
                return true;
            } else {return false;}
        }

        public bool Register(string email, string username, string password)
        {
            users.Add(new User {Email = email, Username = username, hashedPass = password, isAdmin = false });
            Role = "user";
            SetAuthentication(true);
            return true;
        }

        public bool checkEmail(string email){
            if (users.Any(u => u.Email == email)) return false;
            else return true;
        }

        public bool checkUsername(string username){
            if (users.Any(u => u.Username == username))
            {
                return false;
            } else return true;
        }


    }
}