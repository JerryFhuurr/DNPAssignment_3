using System.Text.Json.Serialization;

namespace AdultsClient.Models
{
    public class User
    {
        [JsonPropertyName("username")] public string UserName { get; set; }
        [JsonPropertyName("role")] public string Role { get; set; }
        [JsonPropertyName("securityleve;")] public int SecurityLevel { get; set; }
        [JsonPropertyName("password")] public string Password { get; set; }
    }
}