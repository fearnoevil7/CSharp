using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Login.Models
{
    public class User
    {
        [Key]
        public int id {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "First name must be atleast 2 characters long")]
        public string firstName{get; set;}
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be atleast 2 characters long")]
        public string lastName{get;set;}
        [Required]
        [EmailAddress]
        public string email{get;set;}
        [Required]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters long")]
        public string password{get;set;}
        [NotMapped]
        [Required]
        [Compare("password")]
        public string confirmPassword{get;set;}
    }
}