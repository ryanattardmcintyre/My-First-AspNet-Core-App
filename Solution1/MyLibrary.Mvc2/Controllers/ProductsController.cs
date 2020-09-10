using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Domain.Interfaces;

namespace MyLibrary.Mvc2.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository;
        public ProductsController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetProducts().AsEnumerable();

            return View(products);
        }
    }
}