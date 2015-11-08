using liatest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace liatest.Controllers
{
    public class HomeController : Controller
    {

        private CrimeSceneREST crime = new CrimeSceneREST();
        public ActionResult CrimeScene()
        {
            return View("CrimeScene", crime.GetCrimeScenes());
        }
    }
}