using System.ComponentModel.DataAnnotations;
namespace FormSubmission2.Models
{
    public class User
    {
        [Required]
        [DataType(DataType.Text)]
        public string FirstName{get;set;}
        [Required]
        [DataType(DataType.Text)]
        public string LastName{get;set;}
        [Required]
        public int Age{get;set;}
    }
}