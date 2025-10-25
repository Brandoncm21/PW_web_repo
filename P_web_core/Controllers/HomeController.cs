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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RecuperarAcceso()
        {
            return View();
        }


        public IActionResult Principal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UsuarioModel usuario)
        {

            return View();
        }
        [HttpPost]
        public IActionResult Registro(UsuarioModel usuario)
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecuperarAcceso(UsuarioModel usuario)
        {
            return View();
        }
    }
}
