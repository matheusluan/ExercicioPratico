using ExercicioPratico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExercicioPratico.Controllers
{
    public class Exercicio04 : Controller
    {
        private readonly ILogger<Exercicio04> _logger;

        public Exercicio04(ILogger<Exercicio04> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public Boolean verificaNumber(int number)
        {
            return true;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}