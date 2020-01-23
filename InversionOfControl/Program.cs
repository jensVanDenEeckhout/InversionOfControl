using App_Domain.Entities;
using App_Domain.Interfaces.Services;
using App_Domain.Services;
using App_Infra_Data;
using System;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductService(
                new ProductRepository());

            var product = new Product()
            {
                Id = 100,
                Description = "Product Description"
            };

            productService.RegisterNewProduct(product);
            Console.ReadKey();
        }
    }
}
