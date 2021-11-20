using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace AdultsApi.Models
{
    public class Job
    {
        [Required(ErrorMessage = "Please enter job position."), Key]
        [JsonPropertyName("JobTitle")]
        public string JobTitle { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Please enter a positive number.")]
        [JsonPropertyName("Salary")]
        public int Salary { get; set; }
    }
}