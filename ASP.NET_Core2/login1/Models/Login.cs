using System.ComponentModel.DataAnnotations;
namespace login1.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string LoginEmail{get;set;}
        [Required]
        public string LoginPassword{get;set;}
    }
} 