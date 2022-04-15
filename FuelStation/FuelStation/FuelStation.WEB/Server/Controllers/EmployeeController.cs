using FuelStation.Models;
using FuelStation.Services.Repository;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEmployee _employee;
        public EmployeeController(IEntityRepo<Employee> employeeRepo, IEmployee employee)
        {
            _employeeRepo = employeeRepo;
            _employee = employee;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeViewModel>> Get()
        {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                HireDateEnd = x.HireDateEnd,
                HireDateStart = x.HireDateStart,
                SallaryPerMonth = x.SallaryPerMonth,
                EmployeeType = (EmployeeType)x.EmployeeType,
                Username = x.Username,
                Password = x.Password
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeViewModel> Get(Guid id)
        {
            EmployeeViewModel viewModel = new();
            viewModel.HireDateStart = DateTime.Now;
            if (id != Guid.Empty)
            {
                var existing = await _employeeRepo.GetByIdAsync(id);
                viewModel.ID = existing.ID;
                viewModel.Name = existing.Name;
                viewModel.Surname = existing.Surname;
                viewModel.HireDateEnd = existing.HireDateEnd;
                viewModel.HireDateStart = existing.HireDateStart;
                viewModel.SallaryPerMonth = existing.SallaryPerMonth;
                viewModel.EmployeeType = (EmployeeType)existing.EmployeeType;
                viewModel.Username = existing.Username;
                viewModel.Password = existing.Password;
            }
            return viewModel;
        }

        [HttpGet]
        [Route("[Action]")]
        public async Task<IEnumerable<EmployeeViewModel>> GetManagersCashiers()
        {
            var result = await _employee.GetManagersCashiers();
            return result.Select(x => new EmployeeViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                HireDateEnd = x.HireDateEnd,
                HireDateStart = x.HireDateStart,
                SallaryPerMonth = x.SallaryPerMonth,
                EmployeeType = (EmployeeType)x.EmployeeType,
                Username = x.Username,
                Password = x.Password
            });
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeViewModel viewModel)
        {

            var newEmployee = new Employee()
            {
                ID = viewModel.ID,
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                HireDateEnd = viewModel.HireDateEnd,
                HireDateStart = viewModel.HireDateStart,
                SallaryPerMonth = viewModel.SallaryPerMonth,
                EmployeeType = (Models.Enums.EmployeeType)viewModel.EmployeeType,
                Username = viewModel.Username,
                Password = viewModel.Password
            };

            var result = await _employeeRepo.CreateAsync(newEmployee);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeViewModel viewModel)
        {
            var employeeToUpdate = await _employeeRepo.GetByIdAsync(viewModel.ID);
            if (employeeToUpdate is null)
                return NotFound();
            employeeToUpdate.Name = viewModel.Name;
            employeeToUpdate.Surname = viewModel.Surname;
            employeeToUpdate.HireDateEnd = viewModel.HireDateEnd;
            employeeToUpdate.HireDateStart = viewModel.HireDateStart;
            employeeToUpdate.SallaryPerMonth = viewModel.SallaryPerMonth;
            employeeToUpdate.EmployeeType = (Models.Enums.EmployeeType)viewModel.EmployeeType;
            employeeToUpdate.Username = viewModel.Username;
            employeeToUpdate.Password = viewModel.Password;
            var result = await _employeeRepo.UpdateAsync( employeeToUpdate);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var selectedEmployee = await _employeeRepo.GetByIdAsync(id);
            if (selectedEmployee is null)
                return NotFound();
            var result = await _employeeRepo.DeleteAsync(id);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }
    }
}
