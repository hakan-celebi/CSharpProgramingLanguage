using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders_1_.Models
{
    public class Student
    {
        [Required]
        [DisplayName("School Number")]
        public string SchoolNumber { get; set; }
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [DisplayName("Student Surname")]
        public string Surname { get; set; }
        [Required]
        [Editable(false)]
        [DisplayName("Identity Number")]
        public string IdentityNumber { get; set; }
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd.MM.yyyy}")]
        [DisplayName("School Year")]
        public DateTime SchoolTime { get; set; }
    }
}