using Ders_1_.Data;
using Ders_1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders_1_.Controllers
{
    /*Custom Model Binder*/
    public class TimeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;
            string day = request.Form.Get("Day");
            string month = request.Form.Get("Month");
            string year = request.Form.Get("Year");
            string hour = request.Form.Get("Hour");
            string minute = request.Form.Get("Minute");
            string second = request.Form.Get("Second");
            return new DateTime(Convert.ToInt32(day), Convert.ToInt32(month), Convert.ToInt32(year), Convert.ToInt32(hour), Convert.ToInt32(minute),
                Convert.ToInt32(second));
        }
    }
    public class StudentController : Controller
    {
        public ActionResult ListStudents()
        {
            /*View üzerinde gösterilmek istenilen Model return edilen View metodunun parametresi olarak yazılır.*/
            return View(StudentData.Students);
        }
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost] /* Post işlemi yapıldığında çalışacak olan Action */
        public ActionResult CreateStudent(Student student) /*Kontrollere girilen verileri almak için kullanılır.*/
        {
            if(ModelState.IsValid)
            {
                StudentData.Students.Add(student);
                return RedirectToAction("ListStudents");
            }
            return View();
        }

        public ActionResult EditStudent(string id)
        {
            Student selectedStudent = StudentData.Students.Where(s => s.SchoolNumber == id).FirstOrDefault();
            return View(selectedStudent);
        }

        [HttpPost] /* Post işlemi yapıldığında çalışacak olan Action */
        public ActionResult EditStudent(Student student) /*Kontrollere girilen verileri almak için kullanılır.*/
        {
            if(ModelState.IsValid)
            {
                Student editingStudent = StudentData.Students.Where(s => s.SchoolNumber == student.SchoolNumber).FirstOrDefault();
                editingStudent.Name = student.Name;
                editingStudent.Surname = student.Surname;
                editingStudent.IdentityNumber = student.IdentityNumber;
                editingStudent.DepartmentName = student.DepartmentName;
                editingStudent.SchoolTime = student.SchoolTime;
                return RedirectToAction("ListStudents");
            }
            return View(student.SchoolNumber);
        }
        public ActionResult DeleteStudent(string id)
        {
            Student selectedStudent = StudentData.Students.Where(s => s.SchoolNumber == id).FirstOrDefault();
            return View(selectedStudent);
        }

        [HttpPost, ActionName("DeleteStudent")] /* Post işlemi yapıldığında çalışacak olan Action */
        public ActionResult DeleteStudentConfirmed(string id) /*Kontrollere girilen verileri almak için kullanılır.*/
        {
            Student deletingStudent = StudentData.Students.Where(s => s.SchoolNumber == id).FirstOrDefault();
            StudentData.Students.Remove(deletingStudent);
            return RedirectToAction("ListStudents");
        }

        public ActionResult DetailsStudent(string id)
        {
            Student selectedStudent = StudentData.Students.Where(s => s.SchoolNumber == id).FirstOrDefault();
            return View(selectedStudent);
        }
    }
}

