using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MaxServiceTasksPerDay
    {
        public int GetMaxDailyServiceTasks()
        {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();
            return serviceCenter.Engineers.Count();
        }
    }
}
