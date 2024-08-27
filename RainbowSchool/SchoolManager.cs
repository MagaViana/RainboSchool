using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchool
{
    public class SchoolManager
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<Subject> subjects = new List<Subject>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public string GetAllData()
        {
            var data = new List<string>();

            data.Add("Students:");
            students.ForEach(student => data.Add(student.ToString()));

            data.Add("Teachers:");
            teachers.ForEach(teacher => data.Add(teacher.ToString()));

            data.Add("Subjects:");
            subjects.ForEach(subject => data.Add(subject.ToString()));

            return string.Join("\n", data);
        }
    }
}
