using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.DAL;
using Aula1901.Models;

namespace Aula1901.Controllers
{
    public class DController : Controller
    {
        EquipasContext db = new EquipasContext();
        //Os HELPERS são sempre strings
        public ActionResult Index(string codigoClicado)
        {
            List<Equipa> lista = new List<Equipa>();
            lista = db.TEquipa.ToList();
            SelectList sel1 = new SelectList(lista, "Id", "NomeEquipa");
            ViewBag.SEL1 = sel1;


            ViewBag.CODIGOCLICADO = codigoClicado;

            return View();
        }
    }
}