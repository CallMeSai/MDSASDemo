using System;
using System.ComponentModel.DataAnnotations;

namespace MdsasDemo.Domain
{
    public class Patient
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Forename { get; set; }

        [StringLength(255)]
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(10)]
        public string UniqueNumber { get; set; }
    }
}