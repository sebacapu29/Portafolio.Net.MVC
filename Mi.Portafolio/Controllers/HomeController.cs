using Mi.Portafolio.Models;
using Mi.Portafolio.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mi.Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyecto _repositorioProyecto;
        private readonly IEmailService _emailService;
        public HomeController(IRepositorioProyecto repositorioProyecto, IEmailService emailService)
        {
            _repositorioProyecto = repositorioProyecto;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            var proyectos = _repositorioProyecto.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel { Proyectos = proyectos };
            return View(modelo);
        }
        public IActionResult Proyectos()
        {
            var proyectos = _repositorioProyecto.ObtenerProyectos();
            return View(proyectos);
        }
        public IActionResult Contacto()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await _emailService.SendEmail(contactoViewModel);
            return RedirectToAction("Agradecimiento");
        }
        public IActionResult Agradecimiento()
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
    }
}
