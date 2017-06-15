using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;
using Yakuza.ServiceReference1;
namespace Yakuza.Controllers
{
    public class WebServiceController : Controller
    {
        private ExamenSoapClient client = new ExamenSoapClient();

        // GET: WebService
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult WebService1()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult WebService1(ServicioModel modelo)
        {
            modelo.resultado = client.compararCadenas(modelo.parametro1, modelo.parametro2);
            return View("Resultado", modelo);   
        }

        public ActionResult Resultado(ServicioModel modelo)
        {
            return View();
        }
    }
}