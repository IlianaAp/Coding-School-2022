using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Services
{
    public class ProfessorService : BaseService
    {
        const string FILE_NAME = "StorageProfessors.json";
        public ProfessorService() : base(FILE_NAME)
        {

        }
        public void Teach(Professor professor, Course course, DateTime dateTime)
        {
            for (int i = 0; i < professor.Courses.Count; i++)
            {
                if (professor.Courses[i] == course)
                    break;
                if (professor.Courses[i] == null)
                {
                    professor.Courses[i] = course;
                    break;
                }
            }
        }
       

    }
}
