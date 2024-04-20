using L02P02_2021MD601__2021QH601.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace L02P02_2021MD601__2021QH601.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Simulación de lista de autores
            var autores = new List<SelectListItem>
            {
                new SelectListItem { Text = "Francisco Javier Mangandi", Value = "1" },
                new SelectListItem { Text = "Kevin Alexander Quiñonez", Value = "2" },
                // Agrega más autores según sea necesario
            };

            // Simulación de lista de categorías
            var categorias = new List<SelectListItem>
            {
                new SelectListItem { Text = "Cultura", Value = "1" },
                new SelectListItem { Text = "Historia", Value = "2" },
                // Agrega más categorías según sea necesario
            };

            // Pasar las listas a la vista utilizando ViewBag
            ViewBag.Autores = autores;
            ViewBag.Categorias = categorias;

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
