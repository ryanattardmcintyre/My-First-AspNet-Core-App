using Microsoft.EntityFrameworkCore;
using MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Data.Context
{
     public  class ShoppingCartDbContext: DbContext
    {
          public ShoppingCartDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
