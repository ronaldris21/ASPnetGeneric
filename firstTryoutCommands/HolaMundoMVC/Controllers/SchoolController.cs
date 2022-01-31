using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolaMundoMVC.Models;
using System;

namespace HolaMundoMVC
{
    public class SchoolController : Controller
    {
        private readonly ILogger<SchoolController> _logger;
        public SchoolController(ILogger<SchoolController> _logger)
        {
            this._logger = _logger;
        }

        public IActionResult Index()
        {
            School oSchool  = new School()
            {
                FoundationYear = 2005,
                SchoolId = Guid.NewGuid().ToString(),
                Name = "Leopoldo Mayen Torres"
            };
            
            return View(oSchool);
        }

        
    }
}