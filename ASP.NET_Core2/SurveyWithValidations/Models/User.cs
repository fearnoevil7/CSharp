using System.ComponentModel.DataAnnotations;
namespace SurveyWithValidations.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string Name{get;set;}
        [Required]
        [DataType(DataType.Text)]
        public string Location{get;set;}
        [Required]
        [DataType(DataType.Text)]
        public string Language{get;set;}
        [MinLength(8)]
        [DataType(DataType.Text)]
        public string Comment{get;set;}
    }
}