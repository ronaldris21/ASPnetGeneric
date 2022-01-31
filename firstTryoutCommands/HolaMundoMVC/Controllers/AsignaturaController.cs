using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolaMundoMVC.Models;
using System;
using System.Collections.Generic;

namespace HolaMundoMVC
{
    public class AsignaturaController : Controller
    {
        
        private readonly ILogger<AsignaturaController> _logger;

        public AsignaturaController(ILogger<AsignaturaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            Asignatura asignatura  = new Asignatura()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación",
                
            };

            ViewBag.date =System.DateTime.Now;
            
            return View(asignatura);
        }


        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura> () {
                new Asignatura {
                    Nombre = "Matemáticas",
                    UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                    Nombre = "Educación Física",
                    UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                    Nombre = "Castellano",
                    UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                    Nombre = "Ciencias Naturales",
                    UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                    Nombre = "Programacion",
                    UniqueId = Guid.NewGuid ().ToString ()
                }
            };

            return View("MultiAsignatura",listaAsignaturas);

        }

        
        
    }
}