using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreSqlDb.Models
{
    public class Employee
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [RegularExpression ("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage="Invalid Email format")]
        public string Email {get; set;}

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public string Address {get; set;}
    }
}

