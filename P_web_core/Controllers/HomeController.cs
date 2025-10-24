using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using P_web_core.Models;

namespace P_web_core.Controllers
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
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult RecuperarAcceso()
        {
            return View();
        }
        public IActionResult Principal()
        {
            return View();
        }

    }
}
