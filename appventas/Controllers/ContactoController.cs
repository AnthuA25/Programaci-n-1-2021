using System.Collections.Generic;
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
            var listcontactos= new List<Contacto>();
            listcontactos.Add(new Contacto(){FirstName="Juan", LastName="Perez"});
            listcontactos.Add(new Contacto(){FirstName="Bod", LastName="Marley"});
            listcontactos.Add(new Contacto(){FirstName="Kurth", LastName="Santa"});
            ViewData["Message"]=" ";
            return View(listcontactos);
        }
        [HttpGet]
        public IActionResult Create()
        {
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