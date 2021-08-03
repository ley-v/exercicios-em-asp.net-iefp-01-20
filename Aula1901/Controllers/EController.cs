using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.ViewModels;
using Aula1901.DAL;

namespace Aula1901.Controllers
{
    public class EController : Controller
    {
        EquipasContext p = new EquipasContext();
        public ActionResult Index()
        {
            EquipaMembros obj = new EquipaMembros();

            obj.Equipas = p.TEquipa.ToList();
            obj.Membros = p.TMembro.ToList();

            return View(obj);
        }
    }
}