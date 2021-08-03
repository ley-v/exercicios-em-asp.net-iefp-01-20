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
    public class FiltroMembrosController : Controller
    {
        private EquipasContext db = new EquipasContext();

        // GET: FiltroMembros // S1
        public ActionResult Index(string filtrox)
        {
            //traz todos os membros
            //var t = db.TMembro;

            //sintaxe query
            var t = from s in db.TMembro select s;


            //seleciona apenas os que contêm a substring
            if (!string.IsNullOrEmpty(filtrox))
            {
                t = t.Where(s => s.NomeMembro.ToUpper().Contains(filtrox));
            }

            var tMembro = db.TMembro.Include(m => m.Equipa);
            return View(t.ToList());
        }

    }
}
