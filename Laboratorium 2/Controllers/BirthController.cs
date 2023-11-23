using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Birth model)
        {
            if (model.IsValid())
            {
                int age = model.CalculateAge();
                ViewBag.Message = $"Cześć {model.Name}, masz {age} lat(a).";
                return View(model);
            }
            else
            {
                ViewBag.ErrorMessage = "Nieprawidłowe dane formularza.";
                return View("Error");
            }
        }
    }
}
