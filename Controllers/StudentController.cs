using Microsoft.AspNetCore.Mvc;
using PracticeMidTerm.Models;
using PracticeMidTerm.Services;

namespace PracticeMidTerm.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            return View(students);
        }

        public IActionResult Update(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null) return RedirectToAction("Create");

            var classes = _studentService.GetClasses();
            ViewBag.Student = student;
            return View(classes);
        }


        public IActionResult Create()
        {
            var classes = _studentService.GetClasses();
            return View(classes);
        }

        public IActionResult Save(Student student)
        {
            if (student.Id == 0)
            {
                _studentService.CreateStudent(student);
            }
            else
            {
                _studentService.UpdateStudent(student);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}