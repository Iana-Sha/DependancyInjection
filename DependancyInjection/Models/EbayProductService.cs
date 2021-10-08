using DependancyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyInjection.Models
{
    public class EbayProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
               new Product() { Id = 2001, Name = "Apple iPhone Pro", Price = 249.00m },
                new Product() { Id = 2002, Name = "Sony Headphones", Price = 199.00m },
                new Product() { Id = 2003, Name = "Acer Aspire 5 Slim Laptop", Price = 346.00m }
            }; 

        }
            
    }
}
