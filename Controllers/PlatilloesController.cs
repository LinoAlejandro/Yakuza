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
    public class PlatilloesController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();

        // GET: Platilloes
        public ActionResult Index()
        {
            var platillo = db.Platillo.Include(p => p.Pais);
            return View(platillo.ToList());
        }

        // GET: Platilloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platillo platillo = db.Platillo.Find(id);
            if (platillo == null)
            {
                return HttpNotFound();
            }
            return View(platillo);
        }

        // GET: Platilloes/Create
        public ActionResult Create()
        {
            ViewBag.idPais = new SelectList(db.Pais, "idPais", "nombrePais");
            return View();
        }

        // POST: Platilloes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPlatillo,nombrePlatillo,descripcionPlatillo,calificacionPlatillo,numeroVisitas,idPais,imagenPlatillo")] Platillo platillo)
        {
            if (ModelState.IsValid)
            {
                db.Platillo.Add(platillo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPais = new SelectList(db.Pais, "idPais", "nombrePais", platillo.idPais);
            return View(platillo);
        }

        // GET: Platilloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platillo platillo = db.Platillo.Find(id);
            if (platillo == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPais = new SelectList(db.Pais, "idPais", "nombrePais", platillo.idPais);
            return View(platillo);
        }

        // POST: Platilloes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPlatillo,nombrePlatillo,descripcionPlatillo,calificacionPlatillo,numeroVisitas,idPais,imagenPlatillo")] Platillo platillo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(platillo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPais = new SelectList(db.Pais, "idPais", "nombrePais", platillo.idPais);
            return View(platillo);
        }

        // GET: Platilloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platillo platillo = db.Platillo.Find(id);
            if (platillo == null)
            {
                return HttpNotFound();
            }
            return View(platillo);
        }

        // POST: Platilloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Platillo platillo = db.Platillo.Find(id);
            db.Platillo.Remove(platillo);
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
