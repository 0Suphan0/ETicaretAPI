using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Enitites.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaretAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {

        private readonly ETicaretAPIDbContext _context;


        public WriteRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            // add async...
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            // add range
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {

           var entityEntry= Table.Remove(model);
           return entityEntry.State == EntityState.Deleted;

        }

        
        public bool RemoveRange(List<T> models)
        {

           Table.RemoveRange(models);
           return true;

        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }

        public bool Update(T model)
        {
            var entityEntry= Table.Update(model);

            return entityEntry.State == EntityState.Modified;

        }

        public  async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    }

}
