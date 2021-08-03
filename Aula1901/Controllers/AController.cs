using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1901.Controllers
{
    public class AController : Controller
    {
        // GET: A
        public ActionResult Index()
        {
            List<string> minhaLista = new List<string>();
            minhaLista.Add("ana");
            minhaLista.Add("Rui");
            ViewBag.LISTA1 = minhaLista;


            //List<object> m = new List<object>();
            //m.Add("anaaa");

            //-------------------------------------------------------------
            List<string> listaDeClubes = new List<string>();
            listaDeClubes.Add("benfica");
            listaDeClubes.Add("porto");
            listaDeClubes.Add("braga");
            listaDeClubes.Add("gil vicente");

            var selectList = new SelectList(listaDeClubes);
            ViewBag.SEL = selectList;

            List<string> l = new List<string>();
            l.Add("benfica");
            l.Add("porto");
            l.Add("braga");
            ViewBag.L = l;


            return View();
        }
    }
}