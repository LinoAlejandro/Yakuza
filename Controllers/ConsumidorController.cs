using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;
using Microsoft.AspNet.Identity;
namespace Yakuza.Controllers
{
    public class ConsumidorController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();
        // GET: Consumidor

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddData()
        {
            return View();
        }

        public ActionResult ObtenerListaDirecciones()
        {
            String nickName = User.Identity.GetUserName();

            Usuario usuario = db.Usuario.Where(u => u.nickNameUsuario == nickName).First();
            Consumidor consumidor = db.Consumidor.Where(c => c.IdUsuario == usuario.IdUsuario).First();

            //check direcciones where consumidor contains this consumidor
            List<Direccion> direcciones = db.Direccion.ToList();
            List<Direccion> direccionesConsumidor = new List<Direccion>();
            foreach (Direccion direccion in direcciones)
            {
                if(direccion.Consumidor.Where(c => c.idConsumidor == consumidor.idConsumidor).Count() > 0)
                {
                    direccionesConsumidor.Add(direccion);
                }
            }

            return View(direccionesConsumidor);
        }

        public ActionResult ObtenerListaTarjetaas()
        {
            String nickName = User.Identity.GetUserName();

            Usuario usuario = db.Usuario.Where(u => u.nickNameUsuario == nickName).First();
            Consumidor consumidor = db.Consumidor.Where(c => c.IdUsuario == usuario.IdUsuario).First();

            //check direcciones where consumidor contains this consumidor
            List<Tarjeta> tarjetas = db.Tarjeta.ToList();
            List<Tarjeta> tarjetasConsumidor = new List<Tarjeta>();
            foreach (Tarjeta tarjeta in tarjetas)
            {
                if (tarjeta.Consumidor.Where(c => c.idConsumidor == consumidor.idConsumidor).Count() > 0)
                {
                    tarjetasConsumidor.Add(tarjeta);
                }
            }

            return View(tarjetasConsumidor);
        }
    }
}