using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Schedule
    {
        public Guid Id { get; }
        public Guid ProfessorId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule(Guid professorId, Guid courseId, DateTime datetime)
        {
            Id = Guid.NewGuid();
            ProfessorId = professorId;
            CourseId = courseId;
            Callendar = datetime;
        }
    }
}
