using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdultsApi.Models
{
    public class Person
    {
        [Required, Range(0, int.MaxValue), Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The first name field is required.")]
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("HairColor")] public string HairColor { get; set; }
        [JsonPropertyName("EyeColor")] public string EyeColor { get; set; }

        [Range(0, int.MaxValue), Required]
        [JsonPropertyName("Age")]
        public int Age { get; set; }

        [Range(0, int.MaxValue)]
        [JsonPropertyName("Weight")]
        public float Weight { get; set; }

        [Range(0, int.MaxValue)]
        [JsonPropertyName("Height")]
        public int Height { get; set; }

        [Required] [JsonPropertyName("Sex")] public string Sex { get; set; }
    }
}