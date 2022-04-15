using FuelStation.Models;
using FuelStation.Services.Repository;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;
        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                Price = x.Price,
                Cost = x.Cost,
                ItemType = (ItemType)x.ItemType
            });
        }

        [HttpGet("{id}")]
        public async Task<ItemViewModel> Get(Guid id)
        {
            ItemViewModel viewModel = new();
            if (id != Guid.Empty)
            {
                var existing = await _itemRepo.GetByIdAsync(id);
                viewModel.ID = existing.ID;
                viewModel.Code = existing.Code;
                viewModel.Description = existing.Description;
                viewModel.Price = existing.Price;
                viewModel.Cost = existing.Cost;
                viewModel.ItemType = (ItemType)existing.ItemType;
            }
            return viewModel;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ItemViewModel viewModel)
        {

            var newItem = new Item()
            {
                ID = viewModel.ID,
                Code = viewModel.Code,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Cost= viewModel.Cost,
                ItemType = (Enums.ItemType)viewModel.ItemType
            };

            var result = await _itemRepo.CreateAsync(newItem);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemViewModel viewModel)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(viewModel.ID);
            if (itemToUpdate is null)
                return NotFound();
            itemToUpdate.Code = viewModel.Code;
            itemToUpdate.Description = viewModel.Description;
            itemToUpdate.Price = viewModel.Price;
            itemToUpdate.Cost = viewModel.Cost;
            itemToUpdate.ItemType = (Enums.ItemType)viewModel.ItemType;
            var result = await _itemRepo.UpdateAsync(itemToUpdate);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var selectedItem = await _itemRepo.GetByIdAsync(id);
            if (selectedItem is null)
                return NotFound();
            var result = await _itemRepo.DeleteAsync(id);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok();
        }
    }
}
