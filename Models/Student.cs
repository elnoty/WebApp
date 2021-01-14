using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCday4.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Student name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        [Range(18, 30)]
        public int Age { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfigPassword { get; set; }

        //Add a foreign key
        [ForeignKey("Department")]
        public int DeptID { get; set; }

        //Navigational propartiy
        public Department Department { get; set; }

    }
}