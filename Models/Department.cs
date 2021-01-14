using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCday4.Models
{
    public class Department
    {
        public int ID { set; get; }
        [Display(Name = "Department name")]
        [Required]
        public string Name { set; get; }
        
        //Navigation property
        public List<Student> student { set; get; }

    }
}