using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Routing.Matching;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-Mail is required.")]
        public String? Email {get; set; } = String.Empty;
        [Required(ErrorMessage ="First Name is required.")]
        public String? Firstname {get; set; } = String.Empty;
        [Required(ErrorMessage ="Last Name is required.")]
        public String? Lastname {get; set; } = String.Empty;
        public string FullName => $"{Firstname} {Lastname}".Trim();
        public int? Age {get; set; } 
        public String? SelectedCourse {get; set; } = String.Empty;
        public DateTime ApplyAt {get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}