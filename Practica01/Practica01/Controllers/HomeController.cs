using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using System.Diagnostics;

namespace Practica01.Controllers
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

        //importante sin una action no hay vista y viseversa
        public IActionResult Ejercicio(double datoN1,double datoN2) 
        {
            if (datoN1>10 || datoN2>10) 
            {
                return View("ErrornoMayores");
            }

            double resultado = datoN1 + datoN2;
            ViewBag.datoN1V = datoN1;
            ViewBag.datoN2V = datoN2;
            ViewBag.variableaenviar = resultado; 
        return View();
        }
        public IActionResult ErrornoMayores() 
        {
            return View();
        }
        public IActionResult resta(double dator1, double dator2) 
        {
            if (dator1 > 10 || dator2 > 10)
            {
                return View("ErrornoMayores");
            }

            double resultado = dator1 - dator2;
            ViewBag.datoR1V = dator1;
            ViewBag.datoR2V = dator2;
            ViewBag.variableaenviar = resultado;
            return View();

        }
        public IActionResult Multiplicacion(double datoM1, double datoM2)
        {
            if (datoM1 > 10 || datoM2 > 10)
            {
                return View("ErrornoMayores");
            }

            double resultado = datoM1 * datoM2;
            ViewBag.datoM1V = datoM1;
            ViewBag.datoM2V = datoM2;
            ViewBag.variableaenviar = resultado;
            return View();

        }
        public IActionResult Division(double datoD1, double datoD2)
        {
            if (datoD1 > 10 || datoD2 > 10)
            {
                return View("ErrornoMayores");
            }

            double resultado = datoD1 / datoD2;
            ViewBag.datoD1V = datoD1;
            ViewBag.datoD2V = datoD2;
            ViewBag.variableaenviar = resultado;
            return View();

        }
    }
}