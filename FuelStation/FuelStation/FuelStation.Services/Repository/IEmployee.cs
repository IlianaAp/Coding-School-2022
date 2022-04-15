using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services.Repository
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetManagersCashiers();
    }
}
