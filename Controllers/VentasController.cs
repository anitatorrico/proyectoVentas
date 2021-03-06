using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoVentas.Models;

namespace proyectoVentas.Controllers
{
    public class VentasController : Controller
    {
        private readonly ILogger<VentasController> _logger;

        public VentasController(ILogger<VentasController> logger)
        {
            _logger = logger;
        }
        //Principal
        public IActionResult Index()
        {
            return View();
        }
        //Mostrar datos a modificar
        public IActionResult Editar()
        {
            return View();
        }
        //no muestra nada, solo ejecuta actualización en la DB
        public IActionResult Update()
        {
            return View();
        }
        // Mostrar interfaz para crear nuevo
        public IActionResult Create()
        {
            return View();
        }
        // no muestra nada, solo ejecuta para creación en la DB
        public IActionResult Store()
        {
            return View();
        }
        // Elimina de la DB
        public IActionResult Delete()
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