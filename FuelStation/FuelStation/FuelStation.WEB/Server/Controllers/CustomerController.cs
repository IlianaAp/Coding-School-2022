using FuelStation.Models;
using FuelStation.Services.Repository;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) 
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            });
        }


        [HttpGet("{id}")]
        public async Task<CustomerViewModel> Get(Guid id)
        {
            CustomerViewModel viewModel = new();
            if (id != Guid.Empty)
            {
                var existing = await _customerRepo.GetByIdAsync(id);
                viewModel.ID = existing.ID;
                viewModel.Name = existing.Name;
                viewModel.Surname = existing.Surname;
                viewModel.CardNumber = existing.CardNumber;
            }
            return viewModel;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(CustomerViewModel viewModel)
        {
            
            var newCustomer = new Customer()
            {
                ID = viewModel.ID,
                Surname = viewModel.Surname,
                Name = viewModel.Name,
                CardNumber = viewModel.CardNumber
            };

            var result = await _customerRepo.CreateAsync(newCustomer);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerViewModel viewModel)
        {
            var customerToUpdate = await _customerRepo.GetByIdAsync(viewModel.ID);
            if (customerToUpdate is null)
                return NotFound();
            customerToUpdate.Name = viewModel.Name;
            customerToUpdate.Surname = viewModel.Surname;
            customerToUpdate.CardNumber = viewModel.CardNumber;
            var result = await _customerRepo.UpdateAsync(customerToUpdate);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var selectedCustomer = await _customerRepo.GetByIdAsync(id);
            if (selectedCustomer is null)
                return NotFound();
            var result = await _customerRepo.DeleteAsync(id);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }
    }
}
