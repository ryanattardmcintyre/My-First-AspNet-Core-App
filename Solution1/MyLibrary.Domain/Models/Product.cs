using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
