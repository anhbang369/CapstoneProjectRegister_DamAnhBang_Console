using CapstoneProjectRegister_DamAnhBang_Console.Repo.EntityModel;
using CapstoneProjectRegister_DamAnhBang_Console.Repo.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_Console.Service.Service
{
    public class StudentService
    {
        private readonly IStudent _studentRepository;

        public StudentService(IStudent studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetStudents();
        }

        public void ShowAllStudentsInConsole()
        {
            IEnumerable<Student> students = _studentRepository.GetStudents();

            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, ...");
            }
        }

    }
}
