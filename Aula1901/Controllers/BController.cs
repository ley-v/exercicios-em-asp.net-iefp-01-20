using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.DAL;
using Aula1901.Models;

namespace Aula1901.Controllers
{
    public class BController : Controller
    {
        private EquipasContext db = new EquipasContext();
        public ActionResult Index()
        {
            List<Equipa> listaDasEquipas = new List<Equipa>();
            listaDasEquipas = db.TEquipa.ToList();
            ViewBag.EQUIPAS = listaDasEquipas;



            ViewBag.MEMBROS = db.TMembro.ToList();




            return View();
        }
    }
}