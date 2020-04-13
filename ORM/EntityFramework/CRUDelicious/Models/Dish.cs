using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name {get; set;}
        [Required]
        public string chef{get; set;}
        [Required]
        [Range(0,10)]
        public int tastiness{get; set;}
        [Required]
        public int calories{get; set;}
        [Required]
        public string description{get; set;}
    }
}