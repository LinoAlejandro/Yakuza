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
        YakuzaEntities db = new YakuzaEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowData(Usuario usuario)
        {
            return View();
        }
    }
}