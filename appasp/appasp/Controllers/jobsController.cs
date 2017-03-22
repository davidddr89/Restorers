using appasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appasp.Controllers
{
    public class jobsController : Controller
    {
        // GET: jobs
        public ActionResult previous()
        {
            RestorerModels model = new RestorerModels();
            ViewBag.Jobs = model.getJobs();
            return View();
        }
        
        public ActionResult entry(string IdJob)
        {
            RestorerModels model = new RestorerModels();
            ViewBag.jobEntry = model.getJob(Convert.ToInt32(Request["IdJob"]));
            ViewBag.entry = "una entrada";
            return View();
        }
    }
}