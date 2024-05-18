﻿using HR.LeaveManagement.Application.Contacts;
using HR.LeaveManagement.Domain.Common;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repository
{
    public class GenericRepositiry<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected HrDatabaseContext _context;
        public GenericRepositiry(HrDatabaseContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
             await _context.AddAsync(entity);
             await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = GetByIdAsync(id);
            if(entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
           
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
