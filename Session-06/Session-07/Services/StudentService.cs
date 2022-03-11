using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class StudentService : BaseService
    {
        const string FILE_NAME = "StorageStudents.json";
        public StudentService() : base(FILE_NAME)
        {

        }

        public void Attend(Student student, Course course, DateTime datetime)
        {
            for (int i = 0; i < student.Courses.Count; i++)
            {
                if (student.Courses[i] == course)
                    break;
                if (student.Courses[i] == null)
                {
                    student.Courses[i] = course;
                    break;
                }
            }
        }
        private void WriteExam(Student student, Course course, DateTime datetime)
        {

        }
    }
}
