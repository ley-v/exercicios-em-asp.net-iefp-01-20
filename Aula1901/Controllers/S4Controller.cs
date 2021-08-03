using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aula1901.DAL;
using Aula1901.Models;

namespace Aula1901.Controllers
{
    public class S4Controller : Controller
    {
        private EquipasContext db = new EquipasContext();

        // GET: S4
        public ActionResult Index(string criterio)
        {
            var tMembro = db.TMembro.Include(m => m.Equipa);
            return View(tMembro.ToList());
        }

    }
}
