using Microsoft.AspNetCore.Mvc;
using CalculadoraMVC.Models;

namespace CalculadoraMVC.Controllers
{
    public class ConversionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double value, string conversion)
        {
            double result = 0;

            if (conversion == "lbToKg")
            {
                result = ConversionModel.LbToKg(value);
            }
            else if (conversion == "kgToLb")
            {
                result = ConversionModel.KgToLb(value);
            }

            ViewBag.Result = result;
            return View();
        }
    }
}
