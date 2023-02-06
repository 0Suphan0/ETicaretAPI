using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Enitites;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 200, Stock = 100 },
                new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 300, Stock = 200 },
                new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 400, Stock = 300 },
                new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 500, Stock = 400 },
                new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 600, Stock = 500 },
            };
    }

}