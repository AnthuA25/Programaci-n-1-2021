using appventas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace appventas.Controllers
{
    public class ContactoController : Controller
    {
          private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"]=" ";
            return View();
        }
        [HttpPost]
         public IActionResult Create(Contacto objContacto)
        {
            objContacto.Status="Registrado";
            ViewData["Message"]="El contacto ya esta "+ objContacto.Status;
            return View("Index");
        }
    }
}