using System;
using appventas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace appventas.Controllers
{
    public class CalculadoraController : Controller
    {
         private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"]=" ";
            return View();
        }
        [HttpPost]
         public IActionResult Execute(Calculadora objCalculadora)
        {
            Double result = 0.0;
            String message=" ";
            if("+" == objCalculadora.Operando){
                result = objCalculadora.Operando1+objCalculadora.Operando2;
                message="El resultado es " + result;
            }
            if("/" == objCalculadora.Operando){
                if(objCalculadora.Operando2 == 0){
                    message="El numero no puede ser dividido entre 0";
                }else{
                result = objCalculadora.Operando1/objCalculadora.Operando2;
                message="El resultado es " + result;
                }
            }
            ViewData["Message"]=message;
            return View("Index");
        }
    }
}