using Mi.Portafolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mi.Portafolio.Controllers
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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel { Proyectos = proyectos };
            return View(modelo);
        }
        private List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>
            {
                new ProyectoViewModel
                {
                    Titulo = "Proyecto1",
                    Descripcion="Desarrollo web front end proyecto1",
                    Link = "https://www.google.com.ar",
                    ImagenURL = "/images/amazon.png"
                },
                new ProyectoViewModel
                {
                    Titulo = "Proyecto2",
                    Descripcion="Desarrollo proyecto2",
                    Link = "https://www.google.com.ar",
                    ImagenURL = "/images/nyt.png"
                },
                new ProyectoViewModel
                {
                    Titulo = "Proyecto3",
                    Descripcion="Desarrollo proyecto3",
                    Link = "https://www.google.com.ar",
                    ImagenURL = "/images/reddit.png"
                },
                 new ProyectoViewModel
                {
                    Titulo = "Proyecto4",
                    Descripcion="Desarrollo proyecto4",
                    Link = "https://www.google.com.ar",
                    ImagenURL = "/images/steam.png"
                }
            };
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
