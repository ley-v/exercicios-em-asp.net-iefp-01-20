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
    public class Equipas1Controller : Controller
    {
        private EquipasContext db = new EquipasContext();

        // GET: Equipas1
        public ActionResult Index()
        {
            return View(db.TEquipa.ToList());
        }

        // GET: Equipas1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipa equipa = db.TEquipa.Find(id);
            if (equipa == null)
            {
                return HttpNotFound();
            }
            return View(equipa);
        }

        // GET: Equipas1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipas1/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeEquipa")] Equipa equipa)
        {
            if (ModelState.IsValid)
            {
                db.TEquipa.Add(equipa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipa);
        }

        // GET: Equipas1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipa equipa = db.TEquipa.Find(id);
            if (equipa == null)
            {
                return HttpNotFound();
            }
            return View(equipa);
        }

        // POST: Equipas1/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeEquipa")] Equipa equipa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipa);
        }

        // GET: Equipas1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipa equipa = db.TEquipa.Find(id);
            if (equipa == null)
            {
                return HttpNotFound();
            }
            return View(equipa);
        }

        // POST: Equipas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Equipa equipa = db.TEquipa.Find(id);
            db.TEquipa.Remove(equipa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
