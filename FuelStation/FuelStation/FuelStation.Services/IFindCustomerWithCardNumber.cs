using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services
{
    public interface IFindCustomerWithCardNumber
    {
        Task<Customer> FindCustomer(string cardNumber);
    }
}
