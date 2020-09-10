using MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.Domain.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
    }
}
