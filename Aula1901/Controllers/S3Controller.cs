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
    public class S3Controller : Controller
    {
        private EquipasContext db = new EquipasContext();

        // GET: S3
        public ActionResult Index(string filtroEquipa, string filtroNome)
        {
            
            if (filtroEquipa == "sim") return View(db.TMembro.OrderBy(m => m.Equipa.NomeEquipa).ToList());

            if (filtroNome == "sim") return View(db.TMembro.OrderBy(m => m.NomeMembro).ToList());
            else return View(db.TMembro.ToList());
        }

        
    }
}
