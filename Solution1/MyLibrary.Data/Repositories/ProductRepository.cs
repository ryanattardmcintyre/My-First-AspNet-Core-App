using MyLibrary.Data.Context;
using MyLibrary.Domain.Interfaces;
using MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ShoppingCartDbContext _ctx;

        public ProductRepository(ShoppingCartDbContext context)
        {
            _ctx = context;
        }

        public IQueryable<Product> GetProducts()
        {
            return _ctx.Products;
        }
    }
}
