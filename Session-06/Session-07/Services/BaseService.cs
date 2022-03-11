using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BaseService
    {
        private string _fileName;
        public BaseService(string fileName)
        {
            _fileName = fileName;
        }
        public void Save( string json)
        {
            File.WriteAllText(_fileName, json);
        }

        public string Get()
        {
            if (File.Exists(_fileName))
                return File.ReadAllText(_fileName);
            else
                return string.Empty;
        }
    }
}
