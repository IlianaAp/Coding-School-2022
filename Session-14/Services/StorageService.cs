using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services
{
    public class StorageService
    {
        private const string JSON_FILE_NAME = "CarServiceCenterStorage.json";
        
        public ServiceCenter GetSeviceCenter()
        {
            if (File.Exists(JSON_FILE_NAME))
            {
                var json = File.ReadAllText(JSON_FILE_NAME);
                return JsonSerializer.Deserialize<ServiceCenter>(json);
            }
            else
            {
               
                return new ServiceCenter();
            }
        }

        public void SaveServiceCenter(ServiceCenter serviceCenter)
        {
            var json = JsonSerializer.Serialize(serviceCenter);
            File.WriteAllText(JSON_FILE_NAME, json);
        } 

    }
}
