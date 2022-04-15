using FuelStation.EF.Context;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly FuelStationDBContext _context;

        public AuthController(FuelStationDBContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Post(UserViewModel viewModel)
        {
            var user = _context.Employees.FirstOrDefault(x => x.Username == viewModel.Username && x.Password == viewModel.Password);
            if(user == null)
            {
                return Unauthorized();
            }
            return Ok(user.EmployeeType);
        }

    }
}
