using Microsoft.EntityFrameworkCore;
using PracticeMidTerm.Models;

namespace PracticeMidTerm.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var existedStudent = GetStudentById(id);
            if (existedStudent == null) return;
            _context.Students.Remove(existedStudent);
            _context.SaveChanges();
        }

        public List<Class> GetClasses()
        {
            return _context.Class.ToList();
        }

        public Student? GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(p => p.Id == id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students
                .Include(p => p.Class)
                .ToList();
        }

        public void UpdateStudent(Student student)
        {
            var existedStudent = GetStudentById(student.Id);
            if (existedStudent == null) return;
            existedStudent.Name = student.Name;
            existedStudent.Age = student.Age;
            existedStudent.Birthday = student.Birthday;
            existedStudent.ClassId = student.ClassId;
            _context.Students.Update(existedStudent);
            _context.SaveChanges();
        }
    }

}