using appasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appasp.Controllers
{


    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
    }
        public ActionResult formulario()
        {
            return View();
        }

        public ActionResult Guardar(FormCollection form)
        {
            return View();
        }

        
    }
}