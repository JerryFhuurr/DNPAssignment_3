using System.Text.Json.Serialization;

namespace AdultsClient.Models
{
    public class User
    {
        [JsonPropertyName("UserName")] public string UserName { get; set; }
        [JsonPropertyName("Role")] public string Role { get; set; }
        [JsonPropertyName("SecurityLevel")] public int SecurityLevel { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
    }
}