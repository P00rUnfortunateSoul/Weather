
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShirtsShop.Shared;
using System.Net.Http;
using System.Net.Http.Json;



namespace ShirtsShop.Client.Services{
    public class AuthService
    {
        public bool IsAuthenticated { get; private set; }
        public string Role { get; private set;}

        private readonly HttpClient _httpClient;

        private List<User> users = new List<User>{
            new User{Id = 1, Email ="admin@admin.com", Username = "admin", hashedPass = "admin", isAdmin = true},
            new User{Id = 2, Email ="user@user.com", Username = "user", hashedPass = "user", isAdmin = false}
        };

        public void SetAuthentication(bool isAuthenticated)
        {
            IsAuthenticated = isAuthenticated;
        }

        public async Task<bool> checkAuth(string username, string password){
            User user = await _httpClient.GetFromJsonAsync<User>($"api/users/{username}");

            if (user != null){
                if (user.isAdmin){
                    Role = "admin";
                } else {Role = "user";}
                return true;
            } else {return false;}
        }

        public async Task<bool> Register(string email, string username, string password)
        {
            User user = new User {Email = email, Username = username, hashedPass = password, isAdmin = false };
            var result = await _httpClient.PostAsJsonAsync($"api/users", user);
            Role = "user";
            SetAuthentication(true);
            return true;
        }

        public async Task<bool> checkEmail(string email){
            User user = await _httpClient.GetFromJsonAsync<User>($"api/users/mail/{email}");
            if (user != null) return false;
            else return true;
        }

        public async Task<bool> checkUsername(string username){
            User user = await _httpClient.GetFromJsonAsync<User>($"api/users/{username}");
            if (user != null){
                return false;
            } else return true;
        }


    }
}