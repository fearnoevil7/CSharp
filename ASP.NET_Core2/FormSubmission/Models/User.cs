using System.ComponentModel.DataAnnotations;
using FormSubmission.Utilities;
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        [DataType(DataType.Text)]
        [Display(Name = "Your name here: ")]
        public string FirstName{get;set;}
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        [DataType(DataType.Text)]
        public string LastName{get;set;}
        [Required(ErrorMessage = "Age is required")]
        [Range(0, 120)]
        [ValidAge]
        [DataType(DataType.Text)]
        [Display(Name = "Age")]
        public int Age{get;set;}
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email{get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}