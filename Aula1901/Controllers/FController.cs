using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.ViewModels;
using Aula1901.DAL;
using System.Data.Entity;


namespace Aula1901.Controllers
{
    public class FController : Controller
    {
        EquipasContext p = new EquipasContext();
        public ActionResult Index(int? id)
        {
            var viewModel = new EquipaMembros();

            viewModel.Equipas = p.TEquipa.Include(m => m.Membros.Select(c => c.Equipa));

            viewModel.Membros = p.TMembro;
            ViewBag.equipaClicada = id;

            return View(viewModel);
        }
    }
}