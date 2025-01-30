using SendGrid.Helpers.Mail;
using SendGrid;
using Mi.Portafolio.Models;

namespace Mi.Portafolio.Servicios
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmail(ContactoViewModel contacto)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = _configuration.GetValue<string>("SENDGRID_NOMBRE");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente { contacto.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var plainTextContent = contacto.Mensaje;
            var htmlContent = @$"<strong>Nombre: </strong> {contacto.Nombre}
                                <strong>Email: </strong>{contacto.Email} 
                                <strong>Mensaje: </strong>{contacto.Mensaje}";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
