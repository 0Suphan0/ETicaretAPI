using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Enitites;
using ETicaretAPI.Domain.Enitites.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Contexts
{

    // Db context match database...
    public class ETicaretAPIDbContext :DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options):base(options)
        {
            //bu ıoc containerda doldurulacak...
        }

        // Product Table
        public DbSet<Product> Products { get; set; }

        //Order Table
        public DbSet<Order> Orders { get; set; }

        //Customer table
        public DbSet<Customer> Customers { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {

            //SaveChangesAsyncInterceptor yapısı


            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added=>data.Entity.CreatedTime=DateTime.UtcNow, //state'i added olanların created dateNı ata.
                    EntityState.Modified=>data.Entity.UpdatedTime=DateTime.UtcNow // updated olanların ise updateddate'ine ata. 
                
                };


            }




            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
