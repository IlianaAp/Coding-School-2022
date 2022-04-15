using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services
{
    public class FindCustomerWithCardNumber : IFindCustomerWithCardNumber
    {
        private readonly FuelStationDBContext _context;

        public FindCustomerWithCardNumber(FuelStationDBContext context)
        {
            _context = context;
        }
        public async Task<Customer> FindCustomer(string cardNumber)
        {
            return await _context.Customers.Where(customer => customer.CardNumber == cardNumber).FirstOrDefaultAsync();
        }
    }
}
