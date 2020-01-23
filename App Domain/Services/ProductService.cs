using App_Domain.Entities;
using App_Domain.Interfaces.Repositories;
using App_Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Domain.Services
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) =>
            _productRepository = productRepository;

        public void RegisterNewProduct(Product product) =>
            _productRepository.Add(product);
    }
}
