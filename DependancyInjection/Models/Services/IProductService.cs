using DependancyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyInjection.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
