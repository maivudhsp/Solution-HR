using HR.LeaveManagement.Application.Contacts;
using HR.LeaveManagement.Domain.Common;
using HR.LeaveManagement.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repository
{
    public class GenericRepositiry<T> : IGenericRepository<T> where T : BaseEntity
    {
        private HrDatabaseContext _context;
        public GenericRepositiry(HrDatabaseContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
             await _context.AddAsync(entity);
             await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
