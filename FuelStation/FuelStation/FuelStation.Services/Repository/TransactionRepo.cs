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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly FuelStationDBContext _context;
        public TransactionRepo(FuelStationDBContext context)
        {
            _context = context;
        }
        public async Task<string> CreateAsync(Transaction entity)
        {
            string result = string.Empty;
            if (entity.ID != Guid.Empty)
            {
                result = $"Given entity should not have Id set {nameof(entity)}";
                return result;
            }
            _context.TransactionLines.AddRange(entity.TransactionLines);
            _context.Transactions.Add(entity);
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
            var foundEntity = _context.Transactions.SingleOrDefault(x => x.ID == id);
            if (foundEntity is null)
            {
                result = $"Given id '{id}' was not found in database";
                return result;
            }
            _context.Transactions.Remove(foundEntity);
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

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions.Include(transaction => transaction.Employee).Include(transaction => transaction.Customer).ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await _context.Transactions.Include(transaction => transaction.Employee).Include(transaction => transaction.Customer).Include(transaction => transaction.TransactionLines).ThenInclude(x => x.Item).SingleOrDefaultAsync(transaction => transaction.ID == id);
        }

        public async Task<string> UpdateAsync(Transaction entity)
        {
            string result = string.Empty;
            var foundEntity = await _context.Transactions.Include(x => x.TransactionLines).Where(x => x.ID == entity.ID).FirstOrDefaultAsync();

            foundEntity.EmployeeID = entity.EmployeeID;
            foundEntity.TransactionLines = entity.TransactionLines;
            foundEntity.Date = entity.Date;
            foundEntity.PaymentMethod = entity.PaymentMethod;
            foundEntity.TotalValue = entity.TotalValue;


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
    }
}
