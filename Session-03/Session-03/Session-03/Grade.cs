using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid Id { get; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int GradeValue { get; set; }

        public Grade(Guid studentId, Guid courseId, int grade)
        {
            Id = Guid.NewGuid();
            StudentId = studentId;
            CourseId = courseId;
            GradeValue = grade;
        }
    }
}
