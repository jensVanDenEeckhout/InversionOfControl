using App_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
    }
}
