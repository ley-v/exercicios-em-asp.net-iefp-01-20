using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Aula1901.DAL;
using Aula1901.Models;

namespace Aula1901.Controllers
{
    public class IController : Controller
    {
        //criar apontador para a base de dados
        //(todos os objetos são apontadores)
        private EquipasContext bdp = new EquipasContext();
        public ActionResult Index()
        {
            //---A---------------------------------------------------------------------------------------------------------------
            var a = bdp.TEquipa.ToList();
            ViewBag.A = a;

            //---B---------------------------------------------------------------------------------------------------------------
            var b = bdp.TEquipa.Count();
            ViewBag.B = b;

            //---C---------------------------------------------------------------------------------------------------------------
            // lambda
            //lista por ordem crescente
            var c = bdp.TEquipa.OrderBy(m=>m.NomeEquipa).ToList();
            ViewBag.C = c;

            //---D---------------------------------------------------------------------------------------------------------------
            //lista por ordem decrescente
            var d = bdp.TEquipa.OrderByDescending(x => x.NomeEquipa).ToList();
            ViewBag.D = d;

            //---E---------------------------------------------------------------------------------------------------------------
            int numero = 3;
            Equipa registo = new Equipa();
            registo = bdp.TEquipa.Find(numero);
            ViewBag.E = registo.NomeEquipa;

            //---F---------------------------------------------------------------------------------------------------------------
            int numeroF = 88;
            Equipa registoF = new Equipa();
            registoF = bdp.TEquipa.Find(numeroF);
            if(registoF == null)ViewBag.F = "Equipa com esse número NoM existe";
            else ViewBag.F = registoF.NomeEquipa;

            //---G---------------------------------------------------------------------------------------------------------------
            Equipa registoG = new Equipa();
            registoG = bdp.TEquipa.First();
            ViewBag.G = registoG.NomeEquipa;

            //---H---------------------------------------------------------------------------------------------------------------
            string s = "Arsenal da Devesa";
            //var registoH = bdp.TEquipa.Where(m => m.NomeEquipa.Equals(s)).Count();
            //var registoH = bdp.TEquipa.Where(m => m.NomeEquipa == "Arsenal da Devesa").ToList();
            var registoH = bdp.TEquipa.Where(m => m.NomeEquipa.Equals(s)).ToList();
            int nRegistoH = registoH.Count();
            if (nRegistoH == 0) ViewBag.H = "Não existe";
            else ViewBag.H = "Existe";

            //---I---------------------------------------------------------------------------------------------------------------
            var registoI = bdp.TMembro.Where(m => m.EquipaId.Equals(4)).Count();
            ViewBag.I = registoI;

            //---J---------------------------------------------------------------------------------------------------------------
            string strJ = "Leões da Tecla";
            int IdEquipa = bdp.TEquipa.FirstOrDefault(m => m.NomeEquipa == strJ).Id;
            ViewBag.J = bdp.TMembro.Where(m => m.EquipaId == IdEquipa).Count();

            //---K---------------------------------------------------------------------------------------------------------------





            return View();
        }
    }
}