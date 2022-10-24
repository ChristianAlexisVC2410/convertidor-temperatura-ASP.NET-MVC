using IDGS903Web_convertidor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903Web_convertidor.Controllers
{
    public class ConvertidorController : Controller
    {
        // GET: Convertidor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult convertir()
        {
            Convertidor conver = new Convertidor();
            return View(conver);
        }

        [HttpPost]

        public ActionResult convertir(Convertidor conver, String r1)
        {
            if (r1.Equals("c"))
            {
                conver.convertirCelcious();
            }
            if (r1.Equals("f"))
            {
                conver.convertirFahrenheit();
            }
           
            return View(conver);
        }
       
    }
}