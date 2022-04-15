using FuelStation.EF.Context;
using FuelStation.Models;
using FuelStation.Services.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly FuelStationDBContext _context;

        public CustomerRepo(FuelStationDBContext context)
        {
            _context = context;
        }
        public async Task<string> CreateAsync(Customer entity)
        {
            string result = string.Empty;
            if (entity.ID != Guid.Empty)
            {
                result = $"Given entity should not have Id set {nameof(entity)}";
                return result;
            }
            _context.Customers.Add(entity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Card Number already exists or error occuried on Save";
            }
            return result;
        }

        public async Task<string> DeleteAsync(Guid id)
        {
            string result = string.Empty;
            var foundEntity = _context.Customers.SingleOrDefault(x => x.ID == id);
            if (foundEntity is null)
            {
                result = $"Given id '{id}' was not found in database";
                return result;
            }
            _context.Customers.Remove(foundEntity);
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

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            return await _context.Customers.SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<string> UpdateAsync(Customer entity)
        {
            string result = string.Empty;
            var foundEntity = _context.Customers.SingleOrDefault(x => x.ID == entity.ID);
            if (foundEntity is null)
            {
                result = $"Given id '{entity.ID}' was not found in database";
                return result;
            }
            foundEntity.Surname = entity.Surname;
            foundEntity.Name = entity.Name;
            foundEntity.CardNumber = entity.CardNumber;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Card Number already exists or error occuried on Save";
            }
            return result;
        }
    }
}
