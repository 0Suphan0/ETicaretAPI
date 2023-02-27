using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Enitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
           //await _productWriteRepository.AddRangeAsync(new()
           // {
           //     new Product
           //     {
           //         Id = Guid.NewGuid(), Name = "Product 1", CreatedTime = DateTime.UtcNow, Price = 100, Stock = 5
           //     },
           //     new Product
           //     {
           //         Id = Guid.NewGuid(), Name = "Product 2", CreatedTime = DateTime.UtcNow, Price = 200, Stock = 15
           //     },
           //     new Product
           //     {
           //         Id = Guid.NewGuid(), Name = "Product 3", CreatedTime = DateTime.UtcNow, Price = 300, Stock = 25
           //     },
           // });


           var p= await _productReadRepository.GetByIdAsync("53578154-d186-405a-bf31-61365e18db7a",false);
           p.Name = "mehmet";

            _productWriteRepository.SaveAsync();
        }
    }
}
