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
    public class MembroesController : Controller
    {
        private EquipasContext db = new EquipasContext();

        // GET: Membroes
        public ActionResult Index()
        {
            var tMembro = db.TMembro.Include(m => m.Equipa);
            return View(tMembro.ToList());
        }

        // GET: Membroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = db.TMembro.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        // GET: Membroes/Create
        public ActionResult Create()
        {
            ViewBag.EquipaId = new SelectList(db.TEquipa, "Id", "NomeEquipa");
            return View();
        }

        // POST: Membroes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeMembro,EquipaId")] Membro membro)
        {
            if (ModelState.IsValid)
            {
                db.TMembro.Add(membro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EquipaId = new SelectList(db.TEquipa, "Id", "NomeEquipa", membro.EquipaId);
            return View(membro);
        }

        // GET: Membroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = db.TMembro.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            ViewBag.EquipaId = new SelectList(db.TEquipa, "Id", "NomeEquipa", membro.EquipaId);
            return View(membro);
        }

        // POST: Membroes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeMembro,EquipaId")] Membro membro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(membro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EquipaId = new SelectList(db.TEquipa, "Id", "NomeEquipa", membro.EquipaId);
            return View(membro);
        }

        // GET: Membroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = db.TMembro.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        // POST: Membroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro membro = db.TMembro.Find(id);
            db.TMembro.Remove(membro);
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
