using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class MaestroDetallePlatilloController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();
        // GET: MestroDetallePlatillo
        public ActionResult Index()
        {
            List<Platillo> platillos = db.Platillo.ToList();
            return View(platillos);
        }

        public ActionResult DetallesParcial(int idPlatillo)
        {
            List<Tag> tags = db.Tag.Where(t => t.IdPlatillo == idPlatillo).ToList();
            List<Precio> precios = db.Precio.Where(p => p.idPlatillo == idPlatillo).ToList();
            List<CategoriaPlatillo> categorias = db.CategoriaPlatillo.Where(c => c.Platillo.Where(p => p.idPlatillo == idPlatillo).Count() > 0).ToList();
            List<String> data = new List<string>();

            foreach (Tag tag in tags)
            {
                data.Add("Tag: " + tag.descripcionTag);
            }

            foreach (Precio precio in precios)
            {
                data.Add(" ");
                data.Add("Tipo: " + precio.descripcionPrecio);
                data.Add("Precio: " + precio.cantidadPrecio.ToString());
            }

            foreach (CategoriaPlatillo categoria in categorias)
            {
                data.Add(" ");
                data.Add("Categoria: ");
                data.Add(categoria.nombreCategoriaPlatillo);
            }

            String[] arrayCadenas = data.ToArray();

            return PartialView(data);
        }
    }
}