using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services.Calculation
{
    public interface IMonthlyLedgerCalc 
    {
        Task<MonthlyLedger> CreateMonthlyLedger(int year, int month, decimal rent);
    }
}
