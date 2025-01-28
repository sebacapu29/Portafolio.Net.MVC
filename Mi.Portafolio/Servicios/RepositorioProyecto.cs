using Mi.Portafolio.Models;

namespace Mi.Portafolio.Servicios
{
    public class RepositorioProyecto : IRepositorioProyecto
    {
        public List<ProyectoViewModel> ObtenerProyectos()
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
    }
}
