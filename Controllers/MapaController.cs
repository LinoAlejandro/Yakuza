using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class MapaController : Controller
    {
        YakuzaDBEntities db = new YakuzaDBEntities();
        // GET: Map
        public ActionResult Index()
        {
            return View(db.Direccion.ToList());
        }

        public ActionResult MapaParcial(string lat, string lng)
        {
            string[] s = { lat, lng };
            return PartialView(s);
        }
    }
}