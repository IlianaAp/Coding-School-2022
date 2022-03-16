using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class UniversityService
    {
        public void SetSchedule(University uni, Guid courseId, Guid professorId, DateTime datetime)
        {
            Schedule scheduleObj = new Schedule(courseId, professorId, datetime);
            uni.ScheduledCourses.Add(scheduleObj);
        }

    }
}
