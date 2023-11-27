
using System.ComponentModel.DataAnnotations;

namespace SampleApplication.Models
{
    public class CompanyDTO
    {
     
        public int CompNo { get; set; }
        [Required]
        public string? CompanyName { get; set; }
        public string? CompanyLocation { get; set; }
        public string? CompanyWebsite { get; set; }
    }
}
