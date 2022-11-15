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
        private int idCad = listaCadetes.Count();
        public IActionResult Index()
        {
            return View(listaCadetes);
        }
        [HttpPost]
        public IActionResult GuardarCadete(Cadete cadete) {
            cadete.Id = idCad;
            listaCadetes.Add(cadete);
            return RedirectToAction("AltaCadete");
        }
        public IActionResult AltaCadete()
        {
            return View();
        }

        public IActionResult BorrarCadete(int id){
            listaCadetes.Remove(listaCadetes.Single(x => x.Id == id));
            if(listaCadetes.Count() <= 0){
                return RedirectToAction("AltaCadete");
            }
            return RedirectToAction("Index");
        }
    }
}