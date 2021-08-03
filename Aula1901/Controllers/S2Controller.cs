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
    public class S2Controller : Controller
    {
        private EquipasContext db = new EquipasContext();

        // GET: S2
        public ActionResult Index(string criterio)
        {
           if(criterio != "sim")
            {
                //todos pela ordem em que estiverem na tabela
                return View(db.TMembro.ToList());
            }
            else
            {
                //todos por ordem alfabética, de A a Z
                return View(db.TMembro.OrderBy(m => m.NomeMembro).ToList());
            }
        }

    }
}
