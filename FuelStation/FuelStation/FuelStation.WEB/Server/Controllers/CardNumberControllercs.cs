using FuelStation.Services;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardNumberController : ControllerBase
    {
        private readonly IFindCustomerWithCardNumber _findCustomer;

        public CardNumberController(IFindCustomerWithCardNumber findCustomer)
        {
            _findCustomer = findCustomer;
        }

        [HttpGet("{cardNumber}")]
        public async Task<CustomerViewModel?> Get(string cardNumber)
        {
            CustomerViewModel customer = new();
            var foundCustomer = await _findCustomer.FindCustomer(cardNumber);
            if (foundCustomer == null)
                return null;
            customer.ID = foundCustomer.ID;
            customer.Name = foundCustomer.Name;
            customer.Surname = foundCustomer.Surname;
            customer.CardNumber = foundCustomer.CardNumber;
            return customer;
        }
    }
}
