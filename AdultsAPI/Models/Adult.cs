using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdultsApi.Models
{
    public class Adult : Person
    {
        [JsonPropertyName("JobTitle")] public Job JobTitle { get; set; }
    }
}