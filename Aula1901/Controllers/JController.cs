using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.ViewModels;
using Aula1901.DAL;
using Aula1901.Models;

namespace Aula1901.Controllers
{
    public class JController : Controller
    {
        EquipasContext p = new EquipasContext();

        public ActionResult Index(int? idD)
        {
            EquipaMembros obj = new EquipaMembros();

            //buscar a lista das equipas para enviar para a drop
            List<Equipa> lista = p.TEquipa.ToList();
            SelectList sel = new SelectList(lista, "id", "nomeEquipa");
            ViewBag.LISTA = sel;

            //o parâmetro idDrop tem o id (ou a PK) da equipe escolhida.
            //então filtra os membros em que exista a FK-idDrop

            var tMembros = p.TMembro.Where(m => m.EquipaId == idD);


            return View(tMembros.ToList());
        }
    }
}