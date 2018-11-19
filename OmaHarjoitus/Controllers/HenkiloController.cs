using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace OmaHarjoitus.Controllers
{
    public class HenkiloController : Controller
    {
        private ProjektitEntities db = new ProjektitEntities();

        // GET: Henkilo
        public ActionResult Index()
        {
            return View(db.Henkilo.ToList());
        }
    }
}