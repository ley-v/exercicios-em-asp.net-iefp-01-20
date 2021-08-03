using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



//using System.Data;
//using System.Data.SqlClient;
using RR;

namespace Aula1901.Controllers
{
    //RR: Repositor de Registro
    public class RRaController : Controller
    {
        public ActionResult Index()
        {
            ConectarEColonizar c = new ConectarEColonizar();
            c.RecolonizarTabelaDeEquipas();
            c.RecolonizarTabelaDeMembros();


            return View();
        }
    }




}