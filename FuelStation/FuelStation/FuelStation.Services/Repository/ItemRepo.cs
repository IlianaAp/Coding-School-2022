using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services.Repository
{
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly FuelStationDBContext _context;
        public ItemRepo(FuelStationDBContext context)
        {
            _context = context;
        }
        public async Task<string> CreateAsync(Item entity)
        {
            string result = string.Empty;
            if (entity.ID != Guid.Empty)
            {
                result = $"Given entity should not have Id set {nameof(entity)}";
                return result;
            }
            _context.Items.Add(entity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Code already exists or error occuried on Save";
            }
            return result;
        }

        public async Task<string> DeleteAsync(Guid id)
        {
            string result = string.Empty;
            var foundEntity = _context.Items.SingleOrDefault(x => x.ID == id);
            if (foundEntity is null)
            {
                result = $"Given id '{id}' was not found in database";
                return result;
            }
            _context.Items.Remove(foundEntity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Error occuried on SaveChanges";
            }
            return result;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await _context.Items.SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<string> UpdateAsync(Item entity)
        {
            string result = string.Empty;
            var foundEntity = _context.Items.SingleOrDefault(x => x.ID == entity.ID);
            if (foundEntity is null)
            {
                result = $"Given id '{entity.ID}' was not found in database";
                return result;
            }
            foundEntity.Code = entity.Code;
            foundEntity.Description = entity.Description;
            foundEntity.ItemType = entity.ItemType;
            foundEntity.Price = entity.Price;
            foundEntity.Cost = entity.Cost;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Code already exists or error occuried on Save";
            }
            return result;
        }
    }
}
