using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Domain.Interfaces;

namespace MyLibrary.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _log;

        public HomeController (ILog log)
        {
            _log = log;
        }
        public IActionResult Index()
        {
            _log.Info("Home Index method triggered.");
            return View();
        }
    }
}