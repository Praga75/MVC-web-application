using System;
using StudentDatabase.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentDatabase.Repository
{
    public class StudentRepository
    {
        public static List<Student> studentList = new List<Student>();

        static StudentRepository ()
        {
            studentList.Add(new Student(101, "John", "ECE", "Sri Shakthi", 89));
            studentList.Add(new Student(102, "Selvi", "CSE", "Sri Krishna", 92));
            studentList.Add(new Student(131, "Praga", "EEE", "Sri Eswar", 93));
            studentList.Add(new Student(141, "Siva", "ECE", "Sri Shakthi", 82));
        }
        public IEnumerable<Student> GetStudentInfo()
        {
            return studentList;
        }
        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }
    }
}
