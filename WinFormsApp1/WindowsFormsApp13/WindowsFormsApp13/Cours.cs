using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    internal class Cours
    {
        private List<Student> students = new List<Student>();
        public void EnrollStudent(Student student) => students.Add(student);
        public List<Student> GetStudents() => students;

    }
}
