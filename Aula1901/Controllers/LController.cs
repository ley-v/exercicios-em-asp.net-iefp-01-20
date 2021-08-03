using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.DAL;

namespace Aula1901.Controllers
{
    public class LController : Controller
    {
        EquipasContext p = new EquipasContext();
        // GET: L
        public ActionResult Index()
        {
            //---A1---------------------------------------------------------------------------------------------------------------
            ViewBag.A1 = p.TMembro.Max(m => m.Id);

            //---A2---------------------------------------------------------------------------------------------------------------
            ViewBag.A2 = p.TMembro.Min(m => m.Id);





            return View();
        }
    }
}