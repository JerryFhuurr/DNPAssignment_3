using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AdultsApi.Models
{
    public class Adult : Person
    {
        [JsonPropertyName("JobTitle")]  public Job Job { get; set; }
    }
}