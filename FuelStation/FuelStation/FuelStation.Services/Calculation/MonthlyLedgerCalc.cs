using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services.Calculation
{
    public class MonthlyLedgerCalc : IMonthlyLedgerCalc
    {
        private readonly FuelStationDBContext _context;

        public MonthlyLedgerCalc(FuelStationDBContext context)
        {
            _context = context;
        }

        public async Task<MonthlyLedger> CreateMonthlyLedger(int year, int month, decimal rent)
        {
            MonthlyLedger monthlyLedger = new MonthlyLedger();
            monthlyLedger.Year = year;
            monthlyLedger.Month = month;
            monthlyLedger.Income = decimal.Round(await CalculateIncome(year, month),2);
            monthlyLedger.Expences = decimal.Round(await CalculateExpenses(year, month, rent),2);
            monthlyLedger.Total = monthlyLedger.Income - monthlyLedger.Expences;
            return monthlyLedger;
            
        }

        private async Task<decimal> CalculateIncome(int year, int month)
        {
            return await _context.Transactions.Where(transaction => transaction.Date.Year == year && transaction.Date.Month == month).SumAsync(transaction => transaction.TotalValue);
        }

        private async Task<decimal> CalculateExpenses(int year, int month, decimal rent)
        {
            var t = new DateTime(year, month, 1);
            var employeelist = await _context.Employees.Where(employee => (employee.HireDateStart.Year <= t.Year && employee.HireDateStart.Month <= t.Month) && (employee.HireDateEnd == null || employee.HireDateEnd >= t)).ToListAsync();
            decimal expenses = 0;
            foreach (var employee in employeelist)
            {
                if (employee.HireDateEnd.HasValue &&(employee.HireDateEnd.Value.Month == t.Month && employee.HireDateEnd.Value.Year == t.Year) && employee.HireDateStart.Month == t.Month && employee.HireDateStart.Year == t.Year)
                {
                    decimal sallaryPerDay = employee.SallaryPerMonth / 28;
                    int days = employee.HireDateEnd.Value.Day - employee.HireDateStart.Day;
                    expenses += days * sallaryPerDay;
                }
                else if (employee.HireDateEnd.HasValue && employee.HireDateEnd.Value.Month == t.Month && employee?.HireDateEnd.Value.Year == t.Year)
                {
                    decimal sallaryPerDay = employee.SallaryPerMonth / 28;
                    expenses += employee.HireDateEnd.Value.Day * sallaryPerDay;
                }
                else if (employee.HireDateStart.Month == t.Month && employee.HireDateStart.Year == t.Year)
                {
                    decimal sallaryPerDay = employee.SallaryPerMonth / 28;
                    int days = 28 - employee.HireDateStart.Day;
                    expenses += sallaryPerDay * days;
                }
                else 
                {
                    expenses += employee.SallaryPerMonth;               
                }
            }
            return expenses + rent;
        }
    }
}
