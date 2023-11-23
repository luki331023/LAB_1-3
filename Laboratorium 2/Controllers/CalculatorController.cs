﻿using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Reflection;

namespace Laboratorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
