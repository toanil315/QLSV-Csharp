using PracticeMidTerm.Models;

namespace PracticeMidTerm.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student? GetStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        List<Class> GetClasses();
    }
}