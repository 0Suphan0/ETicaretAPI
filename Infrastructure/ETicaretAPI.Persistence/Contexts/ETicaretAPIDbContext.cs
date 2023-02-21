using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Enitites;
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

    }
}
