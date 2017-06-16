using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class PreciosController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();

        // GET: Precios
        public ActionResult Index()
        {
            var precio = db.Precio.Include(p => p.Platillo);
            return View(precio.ToList());
        }

        // GET: Precios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio precio = db.Precio.Find(id);
            if (precio == null)
            {
                return HttpNotFound();
            }
            return View(precio);
        }

        // GET: Precios/Create
        public ActionResult Create()
        {
            ViewBag.idPlatillo = new SelectList(db.Platillo, "idPlatillo", "nombrePlatillo");
            return View();
        }

        // POST: Precios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPrecio,descripcionPrecio,cantidadPrecio,idPlatillo")] Precio precio)
        {
            if (ModelState.IsValid)
            {
                db.Precio.Add(precio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPlatillo = new SelectList(db.Platillo, "idPlatillo", "nombrePlatillo", precio.idPlatillo);
            return View(precio);
        }

        // GET: Precios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio precio = db.Precio.Find(id);
            if (precio == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPlatillo = new SelectList(db.Platillo, "idPlatillo", "nombrePlatillo", precio.idPlatillo);
            return View(precio);
        }

        // POST: Precios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPrecio,descripcionPrecio,cantidadPrecio,idPlatillo")] Precio precio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(precio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPlatillo = new SelectList(db.Platillo, "idPlatillo", "nombrePlatillo", precio.idPlatillo);
            return View(precio);
        }

        // GET: Precios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio precio = db.Precio.Find(id);
            if (precio == null)
            {
                return HttpNotFound();
            }
            return View(precio);
        }

        // POST: Precios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Precio precio = db.Precio.Find(id);
            db.Precio.Remove(precio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
