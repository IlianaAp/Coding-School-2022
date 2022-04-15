using FuelStation.Models;
using FuelStation.Services.Repository;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> Get()
        {
            var result = await _transactionRepo.GetAllAsync();
            return result.Select(x => new TransactionViewModel
            {
                ID = x.ID,
                Date = x.Date,
                CustomerID = x.CustomerID,
                Customer = new CustomerViewModel
                {
                    ID = x.Customer.ID,
                    Name = x.Customer.Name,
                    Surname = x.Customer.Surname,
                    CardNumber = x.Customer.CardNumber
                },
                EmployeeID = x.EmployeeID,
                PaymentMethod = (PaymentMethod)x.PaymentMethod,
                TotalValue = x.TotalValue,
                CustomerName = string.Join(" ",x.Customer.Surname,x.Customer.Name) ,
                EmployeeName = string.Join(" ", x.Employee.Surname, x.Employee.Name)
            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionViewModel> Get(Guid id)
        {

            TransactionViewModel viewModel = new();
            if (id != Guid.Empty)
            {
                var existing = await _transactionRepo.GetByIdAsync(id);
                viewModel.ID = existing.ID;
                viewModel.Customer = new CustomerViewModel
                {
                    ID = existing.Customer.ID,
                    Name = existing.Customer.Name,
                    Surname = existing.Customer.Surname,
                    CardNumber= existing.Customer.CardNumber
                };
                viewModel.CustomerID = existing.CustomerID;
                viewModel.EmployeeID = existing.EmployeeID;
                viewModel.PaymentMethod = (PaymentMethod)existing.PaymentMethod;
                viewModel.TotalValue = existing.TotalValue;
                viewModel.Date = existing.Date;
                viewModel.TransactionLineViewModels = existing.TransactionLines.Select(x => new TransactionLineViewModel
                {
                    ID = x.ID,
                    ItemDescription = x.Item.Description,
                    DiscountPercent = x.DiscountPercent,
                    DiscountValue = x.DiscountValue,
                    ItemID = x.ItemID,
                    ItemPrice = x.Item.Price,
                    NetValue = x.NetValue,
                    Quantity = x.Quantity,
                    TotalValue = x.TotalValue,
                    TransactionID = x.TransactionID

                }).ToList();
            }
            return viewModel;
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransactionViewModel viewModel)
        {

            var newTransaction = new Transaction()
            {
                ID = viewModel.ID,
                CustomerID = viewModel.CustomerID,
                EmployeeID = viewModel.EmployeeID,
                Date = viewModel.Date,
                TotalValue = viewModel.TotalValue,
                PaymentMethod = (Enums.PaymentMethod)viewModel.PaymentMethod,
                TransactionLines = viewModel.TransactionLineViewModels.Select(x => new TransactionLine
                {
                    ID = x.ID,
                    ItemID = x.ItemID,
                    DiscountPercent = x.DiscountPercent,
                    DiscountValue = x.DiscountValue,
                    ItemPrice = x.ItemPrice,
                    NetValue = x.NetValue,
                    Quantity = x.Quantity,
                    TotalValue = x.TotalValue,
                    TransactionID = x.TransactionID
                }).ToList()

            };
            var result = await _transactionRepo.CreateAsync(newTransaction);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(TransactionViewModel viewModel)
        {
            var trans = new Transaction();
            trans.ID = viewModel.ID;
            trans.TotalValue = viewModel.TotalValue;
            trans.TotalValue = viewModel.TotalValue;
            trans.CustomerID = viewModel.CustomerID;
            trans.Date = viewModel.Date;
            trans.EmployeeID = viewModel.EmployeeID;
            trans.PaymentMethod = (Enums.PaymentMethod)viewModel.PaymentMethod;
            trans.TransactionLines = viewModel.TransactionLineViewModels.Select(x => new TransactionLine
            {
                ID = x.ID,
                ItemID = x.ItemID,
                DiscountPercent = x.DiscountPercent,
                DiscountValue = x.DiscountValue,
                ItemPrice = x.ItemPrice,
                NetValue = x.NetValue,
                Quantity = x.Quantity,
                TotalValue = x.TotalValue,
                TransactionID = x.TransactionID
            }).ToList();
            var result = await _transactionRepo.UpdateAsync(trans);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            
            var result = await _transactionRepo.DeleteAsync(id);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }
    }
}
