using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyLibrary.Domain.Interfaces;
using MyLibrary.Mvc2.Models;

namespace MyLibrary.Mvc2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<ILog> _loggers;

        public HomeController(IEnumerable<ILog> loggers)
        {
            _loggers = loggers;
        }

        public IActionResult Index()
        {
            foreach(var _logger in _loggers)
                    _logger.Info("Triggering Index method...");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
