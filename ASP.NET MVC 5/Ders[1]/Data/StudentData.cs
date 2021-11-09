using Ders_1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders_1_.Data
{
    public class StudentData
    {
        public static List<Student> Students = new List<Student>
        {
            new Student
            {
                SchoolNumber = "181312025",
                Name = "Hakan",
                Surname = "ÇELEBİ",
                IdentityNumber = "14501321120",
                DepartmentName = "Bilgisayar Mühendisliği",
                SchoolTime = new DateTime(2018, 9, 27)
            },
            new Student
            {
                SchoolNumber = "201312022",
                Name = "Abdullah",
                Surname = "ALTUNKAYNAK",
                IdentityNumber = "18971448530",
                DepartmentName = "Bilgisayar Mühendisliği",
                SchoolTime = new DateTime(2019, 9, 12)
            }
        };
    }
}