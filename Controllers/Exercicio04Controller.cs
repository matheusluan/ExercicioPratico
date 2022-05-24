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

        [HttpGet]
        public bool verificaNumber(int number)
        {
            return (soma_divisores(number) == number ? true : false );
        }

        private int soma_divisores(int num)
        {
       
            int soma = 0;

            for (int i = 1; i<=num/2; i++)
            {
                if( (num%i) == 0)
                {
                    soma += i;
                }
            }

            return soma;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}