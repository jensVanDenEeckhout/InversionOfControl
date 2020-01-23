using App_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Domain.Interfaces.Services
{
    public interface IProductService
    {
        void RegisterNewProduct(Product product);
    }
}
