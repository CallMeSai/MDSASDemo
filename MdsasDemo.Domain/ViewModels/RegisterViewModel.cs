using System;
using System.ComponentModel.DataAnnotations;

namespace MdsasDemo.Domain.ViewModels
{
    public class RegisterViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "First Name")]
        public string Forename { get; set; }

        [Required]
        [MaxLength(255)]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        //[Remote(action: "VerifyUniqueNumber", controller: "Validation")] // TODO: this will use client side validation
        [Display(Name = "Unique Number")]
        public string UniqueNumber { get; set; }
    }
}