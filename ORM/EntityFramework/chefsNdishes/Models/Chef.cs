using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using chefsNdishes.Models;
namespace chefsNdishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        [Display(Name = "First Name: ")]
        public string FirstName {get;set;}
        [Required]
        [Display(Name = "Last Name: ")]
        public string LastName {get;set;}
        [Required]
        [Display(Name = "Birthday: ")]
        public DateTime Birthday {get;set;}
        
        public List<Dish> CreatedDishes {get;set;}
    }
}