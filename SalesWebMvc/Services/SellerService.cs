using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<SwmSeller> FindAll()
        {
            return _context.SwmSeller.ToList();
        }

        public void Insert(SwmSeller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<List<SwmSeller>> FindAllAsync()
        {
            return await _context.SwmSeller.Include(obj => obj.SwmDepartment).ToListAsync();
        }

        public async Task InsertAsync(SwmSeller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public SwmSeller FindById(int pid)
        {
            return _context.SwmSeller.Include(obj => obj.SwmDepartment).FirstOrDefault(obj => obj.Id == pid);
        }

        public async Task<SwmSeller> FindByIdAsync(int pid)
        {
            return await _context.SwmSeller.Include(obj => obj.SwmDepartment).FirstOrDefaultAsync(obj => obj.Id == pid);
        }

        public void Remove(int id)
        {
            var obj = _context.SwmSeller.Find(id);
            _context.SwmSeller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(SwmSeller obj)
        {
            if (!_context.SwmSeller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.SwmSeller.FindAsync(id);
                _context.SwmSeller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }

        public async Task UpdateAsync(SwmSeller obj)
        {
            bool hasAny = await _context.SwmSeller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
