using Mi.Portafolio.Models;

namespace Mi.Portafolio.Servicios
{
    public interface IEmailService
    {
        Task SendEmail(ContactoViewModel contacto);
    }
}
