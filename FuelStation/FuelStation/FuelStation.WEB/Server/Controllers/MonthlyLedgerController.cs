using FuelStation.Services.Calculation;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonthlyLedgerController : ControllerBase
    {
        private readonly IMonthlyLedgerCalc _monthlyLedgerCalc;

        public MonthlyLedgerController(IMonthlyLedgerCalc monthlyLedgerCalc)
        {
            _monthlyLedgerCalc = monthlyLedgerCalc;
        }

        [HttpGet("{year}/{month}/{rent}")]
        public async Task<MonthlyLedgerViewModel> Get(int year, int month, decimal rent)
        {
            MonthlyLedgerViewModel viewModel = new();
            var monthlyLedger = await _monthlyLedgerCalc.CreateMonthlyLedger(year, month, rent);
            viewModel.Year = monthlyLedger.Year;
            viewModel.Month = monthlyLedger.Month;
            viewModel.Income = monthlyLedger.Income;
            viewModel.Expenses = monthlyLedger.Expences;
            viewModel.Total = monthlyLedger.Total;
            return viewModel;
        }
    }
}
