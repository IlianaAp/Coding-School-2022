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
    public class EmployeeRepo : IEntityRepo<Employee>, IEmployee
    {
        private readonly FuelStationDBContext _context;
        public EmployeeRepo(FuelStationDBContext context)
        {
            _context = context;
        }
        public async Task<string> CreateAsync(Employee entity)
        {
            string result = string.Empty;
            if (entity.ID != Guid.Empty)
            {
                result = $"Given entity should not have Id set {nameof(entity)}";
                return result;
            }
            _context.Employees.Add(entity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Username exists or error occuried on Save";
            }
            return result;
        }

        public async Task<string> DeleteAsync(Guid id)
        {
            string result = string.Empty;
            var foundEntity = _context.Employees.SingleOrDefault(x => x.ID == id);
            if (foundEntity is null)
            {
                result = $"Given id '{id}' was not found in database";
                return result;
            }
            _context.Employees.Remove(foundEntity);
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

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await _context.Employees.SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<Employee>> GetManagersCashiers()
        {
            return await _context.Employees.Where(employee => employee.EmployeeType != Enums.EmployeeType.Staff).ToListAsync();
        }

        public async Task<string> UpdateAsync(Employee entity)
        {
            string result = string.Empty;
            var foundEntity = _context.Employees.SingleOrDefault(x => x.ID == entity.ID);
            if (foundEntity is null)
            {
                result = $"Given id '{entity.ID}' was not found in database";
                return result;
            }
            foundEntity.Surname = entity.Surname;
            foundEntity.Name = entity.Name;
            foundEntity.HireDateStart = entity.HireDateStart;
            foundEntity.HireDateEnd = entity.HireDateEnd;
            foundEntity.SallaryPerMonth=entity.SallaryPerMonth;
            foundEntity.EmployeeType= entity.EmployeeType;
            foundEntity.Username= entity.Username;
            foundEntity.Password= entity.Password;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = "Username already exists or error occuried on Save";
            }
            return result;
        }
    }
}
