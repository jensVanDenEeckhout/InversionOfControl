using App_Domain.Entities;
using App_Domain.Interfaces.Repositories;
using System;

namespace App_Infra_Data
{
    public class ProductRepository : IProductRepository
    {

        public void Add(Product product) =>
            Console.WriteLine($"Adding product {product.Id} - {product.Description} into db");
    }
}
