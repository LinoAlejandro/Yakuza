using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class MenuController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();
        // GET: Menu
        public ActionResult Index()
        {
            List<Platillo> platillos = db.Platillo.ToList(); 
            return View(platillos);
        }

        public ActionResult Show(int idPlatillo)
        {
            Platillo platillo = db.Platillo.Where(p => p.idPlatillo == idPlatillo).First();
            Platillo aux = platillo;
            int visitas = aux.numeroVisitas;
            visitas++;
            aux.numeroVisitas = visitas;
            db.Entry(aux).CurrentValues.SetValues(platillo);
            db.SaveChanges();
            return View(platillo);
        }
    }
}