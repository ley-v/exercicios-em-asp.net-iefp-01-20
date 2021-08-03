using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.DAL;

namespace Aula1901.Controllers
{
    public class A3Controller : Controller
    {
        EquipasContext p = new EquipasContext();
        public ActionResult Index()
        {
            return View(p.TEquipa.ToList());
        }
    }
}