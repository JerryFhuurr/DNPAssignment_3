using System;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdultsClient.Models;

namespace AdultsClient.Data
{
    public class UserWebService : IUserService
    {
        private string uri = "https://localhost:44380";
        
        // private string uri = "http://jsonplaceholder.typicode.com";
        private readonly HttpClient client;
        
        public UserWebService()
        {
            client = new HttpClient();
        }
        public async Task<User> ValidateUser(string userName, string password)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = password;
            user.SecurityLevel = 1;
            user.Role = "notNull";
            
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync($"{uri}/Login/UserLogin", content);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.ReasonPhrase);
                Console.WriteLine(response.ToString());
                throw new AuthenticationException($"{response.ReasonPhrase}");
            }
            
            string message = await response.Content.ReadAsStringAsync();
            var loggedInUser = JsonSerializer.Deserialize<User>(message);

            if (loggedInUser == null)
            {
                throw new AuthenticationException("User not logged in - user null");
            }
            
            return loggedInUser;
        }
    }
}