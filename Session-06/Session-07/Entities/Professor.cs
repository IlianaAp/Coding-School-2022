using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Professor : Person
    {
        public enum Ranks { Full, Associate, Assistant_Professor }
        public Ranks Rank { get; set; }
        public List<Course> Courses { get; set; }

        public Professor()
        {
            Courses = new List<Course>();
        }
        public void SetGrade(Guid studentId, Guid courseId, int grade)
        {

            Grade gradeObj = new Grade(studentId, courseId, grade);
            
        }

        

        public string GetName()
        {
            return "Dr." + Name;
        }

    }
}
