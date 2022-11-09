using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadeteriaBugMan.Models;
namespace CadeteriaBugMan.Controllers
{
    public class CadeteController : Controller
    {
        static List<Cadete> listaCadetes = new List<Cadete>();
        public IActionResult Index()
        {
            return View(listaCadetes);
        }
        [HttpPost]
        public IActionResult GuardarCadete(Cadete cadete) {
            cadete.Id++;
            ViewData["IdCadet"] = cadete.Id;
            listaCadetes.Add(cadete);
            return RedirectToAction("Index",listaCadetes);
        }
        public IActionResult AltaCadete()
        {
            return View();
        }
    }
}