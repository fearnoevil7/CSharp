using System.ComponentModel.DataAnnotations;
namespace login1.Models
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        public string FirstName{get;set;}
        [Required]
        [MinLength(2)]
        public string LastName{get;set;}
        [Required]
        [EmailAddress]
        public string Email{get;set;}
        [Required]
        [MinLength(8)]
        public string Password{get;set;}
        public string ConfirmPassword{get;set;}
    }
}