using ExercicioPratico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExercicioPratico.Controllers
{
    public class Exercicio02 : Controller
    {
        private readonly ILogger<Exercicio02> _logger;

        public Exercicio02(ILogger<Exercicio02> logger)
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