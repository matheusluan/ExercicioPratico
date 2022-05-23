using ExercicioPratico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExercicioPratico.Controllers
{
    public class Exercicio03 : Controller
    {
        private readonly ILogger<Exercicio03> _logger;

        public Exercicio03(ILogger<Exercicio03> logger)
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