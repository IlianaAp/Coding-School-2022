using CarServiceCenterLibrary;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services
{
    public class MaxDailyWorkLoad
    {
        private const decimal WORK_HOURS = 8;

        public decimal GetMaxDailyWorkload()
        {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();
            var engineers = serviceCenter.Engineers;
            return engineers.Count() * WORK_HOURS;
        }
    }
}
