using ExercicioPratico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExercicioPratico.Controllers
{
    public class Exercicio05 : Controller
    {
        private readonly ILogger<Exercicio05> _logger;

        public Exercicio05(ILogger<Exercicio05> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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