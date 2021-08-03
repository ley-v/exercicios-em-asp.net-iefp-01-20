using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.DAL;
using Aula1901.Models;

namespace Aula1901.Controllers
{
    public class CController : Controller
    {
        // db é um apontador para a base de dados ***********
        EquipasContext db = new EquipasContext();
        public ActionResult Index()
        {
            List<Equipa> lista1 = new List<Equipa>();
            lista1 = db.TEquipa.ToList();
            SelectList sel1 = new SelectList(lista1, "Id", "NomeEquipa");
            ViewBag.DROP1 = sel1;

            ViewBag.DROP2 = new SelectList(db.TMembro.ToList(), "Id", "NomeMembro");


            return View();
        }
    }
}