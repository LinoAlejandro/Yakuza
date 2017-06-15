using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        YakuzaDBEntities db = new YakuzaDBEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddData(Consumidor consumidor)
        {
            return View();
        }
    }
}