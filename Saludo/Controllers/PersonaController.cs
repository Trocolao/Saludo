using Microsoft.AspNetCore.Mvc;
using Saludo.Models;

namespace Saludo.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Persona()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Saludo(Persona persona)
        {
            return View("Persona",persona);
        }
    }
}
