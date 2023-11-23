using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1.Controllers
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
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Calculator(Operator op)
        {
            string aStr = HttpContext.Request.Query["a"];
            string bStr = HttpContext.Request.Query["b"];

            if (aStr == null || bStr == null)
            {
                ViewBag.ErrorMessage = "Required parameter missing";
                return View("Error");
            }

            double a, b;

            if (!double.TryParse(aStr, out a) || !double.TryParse(bStr, out b))
            {
                ViewBag.ErrorMessage = "Parameter not valid";
                return View("Error");
            }

            double result = 0;

            switch (op)
            {
                case Operator.Add:
                    result = a + b;
                    break;
                case Operator.Sub:
                    result = a - b;
                    break;
                case Operator.Mul:
                    result = a * b;
                    break;
                case Operator.Div:
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Division by 0";
                        return View("Error");
                    }
                    break;
                default:
                    ViewBag.ErrorMessage = "Unhandled operator";
                    return View("Error");
            }

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Operator = op;
            ViewBag.Result = result;

            return View();
        }
    }
}
