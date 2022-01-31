using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolaMundoMVC.Models;
using System;
using System.Collections.Generic;

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
            Escuela oSchool  = new Escuela()
            {
                AnoDeCreacion = 2005,
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Leopoldo Mayen Torres",
                Direccion = "Santa Ana",
                Pais = "El Salvador",
                Ciudad = "Santa Ana",
                TipoEscuela = TiposEscuela.Secundaria
            };

            ViewBag.usernameDynamic = "RonaldRis21";
            ViewBag.date =System.DateTime.Now;
            
            return View(oSchool);
        }

    }
}